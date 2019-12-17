namespace EmailTest
{
    partial class EmailTesterForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabBasic = new System.Windows.Forms.TabControl();
            this.tabRecipients = new System.Windows.Forms.TabPage();
            this.tB_Subject = new System.Windows.Forms.TextBox();
            this.tB_SenderEMail = new System.Windows.Forms.TextBox();
            this.tB_SenderName = new System.Windows.Forms.TextBox();
            this.l_Subject = new System.Windows.Forms.Label();
            this.l_SenderEmail = new System.Windows.Forms.Label();
            this.l_SenderName = new System.Windows.Forms.Label();
            this.l_TO = new System.Windows.Forms.Label();
            this.tB_TO = new System.Windows.Forms.TextBox();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.cB_SetUserName = new System.Windows.Forms.CheckBox();
            this.tB_LogPath = new System.Windows.Forms.TextBox();
            this.l_LogFile = new System.Windows.Forms.Label();
            this.tB_SMTPPort = new System.Windows.Forms.TextBox();
            this.l_SMTPPort = new System.Windows.Forms.Label();
            this.tB_SenderPassword = new System.Windows.Forms.TextBox();
            this.tB_User = new System.Windows.Forms.TextBox();
            this.tB_SMTPServer = new System.Windows.Forms.TextBox();
            this.l_SMTPPassword = new System.Windows.Forms.Label();
            this.l_SMTPUser = new System.Windows.Forms.Label();
            this.l_SMTPServer = new System.Windows.Forms.Label();
            this.tab_Logging = new System.Windows.Forms.TabControl();
            this.tP_EmailContent = new System.Windows.Forms.TabPage();
            this.rTB_EmailContentBox = new System.Windows.Forms.RichTextBox();
            this.tP_Logs = new System.Windows.Forms.TabPage();
            this.tB_Logs = new System.Windows.Forms.TextBox();
            this.tP_SMTPTrace = new System.Windows.Forms.TabPage();
            this.tB_SMTPTrace = new System.Windows.Forms.TextBox();
            this.btSendMail = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.b_Exit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cB_HTMLContent = new System.Windows.Forms.CheckBox();
            this.tabBasic.SuspendLayout();
            this.tabRecipients.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.tab_Logging.SuspendLayout();
            this.tP_EmailContent.SuspendLayout();
            this.tP_Logs.SuspendLayout();
            this.tP_SMTPTrace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBasic
            // 
            this.tabBasic.Controls.Add(this.tabRecipients);
            this.tabBasic.Controls.Add(this.tabSetup);
            this.tabBasic.Location = new System.Drawing.Point(12, 12);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.SelectedIndex = 0;
            this.tabBasic.Size = new System.Drawing.Size(776, 192);
            this.tabBasic.TabIndex = 0;
            // 
            // tabRecipients
            // 
            this.tabRecipients.Controls.Add(this.cB_HTMLContent);
            this.tabRecipients.Controls.Add(this.tB_Subject);
            this.tabRecipients.Controls.Add(this.tB_SenderEMail);
            this.tabRecipients.Controls.Add(this.tB_SenderName);
            this.tabRecipients.Controls.Add(this.l_Subject);
            this.tabRecipients.Controls.Add(this.l_SenderEmail);
            this.tabRecipients.Controls.Add(this.l_SenderName);
            this.tabRecipients.Controls.Add(this.l_TO);
            this.tabRecipients.Controls.Add(this.tB_TO);
            this.tabRecipients.Location = new System.Drawing.Point(4, 22);
            this.tabRecipients.Name = "tabRecipients";
            this.tabRecipients.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecipients.Size = new System.Drawing.Size(768, 166);
            this.tabRecipients.TabIndex = 0;
            this.tabRecipients.Text = "Recipients";
            this.tabRecipients.UseVisualStyleBackColor = true;
            // 
            // tB_Subject
            // 
            this.tB_Subject.Location = new System.Drawing.Point(57, 134);
            this.tB_Subject.Name = "tB_Subject";
            this.tB_Subject.Size = new System.Drawing.Size(705, 20);
            this.tB_Subject.TabIndex = 17;
            // 
            // tB_SenderEMail
            // 
            this.tB_SenderEMail.Location = new System.Drawing.Point(125, 35);
            this.tB_SenderEMail.Name = "tB_SenderEMail";
            this.tB_SenderEMail.Size = new System.Drawing.Size(460, 20);
            this.tB_SenderEMail.TabIndex = 16;
            this.tB_SenderEMail.TextChanged += new System.EventHandler(this.TB_SenderEMail_TextChanged);
            this.tB_SenderEMail.Validating += new System.ComponentModel.CancelEventHandler(this.TB_SenderEMail_Validating);
            // 
            // tB_SenderName
            // 
            this.tB_SenderName.Location = new System.Drawing.Point(125, 10);
            this.tB_SenderName.Name = "tB_SenderName";
            this.tB_SenderName.Size = new System.Drawing.Size(460, 20);
            this.tB_SenderName.TabIndex = 15;
            // 
            // l_Subject
            // 
            this.l_Subject.AutoSize = true;
            this.l_Subject.Location = new System.Drawing.Point(8, 139);
            this.l_Subject.Name = "l_Subject";
            this.l_Subject.Size = new System.Drawing.Size(43, 13);
            this.l_Subject.TabIndex = 14;
            this.l_Subject.Text = "Subject";
            // 
            // l_SenderEmail
            // 
            this.l_SenderEmail.AutoSize = true;
            this.l_SenderEmail.Location = new System.Drawing.Point(8, 39);
            this.l_SenderEmail.Name = "l_SenderEmail";
            this.l_SenderEmail.Size = new System.Drawing.Size(79, 13);
            this.l_SenderEmail.TabIndex = 13;
            this.l_SenderEmail.Text = "Sender\'s Email:";
            // 
            // l_SenderName
            // 
            this.l_SenderName.AutoSize = true;
            this.l_SenderName.Location = new System.Drawing.Point(8, 13);
            this.l_SenderName.Name = "l_SenderName";
            this.l_SenderName.Size = new System.Drawing.Size(82, 13);
            this.l_SenderName.TabIndex = 12;
            this.l_SenderName.Text = "Sender\'s Name:";
            // 
            // l_TO
            // 
            this.l_TO.AutoSize = true;
            this.l_TO.Location = new System.Drawing.Point(6, 65);
            this.l_TO.Name = "l_TO";
            this.l_TO.Size = new System.Drawing.Size(76, 13);
            this.l_TO.TabIndex = 3;
            this.l_TO.Text = "Recipients To:";
            // 
            // tB_TO
            // 
            this.tB_TO.Location = new System.Drawing.Point(125, 60);
            this.tB_TO.Name = "tB_TO";
            this.tB_TO.Size = new System.Drawing.Size(460, 20);
            this.tB_TO.TabIndex = 0;
            this.tB_TO.TextChanged += new System.EventHandler(this.TB_TO_TextChanged);
            this.tB_TO.Validating += new System.ComponentModel.CancelEventHandler(this.TB_TO_Validating);
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.cB_SetUserName);
            this.tabSetup.Controls.Add(this.tB_LogPath);
            this.tabSetup.Controls.Add(this.l_LogFile);
            this.tabSetup.Controls.Add(this.tB_SMTPPort);
            this.tabSetup.Controls.Add(this.l_SMTPPort);
            this.tabSetup.Controls.Add(this.tB_SenderPassword);
            this.tabSetup.Controls.Add(this.tB_User);
            this.tabSetup.Controls.Add(this.tB_SMTPServer);
            this.tabSetup.Controls.Add(this.l_SMTPPassword);
            this.tabSetup.Controls.Add(this.l_SMTPUser);
            this.tabSetup.Controls.Add(this.l_SMTPServer);
            this.tabSetup.Location = new System.Drawing.Point(4, 22);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(768, 166);
            this.tabSetup.TabIndex = 2;
            this.tabSetup.Text = "Mail Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // cB_SetUserName
            // 
            this.cB_SetUserName.AutoSize = true;
            this.cB_SetUserName.Location = new System.Drawing.Point(584, 35);
            this.cB_SetUserName.Name = "cB_SetUserName";
            this.cB_SetUserName.Size = new System.Drawing.Size(15, 14);
            this.cB_SetUserName.TabIndex = 17;
            this.cB_SetUserName.UseVisualStyleBackColor = true;
            // 
            // tB_LogPath
            // 
            this.tB_LogPath.Location = new System.Drawing.Point(118, 81);
            this.tB_LogPath.Name = "tB_LogPath";
            this.tB_LogPath.Size = new System.Drawing.Size(460, 20);
            this.tB_LogPath.TabIndex = 16;
            // 
            // l_LogFile
            // 
            this.l_LogFile.AutoSize = true;
            this.l_LogFile.Location = new System.Drawing.Point(8, 81);
            this.l_LogFile.Name = "l_LogFile";
            this.l_LogFile.Size = new System.Drawing.Size(44, 13);
            this.l_LogFile.TabIndex = 15;
            this.l_LogFile.Text = "Log File";
            // 
            // tB_SMTPPort
            // 
            this.tB_SMTPPort.Location = new System.Drawing.Point(648, 9);
            this.tB_SMTPPort.Name = "tB_SMTPPort";
            this.tB_SMTPPort.Size = new System.Drawing.Size(114, 20);
            this.tB_SMTPPort.TabIndex = 14;
            this.tB_SMTPPort.TextChanged += new System.EventHandler(this.TB_SMTPPort_TextChanged);
            // 
            // l_SMTPPort
            // 
            this.l_SMTPPort.AutoSize = true;
            this.l_SMTPPort.Location = new System.Drawing.Point(584, 12);
            this.l_SMTPPort.Name = "l_SMTPPort";
            this.l_SMTPPort.Size = new System.Drawing.Size(58, 13);
            this.l_SMTPPort.TabIndex = 13;
            this.l_SMTPPort.Text = "SMTP port";
            // 
            // tB_SenderPassword
            // 
            this.tB_SenderPassword.Location = new System.Drawing.Point(426, 33);
            this.tB_SenderPassword.Name = "tB_SenderPassword";
            this.tB_SenderPassword.PasswordChar = '*';
            this.tB_SenderPassword.ReadOnly = true;
            this.tB_SenderPassword.Size = new System.Drawing.Size(152, 20);
            this.tB_SenderPassword.TabIndex = 8;
            // 
            // tB_User
            // 
            this.tB_User.Location = new System.Drawing.Point(118, 33);
            this.tB_User.Name = "tB_User";
            this.tB_User.ReadOnly = true;
            this.tB_User.Size = new System.Drawing.Size(171, 20);
            this.tB_User.TabIndex = 7;
            // 
            // tB_SMTPServer
            // 
            this.tB_SMTPServer.Location = new System.Drawing.Point(118, 9);
            this.tB_SMTPServer.Name = "tB_SMTPServer";
            this.tB_SMTPServer.Size = new System.Drawing.Size(460, 20);
            this.tB_SMTPServer.TabIndex = 6;
            this.tB_SMTPServer.Validated += new System.EventHandler(this.TB_SMTPServer_Validated);
            // 
            // l_SMTPPassword
            // 
            this.l_SMTPPassword.AutoSize = true;
            this.l_SMTPPassword.Location = new System.Drawing.Point(316, 36);
            this.l_SMTPPassword.Name = "l_SMTPPassword";
            this.l_SMTPPassword.Size = new System.Drawing.Size(86, 13);
            this.l_SMTPPassword.TabIndex = 2;
            this.l_SMTPPassword.Text = "SMTP Password";
            // 
            // l_SMTPUser
            // 
            this.l_SMTPUser.AutoSize = true;
            this.l_SMTPUser.Location = new System.Drawing.Point(8, 33);
            this.l_SMTPUser.Name = "l_SMTPUser";
            this.l_SMTPUser.Size = new System.Drawing.Size(62, 13);
            this.l_SMTPUser.TabIndex = 1;
            this.l_SMTPUser.Text = "SMTP User";
            // 
            // l_SMTPServer
            // 
            this.l_SMTPServer.AutoSize = true;
            this.l_SMTPServer.Location = new System.Drawing.Point(8, 9);
            this.l_SMTPServer.Name = "l_SMTPServer";
            this.l_SMTPServer.Size = new System.Drawing.Size(62, 13);
            this.l_SMTPServer.TabIndex = 0;
            this.l_SMTPServer.Text = "SMTP Host";
            // 
            // tab_Logging
            // 
            this.tab_Logging.Controls.Add(this.tP_EmailContent);
            this.tab_Logging.Controls.Add(this.tP_Logs);
            this.tab_Logging.Controls.Add(this.tP_SMTPTrace);
            this.tab_Logging.Location = new System.Drawing.Point(16, 204);
            this.tab_Logging.Name = "tab_Logging";
            this.tab_Logging.SelectedIndex = 0;
            this.tab_Logging.Size = new System.Drawing.Size(776, 205);
            this.tab_Logging.TabIndex = 1;
            // 
            // tP_EmailContent
            // 
            this.tP_EmailContent.Controls.Add(this.rTB_EmailContentBox);
            this.tP_EmailContent.Location = new System.Drawing.Point(4, 22);
            this.tP_EmailContent.Name = "tP_EmailContent";
            this.tP_EmailContent.Padding = new System.Windows.Forms.Padding(3);
            this.tP_EmailContent.Size = new System.Drawing.Size(768, 179);
            this.tP_EmailContent.TabIndex = 0;
            this.tP_EmailContent.Text = "Email Content";
            this.tP_EmailContent.UseVisualStyleBackColor = true;
            // 
            // rTB_EmailContentBox
            // 
            this.rTB_EmailContentBox.Location = new System.Drawing.Point(7, 7);
            this.rTB_EmailContentBox.Name = "rTB_EmailContentBox";
            this.rTB_EmailContentBox.Size = new System.Drawing.Size(755, 166);
            this.rTB_EmailContentBox.TabIndex = 0;
            this.rTB_EmailContentBox.Text = "";
            // 
            // tP_Logs
            // 
            this.tP_Logs.Controls.Add(this.tB_Logs);
            this.tP_Logs.Location = new System.Drawing.Point(4, 22);
            this.tP_Logs.Name = "tP_Logs";
            this.tP_Logs.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Logs.Size = new System.Drawing.Size(768, 179);
            this.tP_Logs.TabIndex = 1;
            this.tP_Logs.Text = "Logs";
            this.tP_Logs.UseVisualStyleBackColor = true;
            // 
            // tB_Logs
            // 
            this.tB_Logs.Location = new System.Drawing.Point(7, 7);
            this.tB_Logs.Multiline = true;
            this.tB_Logs.Name = "tB_Logs";
            this.tB_Logs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB_Logs.Size = new System.Drawing.Size(757, 166);
            this.tB_Logs.TabIndex = 0;
            // 
            // tP_SMTPTrace
            // 
            this.tP_SMTPTrace.Controls.Add(this.tB_SMTPTrace);
            this.tP_SMTPTrace.Location = new System.Drawing.Point(4, 22);
            this.tP_SMTPTrace.Name = "tP_SMTPTrace";
            this.tP_SMTPTrace.Size = new System.Drawing.Size(768, 179);
            this.tP_SMTPTrace.TabIndex = 2;
            this.tP_SMTPTrace.Text = "SMTP Trace";
            this.tP_SMTPTrace.UseVisualStyleBackColor = true;
            // 
            // tB_SMTPTrace
            // 
            this.tB_SMTPTrace.Location = new System.Drawing.Point(6, 6);
            this.tB_SMTPTrace.Multiline = true;
            this.tB_SMTPTrace.Name = "tB_SMTPTrace";
            this.tB_SMTPTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB_SMTPTrace.Size = new System.Drawing.Size(757, 166);
            this.tB_SMTPTrace.TabIndex = 1;
            // 
            // btSendMail
            // 
            this.btSendMail.Location = new System.Drawing.Point(20, 415);
            this.btSendMail.Name = "btSendMail";
            this.btSendMail.Size = new System.Drawing.Size(75, 23);
            this.btSendMail.TabIndex = 2;
            this.btSendMail.Text = "Send Email";
            this.btSendMail.UseVisualStyleBackColor = true;
            this.btSendMail.Click += new System.EventHandler(this.BtSendMail_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Click button to sent test email";
            // 
            // b_Exit
            // 
            this.b_Exit.Location = new System.Drawing.Point(712, 415);
            this.b_Exit.Name = "b_Exit";
            this.b_Exit.Size = new System.Drawing.Size(75, 23);
            this.b_Exit.TabIndex = 13;
            this.b_Exit.Text = "Exit";
            this.b_Exit.UseVisualStyleBackColor = true;
            this.b_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cB_HTMLContent
            // 
            this.cB_HTMLContent.AutoSize = true;
            this.cB_HTMLContent.Location = new System.Drawing.Point(611, 37);
            this.cB_HTMLContent.Name = "cB_HTMLContent";
            this.cB_HTMLContent.Size = new System.Drawing.Size(124, 17);
            this.cB_HTMLContent.TabIndex = 18;
            this.cB_HTMLContent.Text = "Send HTML Content";
            this.cB_HTMLContent.UseVisualStyleBackColor = true;
            // 
            // EmailTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_Exit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btSendMail);
            this.Controls.Add(this.tab_Logging);
            this.Controls.Add(this.tabBasic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmailTesterForm";
            this.Text = "EmailTester";
            this.Load += new System.EventHandler(this.EmailTesterForm_Load);
            this.tabBasic.ResumeLayout(false);
            this.tabRecipients.ResumeLayout(false);
            this.tabRecipients.PerformLayout();
            this.tabSetup.ResumeLayout(false);
            this.tabSetup.PerformLayout();
            this.tab_Logging.ResumeLayout(false);
            this.tP_EmailContent.ResumeLayout(false);
            this.tP_Logs.ResumeLayout(false);
            this.tP_Logs.PerformLayout();
            this.tP_SMTPTrace.ResumeLayout(false);
            this.tP_SMTPTrace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabBasic;
        private System.Windows.Forms.TabPage tabRecipients;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.Label l_SMTPPassword;
        private System.Windows.Forms.Label l_SMTPUser;
        private System.Windows.Forms.Label l_SMTPServer;
        private System.Windows.Forms.TabControl tab_Logging;
        private System.Windows.Forms.TabPage tP_EmailContent;
        private System.Windows.Forms.TabPage tP_Logs;
        private System.Windows.Forms.Button btSendMail;
        private System.Windows.Forms.TextBox tB_SenderPassword;
        private System.Windows.Forms.TextBox tB_User;
        private System.Windows.Forms.TextBox tB_SMTPServer;
        private System.Windows.Forms.TabPage tP_SMTPTrace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rTB_EmailContentBox;
        private System.Windows.Forms.Button b_Exit;
        private System.Windows.Forms.Label l_TO;
        private System.Windows.Forms.TextBox tB_TO;
        private System.Windows.Forms.TextBox tB_SMTPPort;
        private System.Windows.Forms.Label l_SMTPPort;
        private System.Windows.Forms.TextBox tB_Logs;
        private System.Windows.Forms.TextBox tB_SMTPTrace;
        private System.Windows.Forms.TextBox tB_LogPath;
        private System.Windows.Forms.Label l_LogFile;
        private System.Windows.Forms.TextBox tB_Subject;
        private System.Windows.Forms.TextBox tB_SenderEMail;
        private System.Windows.Forms.TextBox tB_SenderName;
        private System.Windows.Forms.Label l_Subject;
        private System.Windows.Forms.Label l_SenderEmail;
        private System.Windows.Forms.Label l_SenderName;
        private System.Windows.Forms.CheckBox cB_SetUserName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox cB_HTMLContent;
    }
}

