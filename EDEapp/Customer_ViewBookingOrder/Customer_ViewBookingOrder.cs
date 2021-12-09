using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDEapp.Customer_ViewBookingOrder
{
    public partial class CustomerViewBookingOrder : Form
    {
        private String log_user;
        public static String addrID = "";
        
        // public static Address TextBox
        public static TextBox txtContectName;
        public static TextBox txtCompanyName;
        public static TextBox txtAddrLn1;
        public static TextBox txtAddrLn2;
        public static TextBox txtAddrLn3;
        public static TextBox txtRegion;
        public static TextBox txtPostcode;
        public static TextBox txtPhoneNo;
        public static TextBox txtFaxNo;
        public static TextBox txtTelexNo;

        public CustomerViewBookingOrder()
        {
            InitializeComponent();
            log_user = Login.log_user;

            // Initialize Address TextBox
            txtContectName = txt_contectName;
            txtCompanyName = txt_companyName;
            txtAddrLn1 = txt_addr1;
            txtAddrLn2 = txt_addr2;
            txtAddrLn3 = txt_addr3;
            txtRegion = txt_region;
            txtPostcode = txt_postcode;
            txtPhoneNo = txt_phoneNo;
            txtFaxNo = txt_faxNo;
            txtTelexNo = txt_telexNo;

            // Initialize Textbox
            txt_bookingID.ReadOnly = true;
            txt_serviceType.ReadOnly = true;
            txt_pickupDate.ReadOnly = true;
            txt_pickupTime.ReadOnly = true;
            txt_bookingCreationDate.ReadOnly = true;
            txt_contectName.ReadOnly = true;
            txt_companyName.ReadOnly = true;
            txt_addr1.ReadOnly = true;
            txt_addr2.ReadOnly = true;
            txt_addr3.ReadOnly = true;
            txt_region.ReadOnly = true;
            txt_postcode.ReadOnly = true;
            txt_phoneNo.ReadOnly = true;
            txt_faxNo.ReadOnly = true;
            txt_telexNo.ReadOnly = true;

            // Initialize Button
            btn_edit.Enabled = false;
            btn_update.Enabled = false;
            btn_changeAddr.Enabled = false;
            btn_viewPackage.Enabled = false;
            btn_cancelBooking.Enabled = false;
            btn_exitEdit.Enabled = false;

            // Initialize DataGridView
            dgv_bkoList.ColumnCount = 8;
            dgv_bkoList.Columns[0].HeaderText = "Booking ID";
            dgv_bkoList.Columns[1].HeaderText = "Number of Packages";
            dgv_bkoList.Columns[2].HeaderText = "Service Type";
            dgv_bkoList.Columns[3].HeaderText = "Pickup Date";
            dgv_bkoList.Columns[4].HeaderText = "Pickup Time";
            dgv_bkoList.Columns[5].HeaderText = "Total Expenses";
            dgv_bkoList.Columns[6].HeaderText = "Creation Date Time";
            dgv_bkoList.Columns[7].HeaderText = "Address ID";
            dgv_bkoList.Columns[7].Visible = false;
            dgv_bkoList.AllowUserToAddRows = false;
            dgv_bkoList.ReadOnly = true;
            dgv_bkoList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_bkoList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_bkoList.AutoGenerateColumns = false;
        }

        private void Customer_ViewBookingOrder_Load(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void refreshDGV()
        {
            dgv_bkoList.Rows.Clear();
            using (var db = new edeaccountEntities())
            {
                var bko = (from list in db.bookingorder
                           where list.accID == log_user
                           where list.status != "2"
                           orderby list.datetime
                           select list);
                foreach (var bko2 in bko.ToList())
                {
                    int numPkg = 0;
                    using (var db2 = new edeaccountEntities())
                    {
                        var pkg = (from list in db2.packages
                                   where list.bookingID == bko2.bookingID
                                   select list);
                        foreach (var pkg2 in pkg.ToList())
                            numPkg += 1;
                    }
                    dgv_bkoList.Rows.Add(bko2.bookingID, numPkg, bko2.serviceType, bko2.pickupDate, bko2.pickupTime, bko2.totalExpenses, bko2.datetime, bko2.addrID);
                    dgv_bkoList.DefaultCellStyle.Font = new Font("Arial", 13F, GraphicsUnit.Pixel);
                }
            }
            dgv_bkoList.ClearSelection();
        }

        private void dgv_bkoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using(edeaccountEntities db = new edeaccountEntities())
            {
                String bookingID = dgv_bkoList.CurrentRow.Cells[0].Value.ToString();
                String addressID = dgv_bkoList.CurrentRow.Cells[7].Value.ToString();
                bookingorder bko = db.bookingorder.SingleOrDefault(i => i.bookingID == bookingID);
                addressbook addr = db.addressbook.SingleOrDefault(i => i.addressId == addressID);

                // Fill datas to the textBox
                txt_bookingID.Text = bko.bookingID;
                txt_serviceType.Text = bko.serviceType;
                txt_pickupDate.Text = bko.pickupDate;
                txt_pickupTime.Text = bko.pickupTime;
                txt_bookingCreationDate.Text = bko.datetime.ToString();
                txt_contectName.Text = addr.contectName;
                txt_companyName.Text = addr.companyName;
                txt_addr1.Text = addr.addressLn1;
                txt_addr2.Text = addr.addressLn2;
                txt_addr3.Text = addr.addressLn3;
                txt_region.Text = addr.region;
                txt_postcode.Text = addr.postcode;
                txt_phoneNo.Text = addr.phoneNo;
                txt_faxNo.Text = addr.faxNo;
                txt_telexNo.Text = addr.telexNo;

                addrID = addressID;
            }
            // Set the button 'Enabled'
            btn_edit.Enabled = true;
            btn_viewPackage.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DateTime pickup = Convert.ToDateTime(txt_pickupDate.Text);
            DateTime now = DateTime.Now;
            if((pickup - now).TotalDays > 1)
            {
                // Set TextBox Enabled
                txt_bookingID.ReadOnly = true;
                txt_serviceType.ReadOnly = true;
                txt_pickupDate.ReadOnly = false;
                txt_pickupTime.ReadOnly = false;
                txt_bookingCreationDate.ReadOnly = true;
                txt_contectName.ReadOnly = true;
                txt_companyName.ReadOnly = true;
                txt_addr1.ReadOnly = true;
                txt_addr2.ReadOnly = true;
                txt_addr3.ReadOnly = true;
                txt_region.ReadOnly = true;
                txt_postcode.ReadOnly = true;
                txt_phoneNo.ReadOnly = true;
                txt_faxNo.ReadOnly = true;
                txt_telexNo.ReadOnly = true;

                // Set the button 'Enabled'
                btn_edit.Enabled = false;
                btn_update.Enabled = true;
                btn_changeAddr.Enabled = true;
                btn_cancelBooking.Enabled = true;
                btn_exitEdit.Enabled = true;

                // Disable the DataGridView
                dgv_bkoList.Enabled = false;
            }
            else
            {
                MessageBox.Show("Can't edit booking!\nIf you want edit booking, must at least one day before.");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you confirm the update information?", "Confirm Update Booking Order", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                using (edeaccountEntities db = new edeaccountEntities())
                {
                    String addressID = dgv_bkoList.CurrentRow.Cells[7].Value.ToString();
                    bookingorder bko = db.bookingorder.SingleOrDefault(i => i.bookingID == txt_bookingID.Text);
                    bko.pickupDate = txt_pickupDate.Text;
                    bko.pickupTime = txt_pickupTime.Text;
                    bko.addrID = addrID;
                    try
                    {
                        db.SaveChanges();
                    }
                    catch(Exception ex)
                    {

                    }
                    MessageBox.Show("Booking Order has been updated.");
                }
                addrID = "";

                // Set TextBox
                txt_bookingID.ReadOnly = true;
                txt_serviceType.ReadOnly = true;
                txt_pickupDate.ReadOnly = true;
                txt_pickupTime.ReadOnly = true;
                txt_bookingCreationDate.ReadOnly = true;
                txt_contectName.ReadOnly = true;
                txt_companyName.ReadOnly = true;
                txt_addr1.ReadOnly = true;
                txt_addr2.ReadOnly = true;
                txt_addr3.ReadOnly = true;
                txt_region.ReadOnly = true;
                txt_postcode.ReadOnly = true;
                txt_phoneNo.ReadOnly = true;
                txt_faxNo.ReadOnly = true;
                txt_telexNo.ReadOnly = true;

                // Set the button
                btn_edit.Enabled = true;
                btn_update.Enabled = false;
                btn_changeAddr.Enabled = false;
                btn_cancelBooking.Enabled = false;
                btn_exitEdit.Enabled = false;

                // Enable the DataGridView
                dgv_bkoList.Enabled = true;

                refreshDGV();
            }
        }

        private void btn_changeAddr_Click(object sender, EventArgs e)
        {
            ChangePickupAddress changeAddr = new ChangePickupAddress();
            changeAddr.ShowDialog();
        }

        private void btn_cancelBooking_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure to cancel booking order?", "Cancel Booking Order", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                // Cancel Booking Order
                using(edeaccountEntities db = new edeaccountEntities())
                {
                    bookingorder bko = db.bookingorder.SingleOrDefault(i => i.bookingID == txt_bookingID.Text);
                    bko.status = "2";
                    db.SaveChanges();
                }

                // Cancel Package
                using(var db = new edeaccountEntities())
                {
                    var pkg = (from list in db.packages
                               where list.bookingID == txt_bookingID.Text
                               select list);
                    foreach(var pkg2 in pkg.ToList())
                    {
                        pkg2.status = "8";
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Your booking order was canceled.");

                // Set TextBox
                txt_bookingID.ReadOnly = true;
                txt_serviceType.ReadOnly = true;
                txt_pickupDate.ReadOnly = true;
                txt_pickupTime.ReadOnly = true;
                txt_bookingCreationDate.ReadOnly = true;
                txt_contectName.ReadOnly = true;
                txt_companyName.ReadOnly = true;
                txt_addr1.ReadOnly = true;
                txt_addr2.ReadOnly = true;
                txt_addr3.ReadOnly = true;
                txt_region.ReadOnly = true;
                txt_postcode.ReadOnly = true;
                txt_phoneNo.ReadOnly = true;
                txt_faxNo.ReadOnly = true;
                txt_telexNo.ReadOnly = true;

                // Set the button
                btn_edit.Enabled = true;
                btn_update.Enabled = false;
                btn_changeAddr.Enabled = false;
                btn_cancelBooking.Enabled = false;
                btn_exitEdit.Enabled = false;

                // Enable the DataGridView
                dgv_bkoList.Enabled = true;

                txt_bookingID.Text = "";
                txt_serviceType.Text = "";
                txt_pickupDate.Text = "";
                txt_pickupTime.Text = "";
                txt_bookingCreationDate.Text = "";
                txt_contectName.Text = "";
                txt_companyName.Text = "";
                txt_addr1.Text = "";
                txt_addr2.Text = "";
                txt_addr3.Text = "";
                txt_region.Text = "";
                txt_postcode.Text = "";
                txt_phoneNo.Text = "";
                txt_faxNo.Text = "";
                txt_telexNo.Text = "";
                refreshDGV();
            }
        }

        private void btn_exitEdit_Click(object sender, EventArgs e)
        {
            using (edeaccountEntities db = new edeaccountEntities())
            {
                String bookingID = dgv_bkoList.CurrentRow.Cells[0].Value.ToString();
                String addressID = dgv_bkoList.CurrentRow.Cells[7].Value.ToString();
                bookingorder bko = db.bookingorder.SingleOrDefault(i => i.bookingID == bookingID);
                addressbook addr = db.addressbook.SingleOrDefault(i => i.addressId == addressID);

                // Fill datas to the textBox
                txt_bookingID.Text = bko.bookingID;
                txt_serviceType.Text = bko.serviceType;
                txt_pickupDate.Text = bko.pickupDate;
                txt_pickupTime.Text = bko.pickupTime;
                txt_bookingCreationDate.Text = bko.datetime.ToString();
                txt_contectName.Text = addr.contectName;
                txt_companyName.Text = addr.companyName;
                txt_addr1.Text = addr.addressLn1;
                txt_addr2.Text = addr.addressLn2;
                txt_addr3.Text = addr.addressLn3;
                txt_region.Text = addr.region;
                txt_postcode.Text = addr.postcode;
                txt_phoneNo.Text = addr.phoneNo;
                txt_faxNo.Text = addr.faxNo;
                txt_telexNo.Text = addr.telexNo;
            }

            addrID = "";

            // Set TextBox
            txt_bookingID.ReadOnly = true;
            txt_serviceType.ReadOnly = true;
            txt_pickupDate.ReadOnly = true;
            txt_pickupTime.ReadOnly = true;
            txt_bookingCreationDate.ReadOnly = true;
            txt_contectName.ReadOnly = true;
            txt_companyName.ReadOnly = true;
            txt_addr1.ReadOnly = true;
            txt_addr2.ReadOnly = true;
            txt_addr3.ReadOnly = true;
            txt_region.ReadOnly = true;
            txt_postcode.ReadOnly = true;
            txt_phoneNo.ReadOnly = true;
            txt_faxNo.ReadOnly = true;
            txt_telexNo.ReadOnly = true;

            // Set the button
            btn_edit.Enabled = true;
            btn_update.Enabled = false;
            btn_changeAddr.Enabled = false;
            btn_cancelBooking.Enabled = false;
            btn_exitEdit.Enabled = false;

            // Enable the DataGridView
            dgv_bkoList.Enabled = true;
        }

        private void btn_viewPackage_Click(object sender, EventArgs e)
        {
            DateTime pickup = Convert.ToDateTime(txt_pickupDate.Text);
            DateTime now = DateTime.Now;
            Boolean canEdit;
            if ((pickup - now).TotalDays > 1)
                canEdit = true;
            else
                canEdit = false;
            Customer_EditPackage pkg = new Customer_EditPackage(dgv_bkoList.CurrentRow.Cells[0].Value.ToString(), canEdit);
            pkg.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
