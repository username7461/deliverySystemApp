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
    public partial class Register : Form
    {

        public static string CIP = "";
        private string randomCode;

        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txt_Fname.MaxLength = 50;
        }
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

        private void button1_Click(object sender, EventArgs e) //creat account
        {
            // Regex AccountIDvalid = new Regex("^(?=.*?[A-Za-z0-9]).{8,12}$");
            Regex emailvaild = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
               + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
               + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
            Regex passwordvalid = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,20}$");
            //Regex Creditcard = new Regex(@"^(?=.*?[0-9]).{12,12}$");
            Regex phonehk = new Regex(@"^(?=.*?[0-9]).{8,8}$");
            Regex phonejp = new Regex(@"^(?=.*?[0-9]).{10,10}$");
            Regex phoneau = new Regex(@"^(?=.*?[0-9]).{9,9}$");
            Regex phoneshanghai = new Regex(@"^(?=.*?[0-9]).{11,11}$");
            // bool AccountIDValid = AccountIDvalid.IsMatch(txt_accountID.Text.Trim());
            bool phonehkValid = phonehk.IsMatch(txt_phone.Text.Trim());
            bool phonejpValid = phonejp.IsMatch(txt_phone.Text.Trim());
            bool phoneauValid = phoneau.IsMatch(txt_phone.Text.Trim());
            bool phoneshanghaiValid = phoneshanghai.IsMatch(txt_phone.Text.Trim());
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
            else if (txt_Lname.Text.Trim() == "")
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
            //else if (txt_Card.Text.Trim() == "")
            //{
            //    MessageBox.Show("Please Provide Card Number");
            //}
            //else if (!CreditcardVaild)
            //{
            //     MessageBox.Show("Invalid Card Number");
            // }
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
                        Random rand = new Random();
                        randomCode = (rand.Next(999999999)).ToString();
                        customer s = new customer
                        {

                            accountID = "c" + randomCode,
                            firstName = txt_Fname.Text,
                            lastName = txt_Lname.Text,
                            email = txt_email.Text,
                            phoneNo = comboBox1.GetItemText(comboBox1.SelectedItem) + txt_phone.Text,
                            password = txt_password.Text,
                            status = 1,
                            credibility = 100,
                            creationDate = DateTime.Now

                        };
                        MessageBox.Show("create account successful!");
                        content.customer.Add(s);
                        content.SaveChanges();
                        log logging = new log
                        {
                            accountID = s.accountID,
                            times = DateTime.Now,
                            actionPerformed = s.accountID + " has been register to be a new user",
                            ipAddress = CIP

                        };
                        content.log.Add(logging);
                        content.SaveChanges();
                    }
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                }
            }

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.MaxLength = 150;
            string email = txt_email.Text;
            Regex regex = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
            bool isValid = regex.IsMatch(txt_email.Text.Trim());
            Match match = regex.Match(email);

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.MaxLength = 20;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinMaxChars = new Regex(@".{8,12}");
            var isValidated = hasNumber.IsMatch(txt_password.Text) && hasUpperChar.IsMatch(txt_password.Text) && hasMinMaxChars.IsMatch(txt_password.Text);
            Console.WriteLine(isValidated);
        }

        private void txt_Lname_TextChanged(object sender, EventArgs e)
        {
            txt_Lname.MaxLength = 50;
        }



        private void txt_Repassword_TextChanged(object sender, EventArgs e)
        {
            txt_Repassword.MaxLength = 20;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            getIP();
            comboBox1.Items.Add("852");
            comboBox1.Items.Add("61");
            comboBox1.Items.Add("81");
            comboBox1.Items.Add("86");
            txt_phone.Enabled = false;
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
            check_robot.Checked = false;
        }

        private void txt_accountID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Lname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Card_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
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

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                txt_phone.Enabled = false;
            }
            else if(comboBox1.SelectedIndex == 0)
            {
                txt_phone.Text = "";
                txt_phone.Enabled = true;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                txt_phone.Text = "";
                txt_phone.Enabled = true;
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                txt_phone.Text = "";
                txt_phone.Enabled = true;
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                txt_phone.Text = "";
                txt_phone.Enabled = true;
            }
        }
    }
}

