using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace EDEapp
{

    public partial class Login : Form
    {
        public static Form editAirwayBillStaff = new EditAirwayBillStaff();
        public static string log_user;
        public static string log_email;
        public static string log_ad_user;
        public static string CIP = "";
        private static string randomCode;

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
        public Login()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lab_times.Text = DateTime.Now.ToString("HH:mm:ss yyyy-MM-dd");
            getIP();
            btn_hide.Visible = false;
            txt_password.PasswordChar = '*';
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            if (txt_accountID.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide accountID");
            }
            else if (txt_password.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide The Password");
            }
            else if (!check_robot.Checked)
            {
                MessageBox.Show("You sholud tick the checkbox");
            }
            else
            {

                using (edeaccountEntities content = new edeaccountEntities())
                {
                    string Login = "login";
                    string StaffLogin = "login(Staff)";
                    customer csaccess = content.customer.SingleOrDefault(i => i.email == txt_accountID.Text && i.password == txt_password.Text && i.status == 0);
                    customer cs = content.customer.SingleOrDefault(i => i.email == txt_accountID.Text && i.password == txt_password.Text);
                    staff sf = content.staff.SingleOrDefault(i => i.email == txt_accountID.Text && i.password == txt_password.Text);
                    if (cs != null && cs.status == 1)
                    {
                        log_user = cs.accountID;
                        log_email = cs.email;
                        EditAccount ed = new EditAccount();
                        CustomerAddressBook cab = new CustomerAddressBook();
                        EDEapp_MainMenu main = new EDEapp_MainMenu();
                        main.Show();
                        //adb.Show();
                        //ed.Show();
                        this.Hide();

                        log logging = new log
                        {
                            accountID = cs.accountID,
                            times = DateTime.Now,
                            actionPerformed = Login,
                            ipAddress = CIP

                        };
                        content.log.Add(logging);
                        content.SaveChanges();

                        // Create Monthly Invoice //
                        DateTime creationDate = cs.creationDate;
                        var firstDayOfMonth = new DateTime(creationDate.Year, creationDate.Month, 1);
                        var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                        // commercialinvoice comInv;
                        commercialinvoice comInvCheck;
                        consolidatemonthlyinvoice monInv;
                        package pkg;
                        Random rand = new Random();
                        Boolean isCreateInvoice = false;

                        while (firstDayOfMonth.Month != DateTime.Now.Month)
                        {
                            monInv = content.consolidatemonthlyinvoice.SingleOrDefault(i => i.accountID == cs.accountID && i.startDate == firstDayOfMonth);
                            if (monInv == null)
                            {
                                randomCode = (rand.Next(999999999)).ToString();

                                using (var comInv = new edeaccountEntities())
                                {
                                    var comInv1 = (from list in comInv.commercialinvoices
                                                   where list.accountID == cs.accountID
                                                   where list.creationDate >= firstDayOfMonth && list.creationDate <= lastDayOfMonth
                                                   select list);

                                    bool hasComInv = false;
                                    foreach (var comInv2 in comInv1.ToList())
                                    {
                                        if (comInv2 != null)
                                        {
                                            hasComInv = true;
                                            break;
                                        }
                                    }

                                    if (hasComInv)
                                    {
                                        double totalValue = 0.0;
                                        foreach (var comInv2 in comInv1.ToList())
                                        {
                                            totalValue += comInv2.totalValue;
                                        }

                                        consolidatemonthlyinvoice cMonInv = new consolidatemonthlyinvoice
                                        {
                                            invoiceID = "M" + randomCode,
                                            accountID = cs.accountID,
                                            value = totalValue,
                                            startDate = firstDayOfMonth,
                                            endDate = lastDayOfMonth,
                                            isPay = 0
                                        };
                                        content.consolidatemonthlyinvoice.Add(cMonInv);
                                        content.SaveChanges();
                                        isCreateInvoice = true;
                                    }
                                }
                            }
                            firstDayOfMonth = firstDayOfMonth.AddMonths(1);
                            lastDayOfMonth = lastDayOfMonth.AddMonths(1).AddDays(-1);
                        }
                        if (isCreateInvoice)
                            MessageBox.Show("You have a new monthly Invoice. Please check it in \"Check Invoice\".");
                        // Create Monthly Invoice //

                    }
                    else if (sf != null && sf.jobID == 0) // 0 BookingClerk
                    {
                        log_ad_user = sf.accountID;
                        log_email = sf.email;
                        EDEapp_MainMenu eDEapp_Main = new EDEapp_MainMenu();
                        eDEapp_Main.Show();
                        this.Hide();
                        log logging = new log
                        {
                            accountID = sf.accountID,
                            times = DateTime.Now,
                            actionPerformed = StaffLogin,
                            ipAddress = CIP

                        };
                        content.log.Add(logging);
                        content.SaveChanges();

                    }
                    else if (sf != null && sf.jobID == 1) //1 ShippingClerk
                    {
                        log_ad_user = sf.accountID;
                        log_email = sf.email;
                        EDEapp_MainMenu eDEapp_Main = new EDEapp_MainMenu();
                        eDEapp_Main.Show();
                        this.Hide();
                        log logging = new log
                        {
                            accountID = sf.accountID,
                            times = DateTime.Now,
                            actionPerformed = StaffLogin,
                            ipAddress = CIP

                        };
                        content.log.Add(logging);
                        content.SaveChanges();

                    }
                    else if (sf != null && sf.jobID == 2) //2 AccountingClerk
                    {
                        log_ad_user = sf.accountID;
                        log_email = sf.email;
                        EDEapp_MainMenu eDEapp_Main = new EDEapp_MainMenu();
                        eDEapp_Main.Show();
                        this.Hide();
                        log logging = new log
                        {
                            accountID = sf.accountID,
                            times = DateTime.Now,
                            actionPerformed = StaffLogin,
                            ipAddress = CIP

                        };
                        content.log.Add(logging);
                        content.SaveChanges();
                    }
                    else if (sf != null && sf.jobID == 3) //3 ManagingDirector
                    {
                        log_ad_user = sf.accountID; ;
                        log_email = sf.email;
                        EDEapp_MainMenu eDEapp_Main = new EDEapp_MainMenu();
                        eDEapp_Main.Show();
                        this.Hide();
                        log logging = new log
                        {
                            accountID = sf.accountID,
                            times = DateTime.Now,
                            actionPerformed = StaffLogin,
                            ipAddress = CIP

                        };
                        content.log.Add(logging);
                        content.SaveChanges();
                    }
                    else if (sf != null && sf.jobID == 4) //4 CustomerServiceOfficer
                    {
                        log_ad_user = sf.accountID;
                        log_email = sf.email;
                        EDEapp_MainMenu eDEapp_Main = new EDEapp_MainMenu();
                        eDEapp_Main.Show();
                        this.Hide();
                        log logging = new log
                        {
                            accountID = sf.accountID,
                            times = DateTime.Now,
                            actionPerformed = StaffLogin,
                            ipAddress = CIP

                        };
                        content.log.Add(logging);
                        content.SaveChanges();

                    }
                    else if (sf != null && sf.jobID == 5) //5 SystemAdministrator
                    {
                        log_ad_user = sf.accountID;
                        EDEapp_MainMenu eDEapp_Main = new EDEapp_MainMenu();
                        eDEapp_Main.Show();
                        this.Hide();
                        log logging = new log
                        {
                            accountID = sf.accountID,
                            times = DateTime.Now,
                            actionPerformed = StaffLogin,
                            ipAddress = CIP

                        };
                        content.log.Add(logging);
                        content.SaveChanges();
                    }
                    else if (cs != null && cs.status == 0)
                    {
                        MessageBox.Show("You account has been freeze,Please contact out customerServices ");
                    }
                    else
                    {
                        MessageBox.Show("AccountId or password not valid.");
                    }

                }
            }
        }

        private void txt_accountID_TextChanged(object sender, EventArgs e)
        {

        }

        private void creat_account(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }
        private void lab_forgotpassword_Click(object sender, EventArgs e)
        {
            CodeConfirm cc = new CodeConfirm();
            this.Hide();
            cc.Show();
        }

        private void btn_ShippingExpensesCalculator_Click(object sender, EventArgs e)
        {
            ShippingExpenseCalculator sec = new ShippingExpenseCalculator();
            this.Hide();
            sec.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lab_times.Text = DateTime.Now.ToString("HH:mm:ss yyyy-MM-dd ");
            timer1.Start();
        }

        private void btn_contactus_Click(object sender, EventArgs e)
        {
            ContactUs contactUs = new ContactUs();
            contactUs.Show();
            this.Hide();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar =='*')
            {
                btn_show.BringToFront();
                txt_password.PasswordChar = '\0';
                btn_show.Visible = false; ;
                btn_hide.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '\0')
            {
                btn_hide.BringToFront();
                txt_password.PasswordChar = '*';
                btn_show.Visible = true;
                btn_hide.Visible = false;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
