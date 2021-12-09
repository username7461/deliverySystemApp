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

namespace EDEapp.Customer_ViewBookingOrder
{
    public partial class AddressBook_Package : Form
    {
        private string randomCode;
        static string log_user;
        addressbook adb1 = new addressbook();

        public AddressBook_Package()
        {
            InitializeComponent();
            log_user = Login.log_user;

            // Textbox initialize setting
            txt_contectName.ReadOnly = false;
            txt_companyName.ReadOnly = false;
            txt_addr1.ReadOnly = false;
            txt_addr2.ReadOnly = false;
            txt_addr3.ReadOnly = false;
            cb_region.Enabled = true;
            txt_postcode.ReadOnly = false;
            txt_phoneNo.ReadOnly = false;
            txt_faxNo.ReadOnly = false;
            txt_telexNo.ReadOnly = false;

            // Button initialize setting
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_cancel.Enabled = false;
            btn_selectAddr.Enabled = false;

            // DataGridView initialize setting
            dgv_addrBook.ReadOnly = true;
            dgv_addrBook.AllowUserToResizeRows = false;
            dgv_addrBook.AllowUserToResizeColumns = true;
            dgv_addrBook.Columns[0].HeaderText = "Contect Name";
            dgv_addrBook.Columns[1].HeaderText = "Company Name";
            dgv_addrBook.Columns[2].HeaderText = "Address Line 1";
            dgv_addrBook.Columns[3].HeaderText = "Address Line 2";
            dgv_addrBook.Columns[4].HeaderText = "Address Line 3";
            dgv_addrBook.Columns[5].HeaderText = "Region";
            dgv_addrBook.Columns[6].HeaderText = "Postcode";
            dgv_addrBook.Columns[7].HeaderText = "Phone Number";
            dgv_addrBook.Columns[8].HeaderText = "Fax Number";
            dgv_addrBook.Columns[9].HeaderText = "Telex Number";
            dgv_addrBook.Columns[10].HeaderText = "addrID";

            // Region comboBox initialize setting
            cb_region.Items.Add("Hong Kong");
            cb_region.Items.Add("Australia");
            cb_region.Items.Add("Japan");
            cb_region.Items.Add("China Shanghai");

            refreshGridView();
        }

        private void AddressBook_Package_Load(object sender, EventArgs e)
        {
            using (edeaccountEntities database = new edeaccountEntities())
            {
                /* ----------------------------TEST ONLY-------------------------------------- */
                /*using (var cusAddrBook = new edeaccountEntities())
                {
                    var adb = (from list in cusAddrBook.addressbook where list.accountID == "0000000003" *//*list.accID == Login.log_user*//* select list);

                    foreach (var adb2 in adb.ToList())
                    {
                        dgv_addrBook.Rows.Add(adb2.contectName, adb2.companyName, adb2.addressLn1, adb2.addressLn2, adb2.addressLn3, adb2.region, adb2.postcode, adb2.phoneNo, adb2.faxNo, adb2.telexNo, adb2.addressId);
                    }
                }*/
                /* ----------------------------TEST ONLY-------------------------------------- */
                refreshGridView();
            }
        }

        private void btn_selectAddr_Click(object sender, EventArgs e)
        {
            Customer_EditPackage.addrID = dgv_addrBook.CurrentRow.Cells[10].Value.ToString();
            Customer_EditPackage.txtContectName.Text = dgv_addrBook.CurrentRow.Cells[0].Value.ToString();
            Customer_EditPackage.txtCompanyName.Text = dgv_addrBook.CurrentRow.Cells[1].Value.ToString();
            Customer_EditPackage.txtAddrLn1.Text = dgv_addrBook.CurrentRow.Cells[2].Value.ToString();
            Customer_EditPackage.txtAddrLn2.Text = dgv_addrBook.CurrentRow.Cells[3].Value.ToString();
            Customer_EditPackage.txtAddrLn3.Text = dgv_addrBook.CurrentRow.Cells[4].Value.ToString();
            Customer_EditPackage.txtRegion.Text = dgv_addrBook.CurrentRow.Cells[5].Value.ToString();
            Customer_EditPackage.txtPostcode.Text = dgv_addrBook.CurrentRow.Cells[6].Value.ToString();
            Customer_EditPackage.txtPhoneNo.Text = dgv_addrBook.CurrentRow.Cells[7].Value.ToString();
            Customer_EditPackage.txtFaxNo.Text = dgv_addrBook.CurrentRow.Cells[8].Value.ToString();
            Customer_EditPackage.txtTelexNo.Text = dgv_addrBook.CurrentRow.Cells[9].Value.ToString();
            this.Close();
        }

        private void refreshGridView()
        {
            dgv_addrBook.DataSource = null;
            dgv_addrBook.Rows.Clear();
            using (var cusAddrBook = new edeaccountEntities())
            {
                var adb = (from list in cusAddrBook.addressbook where list.accountID == Login.log_user select list);

                foreach (var adb2 in adb.ToList())
                {
                    dgv_addrBook.Rows.Add(adb2.contectName, adb2.companyName, adb2.addressLn1, adb2.addressLn2, adb2.addressLn3, adb2.region, adb2.postcode, adb2.phoneNo, adb2.faxNo, adb2.telexNo, adb2.addressId);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_addrBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            adb1.addressId = Convert.ToString(dgv_addrBook.CurrentRow.Cells[10].Value);

            // Enable buttons
            btn_add.Enabled = false;
            btn_edit.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = true;
            btn_cancel.Enabled = true;
            btn_selectAddr.Enabled = true;

            // Readdonly textboxes
            txt_contectName.ReadOnly = true;
            txt_companyName.ReadOnly = true;
            txt_addr1.ReadOnly = true;
            txt_addr2.ReadOnly = true;
            txt_addr3.ReadOnly = true;
            cb_region.Enabled = false;
            txt_postcode.ReadOnly = true;
            txt_phoneNo.ReadOnly = true;
            txt_faxNo.ReadOnly = true;
            txt_telexNo.ReadOnly = true;

            // Put the detail to textboxes
            txt_contectName.Text = dgv_addrBook.CurrentRow.Cells[0].Value.ToString();
            txt_companyName.Text = dgv_addrBook.CurrentRow.Cells[1].Value.ToString();
            txt_addr1.Text = dgv_addrBook.CurrentRow.Cells[2].Value.ToString();
            txt_addr2.Text = dgv_addrBook.CurrentRow.Cells[2].Value.ToString();
            txt_addr3.Text = dgv_addrBook.CurrentRow.Cells[4].Value.ToString();
            cb_region.Text = dgv_addrBook.CurrentRow.Cells[5].Value.ToString();
            txt_postcode.Text = dgv_addrBook.CurrentRow.Cells[6].Value.ToString();
            txt_phoneNo.Text = dgv_addrBook.CurrentRow.Cells[7].Value.ToString();
            txt_faxNo.Text = dgv_addrBook.CurrentRow.Cells[8].Value.ToString();
            txt_telexNo.Text = dgv_addrBook.CurrentRow.Cells[9].Value.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            // Enable textboxes
            txt_contectName.ReadOnly = false;
            txt_companyName.ReadOnly = false;
            txt_addr1.ReadOnly = false;
            txt_addr2.ReadOnly = false;
            txt_addr3.ReadOnly = false;
            cb_region.Enabled = true;
            txt_postcode.ReadOnly = false;
            txt_phoneNo.ReadOnly = false;
            txt_faxNo.ReadOnly = false;
            txt_telexNo.ReadOnly = false;

            // Enable some buttons
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_cancel.Enabled = false;
            btn_selectAddr.Enabled = false;

            // Clear textboxes content
            txt_contectName.Text = "";
            txt_companyName.Text = "";
            txt_addr1.Text = "";
            txt_addr2.Text = "";
            txt_addr3.Text = "";
            cb_region.Text = "";
            txt_postcode.Text = "";
            txt_phoneNo.Text = "";
            txt_faxNo.Text = "";
            txt_telexNo.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            update("Add");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Enable textboxes
            txt_contectName.ReadOnly = false;
            txt_companyName.ReadOnly = false;
            txt_addr1.ReadOnly = false;
            txt_addr2.ReadOnly = false;
            txt_addr3.ReadOnly = false;
            cb_region.Enabled = true;
            txt_postcode.ReadOnly = false;
            txt_phoneNo.ReadOnly = false;
            txt_faxNo.ReadOnly = false;
            txt_telexNo.ReadOnly = false;

            // Disable some button
            btn_add.Enabled = false;
            btn_edit.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = false;
            btn_cancel.Enabled = true;
            btn_selectAddr.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update("Edit");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Delete this Record? ", "Delete Address?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (edeaccountEntities customeraddressbook = new edeaccountEntities())
                {
                    var entry = customeraddressbook.Entry(adb1);
                    if (entry.State == EntityState.Detached)
                        customeraddressbook.addressbook.Attach(adb1);
                    customeraddressbook.addressbook.Remove(adb1);
                    customeraddressbook.SaveChanges();
                    MessageBox.Show("Address delete");
                    refreshGridView();
                    clear();
                }
            }
        }

        private void cb_region_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void update(String editOrAdd)
        {
            Regex numbervalid = new Regex(@"^(?=.*?[0-9]).{1,20}$");
            Regex faxvalid = new Regex(@"^(?=.*?[0-9]).{8,8}$");
            Regex telexvalid = new Regex(@"^(?=.*?[0-9]).{8,12}$");
            bool postcodeValid = numbervalid.IsMatch(txt_postcode.Text.Trim());
            bool faxNoValid = faxvalid.IsMatch(txt_faxNo.Text.Trim());
            bool telexValid = telexvalid.IsMatch(txt_telexNo.Text.Trim());
            if (txt_contectName.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide ContentName");
            }
            else if (txt_addr1.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide Address");
            }
            else if (txt_addr2.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide Address");
            }
            else if (txt_addr3.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide Address");
            }
            else if (txt_postcode.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide postcode");
            }
            else if (!postcodeValid)
            {
                MessageBox.Show("Postcode Is InValid");
            }
            else if (txt_faxNo.Text.Trim() != "" && !faxNoValid)
            {
                MessageBox.Show("FaxNo Is InValid");
            }
            else if (txt_telexNo.Text.Trim() != "" && !telexValid)
            {
                MessageBox.Show("Telex Is InValid");
            }
            else if (cb_region.SelectedIndex == -1)
            {
                MessageBox.Show("Region should be select");
            }
            else
            {
                if (editOrAdd == "Add")
                {
                    using (edeaccountEntities content = new edeaccountEntities())
                    {
                        Random rand = new Random();
                        randomCode = (rand.Next(999999999)).ToString();
                        addressbook adb = new addressbook
                        {
                            addressId = "a" + randomCode,
                            contectName = txt_contectName.Text,
                            companyName = txt_companyName.Text,
                            addressLn1 = txt_addr1.Text,
                            addressLn2 = txt_addr2.Text,
                            addressLn3 = txt_addr3.Text,
                            region = cb_region.GetItemText(cb_region.SelectedItem),
                            postcode = txt_postcode.Text,
                            phoneNo = txt_phoneNo.Text,
                            faxNo = txt_faxNo.Text,
                            accountID = Login.log_user,
                            telexNo = txt_telexNo.Text,

                        };
                        MessageBox.Show("AddressBook is added");
                        content.addressbook.Add(adb);
                        content.SaveChanges();
                        clear();
                        refreshGridView();
                    }
                }
                else if (editOrAdd == "Edit")
                {
                    adb1.addressId = Convert.ToString(dgv_addrBook.CurrentRow.Cells[10].Value);
                    using (edeaccountEntities content = new edeaccountEntities())
                    {
                        addressbook cs = content.addressbook.SingleOrDefault(i => i.addressId == adb1.addressId);
                        if (cs != null)
                        {
                            cs.contectName = txt_contectName.Text;
                            cs.companyName = txt_companyName.Text;
                            cs.addressLn1 = txt_addr1.Text;
                            cs.addressLn2 = txt_addr2.Text;
                            cs.addressLn3 = txt_addr3.Text;
                            cs.region = cb_region.GetItemText(cb_region.SelectedItem);
                            cs.faxNo = txt_faxNo.Text;
                            cs.postcode = txt_postcode.Text;
                            cs.phoneNo = txt_phoneNo.Text;
                            cs.telexNo = txt_telexNo.Text;
                            content.SaveChanges();
                            MessageBox.Show("address has been edit!");
                            clear();
                            refreshGridView();
                        }
                    }
                }
            }
        }
    }
}