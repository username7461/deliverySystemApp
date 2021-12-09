using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDEapp
{
    public partial class EDEapp_MainMenu : Form
    {
        staff sf;
        customer cs;

        public EDEapp_MainMenu()
        {
            InitializeComponent();

            using(edeaccountEntities db = new edeaccountEntities())
            {
                sf = db.staff.SingleOrDefault(i => i.accountID == Login.log_ad_user);
                cs = db.customer.SingleOrDefault(i => i.accountID == Login.log_user);
            }
        }

        private void EDEapp_MainMenu_Load(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                if (cs != null)
                {
                    // Customer Login
                    lab_welcome.Text = "Welcome! Mr. " + cs.firstName;
                    btn_btn1.Text = "Create Delivery Order";
                    btn_btn2.Text = "Check Invoice";
                    btn_btn3.Text = "Track Shipment";
                    btn_btn4.Text = "Payment";
                    btn_btn5.Text = "Shipping Expenses Calculator";
                    btn_btn6.Text = "Contact Us";
                    btn_btn7.Text = "View Booking Order History";
                    btn_btn8.Text = "Payment Record";
                    var data = (from i in content.prealertrecord
                                where i.accID == Login.log_user
                                where i.isRead == 0
                                select i).Count();

                    lbl_alertMessage.Text = "You have " + data + " unread notifications!";
                }
                else if (sf != null && sf.jobID == 0)
                {
                    // Booking Clerk Login
                    lab_welcome.Text = "Welcome! Mr. " + sf.firstName;
                    btn_btn1.Text = "Edit Booking";
                    btn_btn2.Text = "Edit Package";
                    btn_btn3.Text = "Edit Package Destination";
                    btn_btn4.Hide();
                    btn_btn5.Text = "View Booking History";
                    btn_btn6.Text = "View Package History";
                    btn_btn7.Hide();
                    btn_btn8.Hide();
                    lbl_alertMessage.Hide();
                }
                else if (sf != null && sf.jobID == 1)
                {
                    // Shipping Clerk Login
                    lab_welcome.Text = "Welcome! Mr. " + sf.firstName;
                    btn_btn1.Hide();
                    btn_btn2.Text = "Edit Package Status";
                    btn_btn3.Text = "AirwayBill Management";
                    btn_btn4.Hide();
                    btn_btn5.Hide();
                    btn_btn6.Hide();
                    btn_btn7.Hide();
                    btn_btn8.Hide();
                    lbl_alertMessage.Hide();
                }
                else if (sf != null && sf.jobID == 2)
                {
                    //  Accounting Clerk Login
                    lab_welcome.Text = "Welcome! Mr. " + sf.firstName;
                    btn_btn1.Hide();
                    btn_btn2.Text = "Export Monthly Report";
                    btn_btn3.Hide();
                    btn_btn4.Hide();
                    btn_btn5.Hide();
                    btn_btn6.Hide();
                    btn_btn7.Hide();
                    btn_btn8.Hide();
                    lbl_alertMessage.Hide();
                }
                else if (sf != null && sf.jobID == 3)
                {
                    // Managing Director Login
                    lab_welcome.Text = "Welcome! Mr. " + sf.firstName;
                    btn_btn1.Hide();
                    btn_btn2.Text = "Export Monthly Report";
                    btn_btn3.Hide();
                    btn_btn4.Hide();
                    btn_btn5.Hide();
                    btn_btn6.Hide();
                    btn_btn7.Hide();
                    btn_btn8.Hide();
                    lbl_alertMessage.Hide();
                }
                else if (sf != null && sf.jobID == 4)
                {
                    // Customer Service Officer Login
                    lab_welcome.Text = "Welcome! Mr. " + sf.firstName;
                    btn_btn1.Text = "View Customer Account Information";
                    btn_btn2.Text = "Monthly Invoice Cash Payment";
                    btn_btn3.Hide();
                    btn_btn4.Hide();
                    btn_btn5.Hide();
                    btn_btn6.Hide();
                    btn_btn7.Hide();
                    btn_btn8.Hide();
                    lbl_alertMessage.Hide();
                }
                else if (sf != null && sf.jobID == 5)
                {
                    // System Administrator Login
                    lab_welcome.Text = "Welcome! Mr. " + sf.firstName;
                    btn_btn1.Text = "Logging";
                    btn_btn2.Text = "Manage Staff Account";
                    btn_btn3.Text = "Create Staff Account";
                    btn_btn4.Text = "Manage Centre Information";
                    btn_btn5.Hide();
                    btn_btn6.Hide();
                    btn_btn7.Hide();
                    btn_btn8.Hide();
                    lbl_alertMessage.Hide();
                }
            }

            using (edeaccountEntities content = new edeaccountEntities())
            {
                var data = (from i in content.prealertrecord
                            where i.accID == Login.log_user
                            where i.isRead == 0
                            select i).Count();

                if (data == 0)
                {
                    lbl_alertMessage.Text = "You have no unread notifications.";
                    lbl_alertMessage.LinkColor = System.Drawing.Color.Gray;
                    lbl_alertMessage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
                }
                else
                {
                    lbl_alertMessage.Text = "You have " + data + " unread notifications!";
                    lbl_alertMessage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
                }
            }
        }

        private void lbl_alertMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckNotifications CheckNotificationsForm = new CheckNotifications();
            CheckNotificationsForm.Show();
            this.Hide();
        }

        private void btn_viewAccount_Click(object sender, EventArgs e)
        {
            if (Login.log_user != null)
            {
                ViewAccountInformation viewAccount = new ViewAccountInformation();
                viewAccount.Show();
                this.Hide();
            }
            else if (Login.log_ad_user != null)
            {
                StaffAccountInfomation staffaccount = new StaffAccountInfomation();
                staffaccount.Show();
                this.Hide();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login.log_user = "";
            Login.log_ad_user = "";
            Login.log_email = "";
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_btn1_Click(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user);
                staff sf = content.staff.SingleOrDefault(i => i.accountID == Login.log_ad_user);
                if (cs != null)
                {
                    CreateBooking_SelectServiceType bk = new CreateBooking_SelectServiceType();
                    bk.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 0)
                {
                    EditBookingStaff editBK = new EditBookingStaff();
                    editBK.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 1)
                {
                    EditAirwayBillStaff editPK = new EditAirwayBillStaff();
                    editPK.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 2)
                {
                    
                }
                else if (sf != null && sf.jobID == 3)
                {
                    
                }
                if (sf != null && sf.jobID == 4)
                {
                    CSOViewCustomerInfo cSOViewCustomer = new CSOViewCustomerInfo();
                    cSOViewCustomer.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 5)
                {
                    Logging log = new Logging();
                    log.Show();
                    this.Hide();
                }
            }
        }

        private void btn_btn2_Click(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                staff sf = content.staff.SingleOrDefault(i => i.accountID == Login.log_ad_user);
                customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user);

                if (cs != null)
                {
                    CommercialInvoice_List ciReport = new CommercialInvoice_List();
                    ciReport.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 0)
                {
                    EditPackageStaff editPkg = new EditPackageStaff();
                    editPkg.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 1)
                {
                    EditDeliveryStatus editPkgStatus = new EditDeliveryStatus();
                    editPkgStatus.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 2)
                {
                    AccountingReport_Select report = new AccountingReport_Select();
                    report.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 3)
                {
                    AccountingReport_Select report = new AccountingReport_Select();
                    report.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 4)
                {
                    PayCash cash = new PayCash();
                    cash.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 5)
                {
                    ViewStaffAccount CreatestaffAccount = new ViewStaffAccount();
                    CreatestaffAccount.Show();
                    this.Hide();
                }


            }
        }

        private void btn_btn3_Click(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                staff sf = content.staff.SingleOrDefault(i => i.accountID == Login.log_ad_user);
                customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user);
                if (cs != null)
                {
                    Customer_TrackDelivery_Export trackDelivery = new Customer_TrackDelivery_Export();
                    trackDelivery.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 0)
                {
                    EditDestinationStaff editDest = new EditDestinationStaff();
                    editDest.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 1)
                {
                    EditAirwayBillStaff airwayBill = new EditAirwayBillStaff();
                    airwayBill.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 5)
                {
                    CreateStaffAcccount createstaffaccount = new CreateStaffAcccount();
                    createstaffaccount.Show();
                    this.Hide();
                }
                
            }
        }

        private void btn_btn4_Click(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                staff sf = content.staff.SingleOrDefault(i => i.accountID == Login.log_ad_user);
                customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user);

                if (cs != null)
                {
                    Payment payment = new Payment();
                    payment.Show();
                    this.Hide();
                }
                else if (sf != null && sf.jobID == 5)
                {
                    ManageCentreInformation centre = new ManageCentreInformation();
                    centre.Show();
                    this.Hide();
                }
            }
        }

        private void btn_btn5_Click(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                staff sf = content.staff.SingleOrDefault(i => i.accountID == Login.log_ad_user);
                customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user);
                {
                    if (cs != null)
                    {
                        ShippingExpenseCalculator shippingExpenseCalculator = new ShippingExpenseCalculator();
                        shippingExpenseCalculator.Show();
                        this.Hide();
                    }
                    else if (sf != null && sf.jobID == 0)
                    {
                        ViewAllBookingOrder bkoAll = new ViewAllBookingOrder();
                        bkoAll.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void btn_btn6_Click(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                staff sf = content.staff.SingleOrDefault(i => i.accountID == Login.log_ad_user);
                customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user);
                {
                    if (cs != null)
                    {
                        ContactUs contactUs = new ContactUs();
                        contactUs.Show();
                        this.Hide();
                    }
                    else if (sf != null && sf.jobID == 0)
                    {
                        ViewAllPackage pkgAll = new ViewAllPackage();
                        pkgAll.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void btn_btn7_Click(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                staff sf = content.staff.SingleOrDefault(i => i.accountID == Login.log_ad_user);
                customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user);
                {
                    if (cs != null)
                    {
                        /*CustomerAddressBook customerAddressBook = new CustomerAddressBook();
                        customerAddressBook.Show();*/
                        Customer_ViewBookingOrder.CustomerViewBookingOrder viewPkg = new Customer_ViewBookingOrder.CustomerViewBookingOrder();
                        viewPkg.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void btn_btn8_Click(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                staff sf = content.staff.SingleOrDefault(i => i.accountID == Login.log_ad_user);
                customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user);

                if (cs != null)
                {
                    EDEapp_PaymentRecord payrecord = new EDEapp_PaymentRecord();
                    payrecord.Show();
                    this.Hide();
                }
            }
        }

        private void EDEapp_MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the app?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
