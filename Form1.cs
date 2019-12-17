using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MimeKit;
using MailKit.Net.Smtp;
using System.IO;
using EmailValidation;

namespace EmailTest
{
    public partial class EmailTesterForm : Form
    {
        
        public EmailTesterForm()
        {
            InitializeComponent();
            tB_SenderEMail.Validating += TB_SenderEMail_Validating;
            tB_TO.Validating += TB_TO_Validating;
            tB_SMTPServer.Validating += TB_SMTPServer_Validated;


        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            try
            {
                if (File.Exists(tB_LogPath.Text))
                {
                    File.Delete(tB_LogPath.Text);
                }
                errorProvider1.Clear();
            }
            catch { }
        }

        private void EmailTesterForm_Load(object sender, EventArgs e)
        {
            
            cB_HTMLContent.Visible = false;
            TabPageExtensions.HidePage(tP_Logs);
            TabPageExtensions.HidePage(tP_SMTPTrace);
            tB_SMTPPort.Text = "25";
            tB_LogPath.Text = @"smtp_trace.log";
            tB_SenderName.Text = @"Test messages";
            tB_SenderEMail.Text = @"test@test.ru";
            tB_Subject.Text = @"Test messages";
            rTB_EmailContentBox.Text = "Hi \n This test messages, don't replay them. \n\v Best regard, \n Post office System Administrator";
            try
            {
                if (File.Exists(tB_LogPath.Text))
                {
                    File.Delete(tB_LogPath.Text);
                }
            }
            catch { }
        }

        private void BtSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(tB_LogPath.Text))
                {
                    File.Delete(tB_LogPath.Text);
                }

                if (!(TabPageExtensions.IsVisible(tP_SMTPTrace)))
                {
                    TabPageExtensions.ShowPageInTabControl(tP_SMTPTrace, tab_Logging);
                    TabPageExtensions.ShowPageInTabControl(tP_Logs, tab_Logging);
                }
            }
            catch { }

            if (Validate_Recipient_eMail() && Validate_Sender_eMail() && Validate_SMTPServer())
            {

                try
                {
                    var message = new MimeMessage();
                    message.To.Add(new MailboxAddress(tB_TO.Text));
                    message.From.Add(new MailboxAddress(tB_SenderName.Text, tB_SenderEMail.Text));
                    
                    message.Subject = tB_Subject.Text;
                    message.Body = new TextPart("plain")
                    {
                        Text = rTB_EmailContentBox.Text
                    };

                    using (var client = new SmtpClient(new ProtocolLogger(tB_LogPath.Text)))
                    {
                        #region Configure Authentication
                        // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                        //client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                        // Note: only needed if the SMTP server requires authentication
                        //client.Authenticate(tB_SenderName.Text, tB_SenderPassword.Text);
                        #endregion


                        client.Connect(tB_SMTPServer.Text, int.Parse(tB_SMTPPort.Text));
                        client.Send(message);
                        client.Disconnect(true);

                    }

                    #region // Читаем лог и пишем в tB_SMTPTrace.Text
                    StreamReader srRead = new StreamReader(tB_LogPath.Text);
                    string strFileText = "";
                    strFileText = srRead.ReadToEnd();
                    srRead.Close();
                    tB_SMTPTrace.Text = strFileText;
                    #endregion
                }
                catch (Exception ex)
                {
                    tB_Logs.AppendText(ex.Message + " \n");
                    // tB_Logs.AppendText(ex.StackTrace + " \n");
                }
            }
        }



        #region  * Проверка правильности заполения полей адресов
        /*
            * Проверка правильности заполения полей адресов
            * Sender Email, Recipient EMail
         */

        private void TB_SMTPServer_Validated(object sender, EventArgs e)
        {
            Validate_SMTPServer();
        }

        private void TB_SenderEMail_Validating(object sender, CancelEventArgs e)
        {
            Validate_Sender_eMail();
            
        }

        private void TB_TO_Validating(object sender, CancelEventArgs e)
        {
            Validate_Recipient_eMail();
            
        }

        private void TB_SMTPPort_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tB_SMTPPort.Text, out int res) && int.Parse(tB_SMTPPort.Text) < 65536 && int.Parse(tB_SMTPPort.Text) > 0)
            {
                tB_SMTPPort.Font = new Font(tB_SMTPPort.Font, FontStyle.Bold);
            }
            else
            {
                tB_SMTPPort.Text = "25";

            }
        }

        private void TB_TO_TextChanged(object sender, EventArgs e)
        {
            Validate_Recipient_eMail();
        }

        private void TB_SenderEMail_TextChanged(object sender, EventArgs e)
        {
            Validate_Sender_eMail();
        }

        private bool Validate_SMTPServer()
        {
            bool check_Status = true;
            if (string.IsNullOrEmpty(tB_SMTPServer.Text) )
            {
                tabBasic.SelectedTab = tabSetup;
                tB_SMTPServer.Focus();
                tB_SMTPServer.Select();
                errorProvider1.SetError(tB_SMTPServer, "Please enter Host name IP or FQDN");
                check_Status = false;

            }
            else
            {
                errorProvider1.SetError(tB_SMTPServer, "");
                errorProvider1.Clear();
            }

            return check_Status;
        }


        private bool Validate_Sender_eMail()
        {
            bool check_Status = true;
            if (string.IsNullOrEmpty(tB_SenderEMail.Text) || (!EmailValidator.Validate(tB_SenderEMail.Text)))
            {
                tabBasic.SelectedTab = tabRecipients;
                tB_SenderEMail.Focus();
                tB_SenderEMail.Select();
                errorProvider1.SetError(tB_SenderEMail, "Please enter sender email");
                check_Status = false;

            }
            else
            {
                errorProvider1.SetError(tB_SenderEMail, "");
                errorProvider1.Clear();
            }

            return check_Status;
        }

        private bool Validate_Recipient_eMail()
        {
            bool check_Status = true;
            if (string.IsNullOrEmpty(tB_TO.Text) || (!EmailValidator.Validate(tB_SenderEMail.Text)))
            {
                tabBasic.SelectedTab = tabRecipients;
                tabRecipients.Select();
                tabRecipients.Focus();
                tB_TO.Focus();
                tB_TO.Select();
                errorProvider1.SetError(tB_TO, "Please enter recipient email");
                check_Status = false;

            }
            else
            {
                errorProvider1.SetError(tB_TO, "");
                errorProvider1.Clear();
            }

            return check_Status;
        }
        #endregion

       
    }

    
    


    #region Класс для работы со страницами TAB CONTROL
    /*Класс для работы со страницами TAB CONTROL
    Пример: 
    TabPageExtensions.HidePage(ИМЯ_ТАБ_КОТОРОЕ_СКРЫТЬ);
    TabPageExtensions.ShowPageInTabControl(ИМЯ_ТАБ_КОТОРОЕ_Показать);
    TabPageExtensions.IsVisible(ИМЯ_ТАБ_КОТОРОЕ_Проверить_на_Существование);
    */

    public static class TabPageExtensions
    {
        public static bool IsVisible(this TabPage tabPage)
        {
            if (tabPage.Parent == null)
                return false;
            else if (tabPage.Parent.Contains(tabPage))
                return true;
            else
                return false;
        }

        public static void HidePage(this TabPage tabPage)
        {
            TabControl parent = (TabControl)tabPage.Parent;
            parent.TabPages.Remove(tabPage);
        }
        

        public static void ShowPageInTabControl(this TabPage tabPage, TabControl parent)
        {
            parent.TabPages.Add(tabPage);
        }
    }
}
#endregion