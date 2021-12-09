using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;

namespace EDEapp
{
    public partial class ReSetPassWord : Form
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
        public ReSetPassWord()
        {
            InitializeComponent();
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Regex passwordvalid = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,12}$");
            bool passwordValid = passwordvalid.IsMatch(txt_password.Text.Trim());
            bool RepasswordValid = passwordvalid.IsMatch(txt_confirmpassword.Text.Trim());
            if (txt_password.Text.Trim() == "")
            {
                MessageBox.Show("Please provide the Password");
            }
            else if (!passwordValid)
            {
                MessageBox.Show("Invalid password.");
            }
            else if (txt_confirmpassword.Text.Trim() == "")
            {
                MessageBox.Show("Please provide the confirm password");
            }
            else if (!RepasswordValid)
            {
                MessageBox.Show("Invalid confirm password");
            }
            else if (txt_password.Text != txt_confirmpassword.Text)
            {
                MessageBox.Show("Password not match");
            }
            else
            {
                using (edeaccountEntities content = new edeaccountEntities())
                {
                    customer cs2 = content.customer.SingleOrDefault(i => i.accountID == Login.log_user && i.password == txt_oldpassword.Text);
                    customer cs = content.customer.SingleOrDefault(i => i.email == CodeConfirm.to);
                    if (cs != null & txt_password.Text == txt_confirmpassword.Text)
                    {
                        cs.password = txt_password.Text;
                        content.SaveChanges();
                        MessageBox.Show("Password has been change!");
                        log logging = new log
                        {
                            accountID = cs.accountID,
                            times = DateTime.Now,
                            actionPerformed = cs.accountID + " reset the password ",
                            ipAddress = CIP
                            
                        };
                        content.log.Add(logging);
                        content.SaveChanges();
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                    else if (cs2 != null & txt_password.Text == txt_confirmpassword.Text)
                    {
                        cs2.password = txt_password.Text;
                        content.SaveChanges();
                        MessageBox.Show("Password has been change!");
                        log logging = new log
                        {
                            accountID = cs2.accountID,
                            times = DateTime.Now,
                            actionPerformed = cs2.accountID + " reset the password ",
                            ipAddress = CIP

                        };
                        content.log.Add(logging);
                        content.SaveChanges();
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                        Login.log_user = "";
                        Login.log_email = "";
                    }
                    else
                    {
                        MessageBox.Show("Old Password is wrong.");
                    }
                }
            }
        }

        private void ReSetPassWord_Load(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user);

                if (cs != null)
                {
                    txt_oldpassword.Visible = true;
                    lab_oldpassword.Visible = true;
                    btn_return.Visible = true;
                }
                else
                {
                    txt_oldpassword.Visible = false;
                    lab_oldpassword.Visible = false;
                    btn_return.Visible = false;
                }
            }
            getIP();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu main = new EDEapp_MainMenu();
            main.Show();
            this.Hide();
        }
    }
}
