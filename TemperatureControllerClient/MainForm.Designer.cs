
namespace LightControllerClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAuthorize = new System.Windows.Forms.GroupBox();
            this.CheckBoxHidePassword = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.groupBoxControllerInfo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxControllerId = new System.Windows.Forms.TextBox();
            this.ButtonSelectFile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxScenarioFile = new System.Windows.Forms.TextBox();
            this.LabelControllerState = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RichTextBoxLogs = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxHost = new System.Windows.Forms.TextBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.ButtonBreak = new System.Windows.Forms.Button();
            this.ButtonRun = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxAuthorize.SuspendLayout();
            this.groupBoxControllerInfo.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAuthorize
            // 
            this.groupBoxAuthorize.Controls.Add(this.CheckBoxHidePassword);
            this.groupBoxAuthorize.Controls.Add(this.label2);
            this.groupBoxAuthorize.Controls.Add(this.label1);
            this.groupBoxAuthorize.Controls.Add(this.TextBoxPassword);
            this.groupBoxAuthorize.Controls.Add(this.TextBoxLogin);
            this.groupBoxAuthorize.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAuthorize.Name = "groupBoxAuthorize";
            this.groupBoxAuthorize.Size = new System.Drawing.Size(258, 516);
            this.groupBoxAuthorize.TabIndex = 0;
            this.groupBoxAuthorize.TabStop = false;
            this.groupBoxAuthorize.Text = "Authorize";
            // 
            // CheckBoxHidePassword
            // 
            this.CheckBoxHidePassword.AutoSize = true;
            this.CheckBoxHidePassword.Checked = true;
            this.CheckBoxHidePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxHidePassword.Location = new System.Drawing.Point(37, 134);
            this.CheckBoxHidePassword.Name = "CheckBoxHidePassword";
            this.CheckBoxHidePassword.Size = new System.Drawing.Size(124, 21);
            this.CheckBoxHidePassword.TabIndex = 2;
            this.CheckBoxHidePassword.Text = "Hide Password";
            this.CheckBoxHidePassword.UseVisualStyleBackColor = true;
            this.CheckBoxHidePassword.CheckedChanged += new System.EventHandler(this.CheckBoxHidePassword_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(27, 106);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(206, 22);
            this.TextBoxPassword.TabIndex = 1;
            this.TextBoxPassword.Text = "MyStrong!Passw0rd";
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(27, 58);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(206, 22);
            this.TextBoxLogin.TabIndex = 0;
            this.TextBoxLogin.Text = "Hash";
            // 
            // groupBoxControllerInfo
            // 
            this.groupBoxControllerInfo.Controls.Add(this.label8);
            this.groupBoxControllerInfo.Controls.Add(this.TextBoxControllerId);
            this.groupBoxControllerInfo.Controls.Add(this.ButtonSelectFile);
            this.groupBoxControllerInfo.Controls.Add(this.label7);
            this.groupBoxControllerInfo.Controls.Add(this.TextBoxScenarioFile);
            this.groupBoxControllerInfo.Controls.Add(this.LabelControllerState);
            this.groupBoxControllerInfo.Controls.Add(this.label4);
            this.groupBoxControllerInfo.Controls.Add(this.RichTextBoxLogs);
            this.groupBoxControllerInfo.Controls.Add(this.label3);
            this.groupBoxControllerInfo.Controls.Add(this.TextBoxHost);
            this.groupBoxControllerInfo.Location = new System.Drawing.Point(276, 12);
            this.groupBoxControllerInfo.Name = "groupBoxControllerInfo";
            this.groupBoxControllerInfo.Size = new System.Drawing.Size(512, 439);
            this.groupBoxControllerInfo.TabIndex = 1;
            this.groupBoxControllerInfo.TabStop = false;
            this.groupBoxControllerInfo.Text = "Controller Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Controller Id (UUID format):";
            // 
            // TextBoxControllerId
            // 
            this.TextBoxControllerId.Location = new System.Drawing.Point(16, 95);
            this.TextBoxControllerId.Name = "TextBoxControllerId";
            this.TextBoxControllerId.Size = new System.Drawing.Size(479, 22);
            this.TextBoxControllerId.TabIndex = 9;
            this.TextBoxControllerId.Text = "d180055f-a9f6-421e-af6b-08d93412d6d4";
            // 
            // ButtonSelectFile
            // 
            this.ButtonSelectFile.Location = new System.Drawing.Point(296, 257);
            this.ButtonSelectFile.Name = "ButtonSelectFile";
            this.ButtonSelectFile.Size = new System.Drawing.Size(196, 28);
            this.ButtonSelectFile.TabIndex = 8;
            this.ButtonSelectFile.Text = "Select File ...";
            this.ButtonSelectFile.UseVisualStyleBackColor = true;
            this.ButtonSelectFile.Click += new System.EventHandler(this.ButtonSelectFile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Scenario File:";
            // 
            // TextBoxScenarioFile
            // 
            this.TextBoxScenarioFile.Location = new System.Drawing.Point(16, 229);
            this.TextBoxScenarioFile.Name = "TextBoxScenarioFile";
            this.TextBoxScenarioFile.ReadOnly = true;
            this.TextBoxScenarioFile.Size = new System.Drawing.Size(476, 22);
            this.TextBoxScenarioFile.TabIndex = 6;
            // 
            // LabelControllerState
            // 
            this.LabelControllerState.AutoSize = true;
            this.LabelControllerState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelControllerState.Location = new System.Drawing.Point(12, 154);
            this.LabelControllerState.Name = "LabelControllerState";
            this.LabelControllerState.Size = new System.Drawing.Size(233, 20);
            this.LabelControllerState.TabIndex = 4;
            this.LabelControllerState.Text = "Current Controller State: none";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Logs:";
            // 
            // RichTextBoxLogs
            // 
            this.RichTextBoxLogs.Location = new System.Drawing.Point(6, 320);
            this.RichTextBoxLogs.Name = "RichTextBoxLogs";
            this.RichTextBoxLogs.ReadOnly = true;
            this.RichTextBoxLogs.Size = new System.Drawing.Size(500, 113);
            this.RichTextBoxLogs.TabIndex = 2;
            this.RichTextBoxLogs.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Host (example: http://localhost:4444):";
            // 
            // TextBoxHost
            // 
            this.TextBoxHost.Location = new System.Drawing.Point(16, 48);
            this.TextBoxHost.Name = "TextBoxHost";
            this.TextBoxHost.Size = new System.Drawing.Size(479, 22);
            this.TextBoxHost.TabIndex = 0;
            this.TextBoxHost.Text = "http://localhost:62771";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.ButtonBreak);
            this.groupBoxActions.Controls.Add(this.ButtonRun);
            this.groupBoxActions.Location = new System.Drawing.Point(276, 457);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(512, 71);
            this.groupBoxActions.TabIndex = 2;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // ButtonBreak
            // 
            this.ButtonBreak.Enabled = false;
            this.ButtonBreak.Location = new System.Drawing.Point(224, 21);
            this.ButtonBreak.Name = "ButtonBreak";
            this.ButtonBreak.Size = new System.Drawing.Size(131, 32);
            this.ButtonBreak.TabIndex = 1;
            this.ButtonBreak.Text = "Break";
            this.ButtonBreak.UseVisualStyleBackColor = true;
            this.ButtonBreak.Click += new System.EventHandler(this.ButtonBreak_Click);
            // 
            // ButtonRun
            // 
            this.ButtonRun.Location = new System.Drawing.Point(361, 21);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(131, 32);
            this.ButtonRun.TabIndex = 0;
            this.ButtonRun.Text = "Run";
            this.ButtonRun.UseVisualStyleBackColor = true;
            this.ButtonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxControllerInfo);
            this.Controls.Add(this.groupBoxAuthorize);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light Controller";
            this.groupBoxAuthorize.ResumeLayout(false);
            this.groupBoxAuthorize.PerformLayout();
            this.groupBoxControllerInfo.ResumeLayout(false);
            this.groupBoxControllerInfo.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAuthorize;
        private System.Windows.Forms.GroupBox groupBoxControllerInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.CheckBox CheckBoxHidePassword;
        private System.Windows.Forms.TextBox TextBoxHost;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RichTextBoxLogs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelControllerState;
        private System.Windows.Forms.Button ButtonBreak;
        private System.Windows.Forms.Button ButtonRun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxScenarioFile;
        private System.Windows.Forms.Button ButtonSelectFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxControllerId;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

