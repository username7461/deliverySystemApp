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
    public partial class EditAccount : Form
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
        public EditAccount()
        {
            InitializeComponent();
            txt_accountID.Text = Login.log_user;
            using (edeaccountEntities content = new edeaccountEntities())
            {
                customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user);
                if (cs != null)
                {
                    txt_phone.Text = cs.phoneNo;
                    txt_email.Text = cs.email;
                }
            }
        }


        private void Btn_edit_Click(object sender, EventArgs e)
        {
            Regex emailvaild = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
               + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
               + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
            bool emailisValid = emailvaild.IsMatch(txt_email.Text.Trim());
            bool checkemailexist = false;


            if (txt_email.Text.Trim()== "")
            {
                MessageBox.Show("Please Provide Email");
            }
            else if (!emailisValid)
            {
                MessageBox.Show("Invalid Email");
            }
            else if (txt_phone.Text.Trim()=="")
            {
                MessageBox.Show("Please Provide PhoneNo");
            }

            else if (!check_confirm.Checked)
            {
                MessageBox.Show("You sholud tick the checkbox");
            }
            else {

                using (var customercheck = new edeaccountEntities())

                {

                    var customer = (from list in customercheck.customer
                                    join c in customercheck.staff on list.email equals c.email
                                    where list.email !=Login.log_email
                                    select list                                                      
                                    );
                    var staffemailcheck = (from list in customercheck.staff
                                    where list.email != Login.log_email
                                    select list
                                    );

                    foreach (var customer2 in customer.ToList())
                    {
                        if (customer2.email == txt_email.Text)
                        {
                            checkemailexist = true;
                            break;
                        }
                    }
                    foreach (var staffemailcheck2 in staffemailcheck.ToList())
                    {
                        if (staffemailcheck2.email == txt_email.Text)
                        {
                            checkemailexist = true;
                            break;
                        }
                    }
                }
                if (checkemailexist)
                {
                    MessageBox.Show("Email has been used"); 
                }
                else
                { 
                    using (edeaccountEntities content = new edeaccountEntities())
                    {
                        customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user && i.email == Login.log_email);
                        if (cs != null)
                        {
                            cs.phoneNo = txt_phone.Text;
                            cs.email = txt_email.Text;
                            content.SaveChanges();
                            MessageBox.Show("Information has been edit!");

                            log logging = new log
                            {
                                accountID = Login.log_user,
                                times = DateTime.Now,
                                actionPerformed = "Edit Account Information",
                                ipAddress = CIP

                            };
                            content.log.Add(logging);
                            content.SaveChanges();
                        }
                    }
                    
                }

            }
            

        }

        private void txt_accountID_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            getIP();
            
        }

        private void btn_backtoview_Click(object sender, EventArgs e)
        {
            ViewAccountInformation view = new ViewAccountInformation();
            view.Show();
            this.Hide();
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            txt_phone.MaxLength = 12;
        }
    }
}
