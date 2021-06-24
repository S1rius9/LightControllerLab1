using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightControllerClient.Models;

namespace LightControllerClient
{
    public partial class MainForm : Form
    {
        private CancellationTokenSource cts;
        private volatile ApiClient apiClient;
        private volatile double[] scenarioData;
        private Guid controllerId;

        private Thread reportThread;
            
        public MainForm()
        {
            InitializeComponent();
        }

        private void CheckBoxHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = CheckBoxHidePassword.Checked;
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                scenarioData = File.ReadAllText(TextBoxScenarioFile.Text)
                .Split('\n')
                .Select(double.Parse)
                .ToArray();

                apiClient = new ApiClient(TextBoxHost.Text,
                    TextBoxLogin.Text,
                    TextBoxPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            groupBoxAuthorize.Enabled = false;
            ButtonRun.Enabled = false;
            ButtonBreak.Enabled = true;

            cts = new CancellationTokenSource();
            reportThread = new Thread(async () => {
                try
                {
                    await DoReports(cts.Token);
                }
                catch (OperationCanceledException)
                {
                    
                }
            });
            reportThread.Start();
        }

        private async Task DoReports(CancellationToken cancellationToken)
        {
            Log("Authorize ...");
            await apiClient.Authorize();
            
            foreach (var value in scenarioData)
            {
                cancellationToken.ThrowIfCancellationRequested();

                LightModel settings = new LightModel();

                while (true)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    Log($"Trying create report. Current Light lumens is '{value}'.");
                    settings = await apiClient.CreateReport(controllerId, value);                    
                    if (settings == null)
                    {
                        Log("Authorize ...");
                        await apiClient.Authorize();
                    }
                    else
                    {
                        break;
                    }
                }

                if (settings.Seconds > 0)
                {
                    SetControllerState($"Light is ON.");
                }

                var sleepTime = settings.ReportIntervalSeconds;

                Log($"Wait Seconds to next report: {settings.Seconds}");
                Log($"Next report will be at {DateTime.Now.AddSeconds(settings.Seconds)}");

                if (settings.Seconds != 0 && settings.Seconds < sleepTime)
                {
                    sleepTime -= settings.Seconds;
                    await Task.Delay(TimeSpan.FromSeconds(settings.Seconds));
                    SetControllerState("None");
                    Log($"Light is OFF.");
                }

                await Task.Delay(TimeSpan.FromSeconds(sleepTime), cancellationToken);
            }

            AfterThreadBreak();
        }

        private void ButtonBreak_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            reportThread.Abort();
            AfterThreadBreak();
        }

        private void AfterThreadBreak()
        {            
            var action = new Action(() =>
            {
                groupBoxAuthorize.Enabled = true;
                ButtonRun.Enabled = true;
                ButtonBreak.Enabled = false;
            });

            if (InvokeRequired) Invoke(action);
            else action();
            Log("Work end.");
        }

        private void Log(string message)
        {
            var log = new Action<string>(RichTextBoxLogs.AppendText);
            var logMsg = string.Format("[{0}]: {1}{2}",
                DateTime.Now,
                message,
                Environment.NewLine);

            if (InvokeRequired) Invoke(log, logMsg);
            else log(logMsg);
        }

        private void SetControllerState(string state)
        {
            var stateMsg = $"Current Controller State: {state}";
            var action = new Action(() =>
            {
                LabelControllerState.Text = stateMsg;
            });

            if (InvokeRequired) Invoke(action);
            else action();

            Log($"Controller state is '{state}'.");
        }

        private bool ValidateInput()
        {
            if (!Guid.TryParse(TextBoxControllerId.Text, out controllerId))
            {
                ShowValidationError($"Invalid ID format. It must be in UUID format.\nExample: {Guid.NewGuid()}");
                return false;
            }

            if (string.IsNullOrEmpty(TextBoxLogin.Text))
            {
                ShowValidationError("Login is empty.");
                return false;
            }

            if (string.IsNullOrEmpty(TextBoxPassword.Text))
            {
                ShowValidationError("Password is empty.");
                return false;
            }

            if (string.IsNullOrEmpty(TextBoxHost.Text))
            {
                ShowValidationError("Host is empty.");
                return false;
            }            

            if (!File.Exists(TextBoxScenarioFile.Text))
            {
                ShowValidationError("Selected file not exists.");
                return false;
            }

            return true;
        }

        private static void ShowValidationError(string message)
        {
            MessageBox.Show(message,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxScenarioFile.Text = openFileDialog.FileName;
            }
        }
    }
}
