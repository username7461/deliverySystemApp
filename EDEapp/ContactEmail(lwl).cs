using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EDEapp
{
    public partial class ContactEmailLWL : Form
    {
        public static string CIP = "";
        public static string from;
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
        public ContactEmailLWL()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Regex emailvaild = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
             + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
             + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
            bool emailisValid = emailvaild.IsMatch(txt_email.Text.Trim());
            if (txt_email.Text.Trim() == "")
            {
                MessageBox.Show("Email cant be null");
            }
            else if (!emailisValid)
            {
                MessageBox.Show("Email is not Invalid");
            }
            else if (txt_name.Text.Trim() == "")
            {
                MessageBox.Show("Name cant be null");
            }
            else if (txt_phone.Text.Trim() == "")
            {
                MessageBox.Show("Phone cant be null");
            }
            else if (txt_subject.Text.Trim() == "")
            {
                MessageBox.Show("Subject cant be null");
            }
            else if (txt_message.Text.Trim() == "")
            {
                MessageBox.Show("Subject cant be null");
            }
            else
            {
                using (edeaccountEntities content = new edeaccountEntities())
                {
                    string to, pass, messageBody;
                    MailMessage message = new MailMessage();
                    to = "yuk2269@gmail.com";
                    from = (txt_email.Text).ToString();
                    pass = "pkuwndeixqypshxw";
                    messageBody = (txt_message.Text).ToString();
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = (txt_subject.Text).ToString();
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    smtp.Send(message);
                    MessageBox.Show("Contact Email send successfully");
                    customer cs = content.customer.SingleOrDefault(i => i.email == txt_email.Text);
                    log logging = new log
                    {
                        accountID = cs.accountID,
                        times = DateTime.Now,
                        actionPerformed = txt_email.Text + " send a contact email to us " + "his phone number is " + txt_phone.Text,
                        ipAddress = CIP

                    };
                    content.log.Add(logging);
                    content.SaveChanges();
                    this.Hide();

                }
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            txt_name.MaxLength = 12;
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ContactEmailLWL_Load(object sender, EventArgs e)
        {
            getIP();
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            txt_phone.MaxLength = 11;
        }
    }
}
