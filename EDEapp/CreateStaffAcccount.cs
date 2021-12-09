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
    public partial class CreateStaffAcccount : Form
    {
        public static string CIP = "";
        private string randomCode;

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
        public CreateStaffAcccount()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Regex AccountIDvalid = new Regex("^(?=.*?[A-Za-z0-9]).{8,12}$");
            Regex emailvaild = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
               + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
               + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
            Regex namevalid = new Regex("^[A-Z][a-zA-Z]*$");
            Regex passwordvalid = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,20}$");
            //Regex Creditcard = new Regex(@"^(?=.*?[0-9]).{12,12}$");
            Regex phonehk = new Regex(@"^(?=.*?[0-9]).{8,8}$");
            Regex phonejp = new Regex(@"^(?=.*?[0-9]).{10,10}$");
            Regex phoneau = new Regex(@"^(?=.*?[0-9]).{9,9}$");
            Regex phoneshanghai = new Regex(@"^(?=.*?[0-9]).{11,11}$");
            // bool AccountIDValid = AccountIDvalid.IsMatch(txt_accountID.Text.Trim());
            bool FnameValid = namevalid.IsMatch(txt_Fname.Text.Trim());
            bool LnameValid = namevalid.IsMatch(txt_Lname.Text.Trim());
            bool phonehkValid = phonehk.IsMatch(txt_phone.Text.Trim());
            bool phonejpValid = phonehk.IsMatch(txt_phone.Text.Trim());
            bool phoneauValid = phonehk.IsMatch(txt_phone.Text.Trim());
            bool phoneshanghaiValid = phonehk.IsMatch(txt_phone.Text.Trim());
            bool emailisValid = emailvaild.IsMatch(txt_email.Text.Trim());
            bool passwordValid = passwordvalid.IsMatch(txt_password.Text.Trim());
            bool RepasswordValid = passwordvalid.IsMatch(txt_Repassword.Text.Trim());
            //bool CreditcardVaild = Creditcard.IsMatch(txt_Card.Text.Trim());
            bool checkaccountexist = false;
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
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You sholud choose the Country Calling Codes");
            }
            else if (comboBox1.SelectedIndex == 0 && !phonehkValid)
            {
                MessageBox.Show("Hong Kong Number Should be 8 character");
            }
            else if (comboBox1.SelectedIndex == 1 && !phoneauValid)
            {
                MessageBox.Show("Australia Number Should be 9 character");
            }
            else if (comboBox1.SelectedIndex == 2 && !phonejpValid)
            {
                MessageBox.Show("Japan Number Should be 10 character");
            }
            else if (comboBox1.SelectedIndex == 3 && !phoneshanghaiValid)
            {
                MessageBox.Show("China Number Should be 11 character");
            }
            else if (combo_centre.SelectedIndex ==-1)
            {
                MessageBox.Show("You sholud choose the centreID");
            }
            else if (combo_job.SelectedIndex == -1)
            {
                MessageBox.Show("You sholud choose the jobID");
            }
            else if (txt_password.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide The Password");
            }
            else if (!passwordValid)
            {
                MessageBox.Show("Invalid Password.");
            }
            else if (txt_Repassword.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide The Confirm Password");
            }
            else if (!RepasswordValid)
            {
                MessageBox.Show("Invalid Confirm Password");
            }
            else if (txt_password.Text != txt_Repassword.Text)
            {
                MessageBox.Show("Password not match");
            }
            else if (!check_robot.Checked)
            {
                MessageBox.Show("You sholud tick the checkbox");
            }
            else
            {
                using (var customercheck = new edeaccountEntities())
                {
                    var customer = (from list in customercheck.customer

                                    select list);
                    var staffemailcheck = (from list in customercheck.staff
                                           select list);
                    foreach (var staffemailcheck2 in staffemailcheck.ToList())
                    {
                        if (staffemailcheck2.email == txt_email.Text)
                        {
                            checkemailexist = true;
                            break;
                        }
                    }


                    foreach (var customer2 in customer.ToList())
                    {
                        if (customer2.email == txt_email.Text)
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
                        Random rand = new Random();
                        randomCode = (rand.Next(999999999)).ToString();
                        staff s = new staff
                        {

                            accountID = "s" + randomCode,
                            firstName = txt_Fname.Text,
                            lastName = txt_Lname.Text,
                            email = txt_email.Text,
                            phoneNo = txt_phone.Text,
                            password = txt_password.Text,
                            jobID = Convert.ToInt32(combo_job.GetItemText(combo_job.SelectedItem)),
                            centreID = combo_centre.GetItemText(combo_centre.SelectedItem),
                            status = 1,
                            


                        };
                        MessageBox.Show("create account successful!");
                        content.staff.Add(s);
                        content.SaveChanges();
                        log logging = new log
                        {
                            accountID = Login.log_ad_user,
                            times = DateTime.Now,
                            actionPerformed =  "create a new staff account",
                            ipAddress = CIP

                        };
                        content.log.Add(logging);
                        content.SaveChanges();
                    }
                    EDEapp_MainMenu main = new EDEapp_MainMenu();
                    main.Show();
                    this.Hide();
                }
            }

        }

        private void combo_job_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_centre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CreateStaffAcccount_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("852");
            comboBox1.Items.Add("61");
            comboBox1.Items.Add("81");
            comboBox1.Items.Add("86");
            combo_job.Items.Add(0);
            combo_job.Items.Add(1);
            combo_job.Items.Add(2);
            combo_job.Items.Add(3);
            combo_job.Items.Add(4);
            combo_job.Items.Add(5);
            combo_centre.Items.Add("001");
            combo_centre.Items.Add("002");
            combo_centre.Items.Add("003");
            combo_centre.Items.Add("004");
            combo_centre.Items.Add("005");
            getIP();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu main = new EDEapp_MainMenu();
            main.Show();
            this.Hide();
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

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Fname.Text = "";
            txt_Lname.Text = "";
            txt_email.Text = "";
            comboBox1.SelectedIndex = -1;
            txt_phone.Text = "";
            txt_password.Text = "";
            txt_Repassword.Text = "";
            combo_centre.SelectedIndex = -1;
            combo_job.SelectedIndex = -1;
            check_robot.Checked = false;
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                txt_phone.MaxLength = 8;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                txt_phone.MaxLength = 9;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                txt_phone.MaxLength = 10;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                txt_phone.MaxLength = 11;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.MaxLength = 20;
        }

        private void txt_Repassword_TextChanged(object sender, EventArgs e)
        {
            txt_Repassword.MaxLength = 20;
        }
    }
}
