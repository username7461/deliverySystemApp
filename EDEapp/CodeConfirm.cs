using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace EDEapp
{
    
    public partial class CodeConfirm : Form
    {
        public static string CIP = "";
        public void getIP()  // get customer IP
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    CIP = ip.ToString();
                }
            }
        }
        string randomCode;
        public static string to;
        public CodeConfirm()
        {
            InitializeComponent();
        }

        private void CodeConfirm_Load(object sender, EventArgs e)
        {
            btn_verifycode.Enabled = false;
            txt_confirmcode.Enabled = false;
            getIP();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Regex emailvaild = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
              + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
              + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
            bool emailisValid = emailvaild.IsMatch(txt_email.Text.Trim());
            bool checkemailexist = false;
            if (txt_email.Text.Trim() == "")
            {
                MessageBox.Show("Email cant be null");
            }
            else if (!emailisValid)
            {
                MessageBox.Show("Email is not Invalid");
            }
            else
            {

                using (var customercheck = new edeaccountEntities())
                {
                    var customer = (from list in customercheck.customer
                                    select list);
                    foreach (var customer2 in customer.ToList())
                    {
                        if (customer2.email == txt_email.Text)
                        {
                            checkemailexist = true;
                            break;
                        }
                    }

                    if (checkemailexist)
                    {
                        using (edeaccountEntities content = new edeaccountEntities())
                        {
                            string from, pass, messageBody;
                            Random rand = new Random();
                            randomCode = (rand.Next(999999)).ToString();
                            MailMessage message = new MailMessage();
                            to = (txt_email.Text).ToString();
                            from = "yuk226817@gmail.com";
                            pass = "pkuwndeixqypshxw";
                            messageBody = "your reset code is " + randomCode;
                            message.To.Add(to);
                            message.From = new MailAddress(from);
                            message.Body = messageBody;
                            message.Subject = "password reseting code";
                            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                            smtp.EnableSsl = true;
                            smtp.Port = 587;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(from, pass);
                            smtp.Send(message);
                            MessageBox.Show("Code send sucessfully");
                            customer cs = content.customer.SingleOrDefault(i => i.email == txt_email.Text);
                            log logging = new log
                            {
                                accountID = cs.accountID,
                                times = DateTime.Now,
                                actionPerformed = txt_email.Text + " got reset password code ",
                                ipAddress = CIP

                            };
                            content.log.Add(logging);
                            content.SaveChanges();
                            btn_verifycode.Enabled = true;
                            txt_confirmcode.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email not registerd");
                    }
                }
            }


        }

        private void btn_verifycode_Click(object sender, EventArgs e)
        {
            if(randomCode== (txt_confirmcode.Text).ToString())
            {
                to = txt_email.Text;
                ReSetPassWord rp = new ReSetPassWord();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("wrong code");
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
