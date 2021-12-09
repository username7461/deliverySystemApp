using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDEapp
{
    public partial class EditStaffAccount : Form
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
        public EditStaffAccount()
        {
            InitializeComponent();

            txt_accountID.Text = ViewStaffAccount.log_user;
            txt_jobname.Text = ViewStaffAccount.jobID;
            txt_centreName.Text = ViewStaffAccount.centreID;
            txt_email.Text = ViewStaffAccount.staffemailexist;


            using (edeaccountEntities content = new edeaccountEntities())
            {
                staff sf = content.staff.SingleOrDefault(i => i.accountID == ViewStaffAccount.log_user);

                var Index = combo_jobID.Items.IndexOf(sf.jobID);
                var Indexofcentre = combo_centreID.Items.IndexOf(sf.centreID);
                var Indexofstatus = combo_status.Items.IndexOf(sf.status);
                if (sf != null)
                {
                    txt_FName.Text = sf.firstName;
                    txt_LastName.Text = sf.lastName;
                }
            }
        }

        private void EditStaffAccount_Load(object sender, EventArgs e)
        {
            combo_jobID.Items.Add(0);
            combo_jobID.Items.Add(1);
            combo_jobID.Items.Add(2);
            combo_jobID.Items.Add(3);
            combo_jobID.Items.Add(4);
            combo_jobID.Items.Add(5);
            combo_centreID.Items.Add("001");
            combo_centreID.Items.Add("002");
            combo_centreID.Items.Add("003");
            combo_centreID.Items.Add("004");
            combo_centreID.Items.Add("005");
            combo_status.Items.Add(0);
            combo_status.Items.Add(1);
            getIP();
            if (txt_jobname.Text == "BookingClerk")
            {
                combo_jobID.SelectedIndex = 0;
            }
            if (txt_jobname.Text == "ShippingClerk")
            {
                combo_jobID.SelectedIndex = 1;
            }
            if (txt_jobname.Text == "AccountingClerk")
            {
                combo_jobID.SelectedIndex = 2;
            }
            if (txt_jobname.Text == "ManagingDirector")
            {
                combo_jobID.SelectedIndex = 3;
            }
            if (txt_jobname.Text == "CustomerServiceOfficer")
            {
                combo_jobID.SelectedIndex = 4;
            }
            if (txt_jobname.Text == "SystemAdministrator")
            {
                combo_jobID.SelectedIndex = 5;
            }
            if (txt_centreName.Text == "EDE company(Sha Tin)")
            {
                combo_centreID.SelectedIndex = 0;
            }
            if (txt_centreName.Text == "EDE company(Tseung Kwan O)")
            {
                combo_centreID.SelectedIndex = 1;
            }
            if (txt_centreName.Text == "EDE company(Japan)")
            {
                combo_centreID.SelectedIndex = 2;
            }
            if (txt_centreName.Text == "EDE company(Australia)")
            {
                combo_centreID.SelectedIndex = 3;
            }
            if (txt_centreName.Text == "EDE company(China ShangHai)")
            {
                combo_centreID.SelectedIndex = 4;
            }
            if (ViewStaffAccount.statuscheck)
            {
                combo_status.SelectedIndex = 0;
            }
            if (!ViewStaffAccount.statuscheck)
            {
                combo_status.SelectedIndex = 1;
            }
        }

        private void combo_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_FName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ViewStaffAccount viewStaff = new ViewStaffAccount();
            viewStaff.Show();
            this.Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Regex emailvaild = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
               + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
               + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
            Regex passwordvalid = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,20}$");
            Regex phonehk = new Regex(@"^(?=.*?[0-9]).{8,8}$");
            Regex phonejp = new Regex(@"^(?=.*?[0-9]).{10,10}$");
            Regex phoneau = new Regex(@"^(?=.*?[0-9]).{9,9}$");
            Regex phoneshanghai = new Regex(@"^(?=.*?[0-9]).{11,11}$");
            bool emailisValid = emailvaild.IsMatch(txt_email.Text.Trim());
            bool checkaccountexist = false;
            bool checkemailexist = false;

            if (txt_FName.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide The First Name");
                txt_FName.Focus();
            }
            else if (txt_LastName.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide The Last Name");
            }
            else if (txt_email.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide Email");
            }
            else if (!emailisValid)
            {
                MessageBox.Show("Invalid Email.");
            }
            else if (combo_jobID.SelectedIndex == -1)
            {
                MessageBox.Show("You sholud choose the JobID");
            }
            else if (combo_centreID.SelectedIndex == -1)
            {
                MessageBox.Show("You sholud choose the centreID");
            }
            else
            {


                using (var customercheck = new edeaccountEntities())
                {
                    var customer = (from list in customercheck.customer
                                    where list.email != ViewStaffAccount.staffemailexist
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
                                           where list.email != ViewStaffAccount.staffemailexist
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
                else
                {
                    using (edeaccountEntities content = new edeaccountEntities())
                    {
                        staff sf = content.staff.SingleOrDefault(i => i.accountID == ViewStaffAccount.log_user);
                        if (sf != null)
                        {
                            if (MessageBox.Show("Are you sure that to edit this account information?", "Edit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                sf.firstName = txt_FName.Text;
                                sf.lastName = txt_LastName.Text;
                                sf.email = txt_email.Text;
                                sf.jobID = Convert.ToInt32(combo_jobID.GetItemText(combo_jobID.SelectedItem));
                                sf.centreID = combo_centreID.GetItemText(combo_centreID.SelectedItem);
                                sf.status = Convert.ToInt32(combo_status.GetItemText(combo_status.SelectedItem));
                                content.SaveChanges();
                                MessageBox.Show("Edit successful!");
                                ViewStaffAccount viewStaff = new ViewStaffAccount();
                                viewStaff.Show();
                                this.Hide();
                            }
                        };
                        log logging = new log
                        {
                            accountID = Login.log_ad_user,
                            times = DateTime.Now,
                            actionPerformed = "Edit staff account (" + txt_accountID.Text + ") information",
                            ipAddress = CIP
                        };
                        content.log.Add(logging);
                        content.SaveChanges();
                    }
                }
            }
        }

        private void combo_jobID_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = true;
            }
        }

        private void combo_centreID_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = true;
            }
        }
    }
}
