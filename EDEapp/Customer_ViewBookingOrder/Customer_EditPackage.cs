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
    public partial class Customer_EditPackage : Form
    {
        private String log_user = "";
        public static String addrID = "";
        private String bookingID = "";
        Boolean canEdit;

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

        public Customer_EditPackage(String bookingID, Boolean canEdit)
        {
            InitializeComponent();
            log_user = Login.log_user;
            this.bookingID = bookingID;
            this.canEdit = canEdit;

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
            txt_packageID.ReadOnly = true;
            txt_packageName.ReadOnly = false;
            cb_packageType.Enabled = true;
            cb_serviceType.Enabled = false;
            txt_qty.ReadOnly = false;
            txt_unitValue.ReadOnly = false;
            txt_unit.ReadOnly = false;
            txt_length.ReadOnly = true;
            txt_width.ReadOnly = true;
            txt_height.ReadOnly = true;
            txt_weight.ReadOnly = true;
            txt_expense.ReadOnly = true;
            rtb_remark.ReadOnly = false;
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

            // Initialize ComboBox
            cb_packageType.Text = "Select...";
            cb_packageType.Items.Add("Envelope");
            cb_packageType.Items.Add("Freight");

            // Initialize Button
            btn_edit.Enabled = false;
            btn_update.Enabled = false;
            btn_cancelSelect.Enabled = false;
            btn_createPackage.Enabled = true;
            btn_deletePackage.Enabled = false;
            btn_changeAddr.Enabled = true;
            btn_exitEdit.Enabled = false;

            // Initialize DataGridView
            dgv_pkgList.ColumnCount = 7;
            dgv_pkgList.Columns[0].HeaderText = "Package ID";
            dgv_pkgList.Columns[1].HeaderText = "Package Name";
            dgv_pkgList.Columns[2].HeaderText = "Package Type";
            dgv_pkgList.Columns[3].HeaderText = "Service Type";
            dgv_pkgList.Columns[4].HeaderText = "Quantity";
            dgv_pkgList.Columns[5].HeaderText = "Unit Value";
            dgv_pkgList.Columns[6].HeaderText = "AddressID";
            dgv_pkgList.Columns[6].Visible = false;
            dgv_pkgList.AllowUserToAddRows = false;
            dgv_pkgList.ReadOnly = true;
            dgv_pkgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_pkgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_pkgList.AutoGenerateColumns = false;
        }

        private void cb_packageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_packageType.Enabled == true)
            {
                if (cb_packageType.SelectedIndex == 0)
                {
                    cb_serviceType.Items.Clear();
                    cb_serviceType.Enabled = true;
                    cb_serviceType.Text = "Select...";
                    cb_serviceType.Items.Add("Document");
                    cb_serviceType.Items.Add("Express Document");
                    cb_serviceType.Items.Add("Domestic");
                    cb_serviceType.Items.Add("Worldmail (Airmail)");
                    cb_serviceType.Items.Add("Worldmail (Printed Master)");
                }
                else if (cb_packageType.SelectedIndex == 1)
                {
                    cb_serviceType.Items.Clear();
                    cb_serviceType.Enabled = true;
                    cb_serviceType.Text = "Select...";
                    cb_serviceType.Items.Add("Package Express");
                    cb_serviceType.Items.Add("Domestic");
                    cb_serviceType.Items.Add("Worldmail (Airmail)");
                    cb_serviceType.Items.Add("Worldmail (Printed Master)");
                }
            }
        }

        private void Customer_EditPackage_Load(object sender, EventArgs e)
        {
            refreshDGV();
            dgv_pkgList.ClearSelection();
        }

        private void refreshDGV()
        {
            dgv_pkgList.Rows.Clear();
            using (var db = new edeaccountEntities())
            {
                var pkg = (from list in db.packages
                           where list.bookingID == bookingID
                           select list);
                foreach (var pkg2 in pkg.ToList())
                {
                    dgv_pkgList.Rows.Add(pkg2.packageID, pkg2.pkgName, pkg2.packageType, pkg2.serviceType, pkg2.qty + " " + pkg2.unit, pkg2.unitValue.ToString("$ #,###.##"), pkg2.addrID);
                    dgv_pkgList.DefaultCellStyle.Font = new Font("Arial", 13F, GraphicsUnit.Pixel);
                }
            }
        }

        private void clearTextBox()
        {
            txt_packageID.Text = "";
            txt_packageName.Text = "";
            txt_qty.Text = "";
            txt_unitValue.Text = "";
            txt_unit.Text = "";
            txt_length.Text = "";
            txt_width.Text = "";
            txt_height.Text = "";
            txt_weight.Text = "";
            txt_expense.Text = "";
            rtb_remark.Text = "";
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
        }

        private void dgv_pkgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set TextBox
            txt_packageID.ReadOnly = true;
            txt_packageName.ReadOnly = true;
            cb_packageType.Enabled = false;
            cb_serviceType.Enabled = false;
            txt_qty.ReadOnly = true;
            txt_unitValue.ReadOnly = true;
            txt_unit.ReadOnly = true;
            txt_length.ReadOnly = true;
            txt_width.ReadOnly = true;
            txt_height.ReadOnly = true;
            txt_weight.ReadOnly = true;
            txt_expense.ReadOnly = true;
            rtb_remark.ReadOnly = true;

            // Set Button
            btn_edit.Enabled = true;
            btn_update.Enabled = false;
            btn_cancelSelect.Enabled = true;
            btn_createPackage.Enabled = false;
            btn_deletePackage.Enabled = true;
            btn_changeAddr.Enabled = true;
            btn_exitEdit.Enabled = false;

            // Fill data to TextBox
            using(edeaccountEntities db = new edeaccountEntities())
            {
                String pkgID = dgv_pkgList.CurrentRow.Cells[0].Value.ToString();
                String addrId = dgv_pkgList.CurrentRow.Cells[6].Value.ToString();

                package pkg = db.packages.SingleOrDefault(i => i.packageID == pkgID);
                addressbook addr = db.addressbook.SingleOrDefault(i => i.addressId == addrId);
                addrID = pkg.addrID;
                txt_packageID.Text = pkg.packageID;
                txt_packageName.Text = pkg.pkgName;
                cb_packageType.Text = pkg.packageType;
                cb_serviceType.Text = pkg.serviceType;
                txt_qty.Text = pkg.qty.ToString();
                txt_unitValue.Text = pkg.unitValue.ToString();
                txt_unit.Text = pkg.unit;
                if (pkg.length != null)
                    txt_length.Text = pkg.length.ToString() + " cm";
                else
                    txt_length.Text = "N/A";
                if (pkg.width != null)
                    txt_width.Text = pkg.width.ToString() + " cm";
                else
                    txt_width.Text = "N/A";
                if (pkg.height != null)
                    txt_height.Text = pkg.height.ToString() + " cm";
                else
                    txt_height.Text = "N/A";
                if (pkg.weight != null)
                    txt_weight.Text = pkg.weight.ToString() + " cm";
                else
                    txt_weight.Text = "N/A";
                if (pkg.expense != null)
                    txt_expense.Text = pkg.expense.ToString() + " cm";
                else
                    txt_expense.Text = "N/A";
                rtb_remark.Text = pkg.remark;
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
        }

        private void cb_packageType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_serviceType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (canEdit)
            {
                // Set TextBox
                txt_packageName.ReadOnly = false;
                cb_packageType.Enabled = true;
                cb_serviceType.Enabled = true;
                txt_qty.ReadOnly = false;
                txt_unit.ReadOnly = false;
                txt_unitValue.ReadOnly = false;
                rtb_remark.ReadOnly = false;

                // Set Button
                btn_edit.Enabled = false;
                btn_update.Enabled = true;
                btn_cancelSelect.Enabled = false;
                btn_createPackage.Enabled = false;
                btn_deletePackage.Enabled = false;
                btn_changeAddr.Enabled = true;
                btn_exitEdit.Enabled = true;
            }
            else
                MessageBox.Show("Cannot edit / update / delete packages when the pickup time remain within 24 hours.");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure to update pacakge information?", "Update Pacakge", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                using(edeaccountEntities db = new edeaccountEntities())
                {
                    package pkg = db.packages.SingleOrDefault(i => i.packageID == txt_packageID.Text);
                    pkg.pkgName = txt_packageName.Text;
                    pkg.packageType = cb_packageType.Text;
                    pkg.serviceType = cb_serviceType.Text;
                    pkg.qty = int.Parse(txt_qty.Text);
                    pkg.unitValue = double.Parse(txt_unitValue.Text);
                    pkg.unit = txt_unit.Text;
                    pkg.remark = rtb_remark.Text;
                    pkg.addrID = addrID;
                    db.SaveChanges();
                    MessageBox.Show("Package information has been updated.");
                }
                addrID = "";

                // Set Textbox
                txt_packageID.ReadOnly = true;
                txt_packageName.ReadOnly = false;
                cb_packageType.Enabled = true;
                cb_serviceType.Enabled = false;
                txt_qty.ReadOnly = false;
                txt_unitValue.ReadOnly = false;
                txt_unit.ReadOnly = false;
                txt_length.ReadOnly = true;
                txt_width.ReadOnly = true;
                txt_height.ReadOnly = true;
                txt_weight.ReadOnly = true;
                txt_expense.ReadOnly = true;
                rtb_remark.ReadOnly = false;
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

                // Set ComboBox
                cb_packageType.Text = "Select...";
                cb_packageType.Items.Add("Envelope");
                cb_packageType.Items.Add("Freight");

                // Set Button
                btn_edit.Enabled = false;
                btn_update.Enabled = false;
                btn_cancelSelect.Enabled = false;
                btn_createPackage.Enabled = true;
                btn_deletePackage.Enabled = false;
                btn_changeAddr.Enabled = false;
                btn_exitEdit.Enabled = false;

                refreshDGV();
            }
        }

        private void btn_cancelSelect_Click(object sender, EventArgs e)
        {
            // Set Textbox
            txt_packageID.ReadOnly = true;
            txt_packageName.ReadOnly = false;
            cb_packageType.Enabled = true;
            cb_serviceType.Enabled = false;
            txt_qty.ReadOnly = false;
            txt_unitValue.ReadOnly = false;
            txt_unit.ReadOnly = false;
            txt_length.ReadOnly = true;
            txt_width.ReadOnly = true;
            txt_height.ReadOnly = true;
            txt_weight.ReadOnly = true;
            txt_expense.ReadOnly = true;
            rtb_remark.ReadOnly = false;
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

            clearTextBox();

            // Set ComboBox
            cb_packageType.Text = "Select...";
            cb_packageType.Items.Add("Envelope");
            cb_packageType.Items.Add("Freight");

            // Set Button
            btn_edit.Enabled = false;
            btn_update.Enabled = false;
            btn_cancelSelect.Enabled = false;
            btn_createPackage.Enabled = true;
            btn_deletePackage.Enabled = false;
            btn_changeAddr.Enabled = true;
            btn_exitEdit.Enabled = false;

            dgv_pkgList.ClearSelection();
        }

        private void btn_createPackage_Click(object sender, EventArgs e)
        {
            if (canEdit)
            {
                if(txt_packageName.Text.Trim() == "")
                {
                    MessageBox.Show("Please input the package name.");
                }
                else if(cb_packageType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the package type.");
                }
                else if(cb_serviceType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the service type.");
                }
                else if(txt_qty.Text.Trim() == "")
                {
                    MessageBox.Show("Please input the quantity.");
                }
                else if(txt_unitValue.Text.Trim() == "")
                {
                    MessageBox.Show("Please input the unit value.");
                }
                else if(txt_unit.Text.Trim() == "")
                {
                    MessageBox.Show("Please input the unit.");
                }
                else if(addrID == "")
                {
                    MessageBox.Show("Please select receiver address.");
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Are you sure to create package?", "Create Package", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        using (edeaccountEntities db = new edeaccountEntities())
                        {
                            Random rand = new Random();
                            string bookingNo = bookingID;
                            string packageNo = "P" + (rand.Next(999999999)).ToString();
                            package pk;
                            while (true)
                            {
                                pk = db.packages.SingleOrDefault(i => i.packageID == packageNo);
                                if (pk != null)
                                    packageNo = "P" + (rand.Next(999999999)).ToString();
                                else
                                    break;
                            }
                            package pkg = new package
                            {
                                packageID = packageNo,
                                accID = log_user,
                                bookingID = bookingNo,
                                pkgName = txt_packageName.Text,
                                packageType = cb_packageType.Text,
                                serviceType = cb_serviceType.Text,
                                isImport = false,
                                qty = int.Parse(txt_qty.Text),
                                unit = txt_unit.Text,
                                unitValue = double.Parse(txt_unitValue.Text),
                                addrID = addrID,
                                statusTime = DateTime.Now,
                                status = "0",
                                isComplete = 0,
                                location = "N/A",
                                centreID = "N/A",
                                staffID = "N/A",
                                remark = rtb_remark.Text,
                                cusConfirm = false
                            };
                            db.packages.Add(pkg);
                            db.SaveChanges();
                            MessageBox.Show("Package Create Successful.");
                        }
                        refreshDGV();
                    }
                }
            }
            else
                MessageBox.Show("Cannot edit / update / delete packages when the pickup time remain within 24 hours.");
        }

        private void btn_deletePackage_Click(object sender, EventArgs e)
        {
            if (canEdit)
            {
                DialogResult dialog = MessageBox.Show("Are you sure to delete the package?", "Delete Package", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    using (edeaccountEntities db = new edeaccountEntities())
                    {
                        package pkg = db.packages.SingleOrDefault(i => i.packageID == txt_packageID.Text);
                        db.packages.Remove(pkg);
                        db.SaveChanges();
                        MessageBox.Show("Pacakge has been deleted.");
                    }
                    clearTextBox();
                    refreshDGV();
                }
            }
            else
                MessageBox.Show("Cannot edit / update / delete packages when the pickup time remain within 24 hours.");
        }

        private void btn_exitEdit_Click(object sender, EventArgs e)
        {
            using(edeaccountEntities db = new edeaccountEntities())
            {
                package pkg = db.packages.SingleOrDefault(i => i.packageID == txt_packageID.Text);
                addressbook addr = db.addressbook.SingleOrDefault(i => i.addressId == pkg.addrID);
                txt_packageName.Text = pkg.pkgName;
                cb_packageType.Text = pkg.packageType;
                cb_serviceType.Text = pkg.serviceType;
                txt_qty.Text = pkg.qty.ToString();
                txt_unitValue.Text = pkg.unitValue.ToString();
                txt_unit.Text = pkg.unit;
                rtb_remark.Text = pkg.remark;
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
            // Set Textbox
            txt_packageID.ReadOnly = true;
            txt_packageName.ReadOnly = true;
            cb_packageType.Enabled = false;
            cb_serviceType.Enabled = false;
            txt_qty.ReadOnly = true;
            txt_unitValue.ReadOnly = true;
            txt_unit.ReadOnly = true;
            txt_length.ReadOnly = true;
            txt_width.ReadOnly = true;
            txt_height.ReadOnly = true;
            txt_weight.ReadOnly = true;
            txt_expense.ReadOnly = true;
            rtb_remark.ReadOnly = true;
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

            // Set ComboBox
            cb_packageType.Text = "Select...";
            cb_packageType.Items.Add("Envelope");
            cb_packageType.Items.Add("Freight");

            // Set Button
            btn_edit.Enabled = true;
            btn_update.Enabled = false;
            btn_cancelSelect.Enabled = true;
            btn_createPackage.Enabled = true;
            btn_deletePackage.Enabled = false;
            btn_changeAddr.Enabled = true;
            btn_exitEdit.Enabled = false;
        }

        private void btn_changeAddr_Click(object sender, EventArgs e)
        {
            if (canEdit)
            {
                Customer_ViewBookingOrder.AddressBook_Package addr = new Customer_ViewBookingOrder.AddressBook_Package();
                addr.ShowDialog();
            }
            else
                MessageBox.Show("Cannot edit / update / delete packages when the pickup time remain within 24 hours.");
        }
    }
}
