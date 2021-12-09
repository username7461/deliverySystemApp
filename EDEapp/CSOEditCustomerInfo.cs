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
using System.Data.Entity;
using System.Net;

namespace EDEapp
{
    public partial class CSOEditCustomerInfo : Form
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
        public CSOEditCustomerInfo()
        {
            InitializeComponent();
            txt_accountID.Text = CSOViewCustomerInfo.log_user;
            txt_email.Text = CSOViewCustomerInfo.useremail;
            using (edeaccountEntities content = new edeaccountEntities())
            {
                customer cs = content.customer.SingleOrDefault(i => i.accountID == CSOViewCustomerInfo.log_user);
                if (cs != null)
                {
                    txt_Fname.Text = cs.firstName;
                    txt_Lname.Text = cs.lastName;
                    txt_phone.Text = cs.phoneNo;
                    txt_credibility.Text = Convert.ToString(cs.credibility);
                }
            }
        }

        private void CSOEditCustomerInfo_Load(object sender, EventArgs e)
        {
            getIP();
            using (edeaccountEntities content = new edeaccountEntities())
            {
                customer cs = content.customer.SingleOrDefault(i => i.accountID == CSOViewCustomerInfo.log_user);
                if(cs.status == 0)
                {
                    lab_accountStatus.Text = "Freeze";
                }
                else 
                {
                    lab_accountStatus.Text = "";
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Regex emailvaild = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
              + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
              + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
            Regex namevalid = new Regex("^[A-Z][a-zA-Z]*$");
            bool FnameValid = namevalid.IsMatch(txt_Fname.Text.Trim());
            bool LnameValid = namevalid.IsMatch(txt_Lname.Text.Trim());
            bool emailisValid = emailvaild.IsMatch(txt_email.Text.Trim());
            bool checkemailexist = false;
            if (txt_Fname.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide The First Name");
                txt_Fname.Focus();
            }
            else if (!FnameValid)
            {
                MessageBox.Show("First name is InValid");
                txt_Fname.Focus();
            }
            else if (txt_Lname.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide The Last Name");
            }
            else if (!LnameValid)
            {
                MessageBox.Show("Last name is InValid");
            }

            else if (txt_email.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide Email");
            }
            else if (!emailisValid)
            {
                MessageBox.Show("Invalid Email.");
            }
            else if (txt_phone.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide The Phone number");
            }
            else if (txt_credibility.Text.Trim() == "")
            {
                MessageBox.Show("Credibility cant be blank");
            }
            else if (Convert.ToInt32(txt_credibility.Text.Trim())>100)
            {
                MessageBox.Show("Credibility highest is 100!");
            }
            else
            {
                using (var customercheck = new edeaccountEntities())
                {
                    var customer = (from list in customercheck.customer
                                    where list.email != CSOViewCustomerInfo.useremail
                                    select list);

                    foreach (var customer2 in customer.ToList())
                    {
                        if (customer2.email == txt_email.Text)
                        {
                            checkemailexist = true;
                            break;
                        }
                    }
                    var staffemailcheck = (from list in customercheck.staff
                                           where list.email != CSOViewCustomerInfo.useremail
                                           select list);
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
                else { 
                using (edeaccountEntities content = new edeaccountEntities())
                {
                    customer cs = content.customer.SingleOrDefault(i => i.accountID == CSOViewCustomerInfo.log_user);
                        if (cs != null)
                        {
                            if (MessageBox.Show("Are you sure that to edit this account information?", "Edit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                cs.firstName = txt_Fname.Text;
                                cs.lastName = txt_Lname.Text;
                                cs.email = txt_email.Text;
                                cs.phoneNo = txt_phone.Text;
                                cs.credibility = Convert.ToInt32(txt_credibility.Text);
                                content.SaveChanges();
                                MessageBox.Show("Information has been edit!");
                                CSOViewCustomerInfo csovcinfo = new CSOViewCustomerInfo();
                                this.Hide();
                                csovcinfo.Show();
                                log logging = new log
                                {
                                    accountID = Login.log_ad_user,
                                    times = DateTime.Now,
                                    actionPerformed = "Edit customer account (" + txt_accountID.Text + ") information",
                                    ipAddress = CIP

                                };
                                content.log.Add(logging);
                                content.SaveChanges();
                            }
                        }
                    }
                }
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            CSOViewCustomerInfo csovc = new CSOViewCustomerInfo();
            csovc.Show();
            this.Hide();
        }

        private void btn_freezeaccount_Click(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                customer cs = content.customer.SingleOrDefault(i => i.accountID == CSOViewCustomerInfo.log_user);
                if (cs != null)
                {
                    if (MessageBox.Show("Are you sure that to freeze this account information?", "Freeze This Account?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cs.status = 0;
                        content.SaveChanges();
                        MessageBox.Show("This account has been freeze!");
                        log logging = new log
                        {
                            accountID = Login.log_ad_user,
                            times = DateTime.Now,
                            actionPerformed = "Freeze customer account (" + txt_accountID.Text + ") information",
                            ipAddress = CIP

                        };
                        content.log.Add(logging);
                        content.SaveChanges();
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure to Delete this Record? ", "Delete Account?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (edeaccountEntities content = new edeaccountEntities())
                {
                    customer cs = content.customer.SingleOrDefault(i => i.accountID == CSOViewCustomerInfo.log_user);
                    var entry = content.Entry(cs);
                    if (entry.State == EntityState.Detached)
                        content.customer.Attach(cs);
                    content.customer.Remove(cs);
                    content.SaveChanges();
                    MessageBox.Show("Account delete");
                    log logging = new log
                    {
                        accountID = Login.log_ad_user,
                        times = DateTime.Now,
                        actionPerformed = "Delete customer account (" + txt_accountID.Text + ") information",
                        ipAddress = CIP

                    };
                    content.log.Add(logging);
                    content.SaveChanges();
                    CSOViewCustomerInfo csovcinfo = new CSOViewCustomerInfo();
                    this.Hide();
                    csovcinfo.Show();

                }
        }

        private void txt_credibility_TextChanged(object sender, EventArgs e)
        {
            txt_credibility.MaxLength = 3;
        }

        private void txt_credibility_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
