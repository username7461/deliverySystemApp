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
    public partial class EditBookingStaff : Form
    {
        bookingorder bk1 = new bookingorder();
        addressbook adr1 = new addressbook();
        edeaccountEntities db = new edeaccountEntities();

        public EditBookingStaff()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].HeaderText = "accountID";
            dataGridView1.Columns[1].HeaderText = "bookingID";
            dataGridView1.Columns[2].HeaderText = "Company Name";
            dataGridView1.Columns[3].HeaderText = "Address";
            dataGridView1.Columns[4].HeaderText = "Region";
            dataGridView1.Columns[5].HeaderText = "Postcode";
            dataGridView1.Columns[6].HeaderText = "Contact Name";
            dataGridView1.Columns[7].HeaderText = "Phone Number";
            dataGridView1.Columns[8].HeaderText = "Fax";
            dataGridView1.Columns[9].HeaderText = "Telex";
            dataGridView1.Columns[10].HeaderText = "Pickup Time";
            ReloadDataGrid();
            cb_pickupDate.Text = "Select Date...";
            cb_pickupTime.Text = "Select Time...";
            for (int i = 1; i <= 7; i++)
                cb_pickupDate.Items.Add(DateTime.Now.AddDays(i).ToString("yyyy-MM-dd"));
            cb_pickupTime.Items.Add("10:00 - 14:00");
            cb_pickupTime.Items.Add("14:00 - 18:00");

            btn_cancel.Enabled = false;
            btn_edit.Enabled = false;
            btn_edit.Enabled = false;
        }
        private void EditPackageStaff_Load(object sender, EventArgs e)
        {
            ReloadDataGrid();
        }

        // Add a row record
        public static string pickupDate = null;
        public static string pickupTime = null;
        private void btn_add_Click(object sender, EventArgs e)
        {
            Boolean isCompleted = true;

            if (txtaccID.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please provide account ID.");
                return;
            }
            if (txtbookingID.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please provide booking ID.");
                return;
            }
            if (txtaddrID.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please provide address ID.");
                return;
            }

            if (txt_companyName.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please fill in the company name field.");
                return;
            }

            if (txt_addrLn1.Text == "" && txt_addrLn2.Text == "" && txt_addrLn3.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please fill in the address Line field.");
                return;
            }

            // would be better if this is combobox
            if (txt_region.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please provide the region information.");
                return;
            }

            if (txt_contectName.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please fill in the Contact Name field.");
                return;
            }

            if (txt_phoneNo.Text == "" && txt_faxNo.Text == "" && txt_telexNo.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please provide either [Phone number], [Fax Number] or [Telex Number] information");
                return;
            }

            switch (cb_pickupDate.SelectedIndex)
            {
                case 0:
                    pickupDate = cb_pickupDate.Items[0].ToString();
                    break;
                case 1:
                    pickupDate = cb_pickupDate.Items[1].ToString();
                    break;
                case 2:
                    pickupDate = cb_pickupDate.Items[2].ToString();
                    break;
                case 3:
                    pickupDate = cb_pickupDate.Items[3].ToString();
                    break;
                case 4:
                    pickupDate = cb_pickupDate.Items[4].ToString();
                    break;
                case 5:
                    pickupDate = cb_pickupDate.Items[5].ToString();
                    break;
                case 6:
                    pickupDate = cb_pickupDate.Items[6].ToString();
                    break;
                default:
                    isCompleted = false;
                    MessageBox.Show("Please select pickup date");
                    return;
            }
            switch (cb_pickupTime.SelectedIndex)
            {
                case 0:
                    pickupTime = cb_pickupTime.Items[0].ToString();
                    break;
                case 1:
                    pickupTime = cb_pickupTime.Items[1].ToString();
                    break;
                default:
                    isCompleted = false;
                    MessageBox.Show("Please select pickup time");
                    return;
            }

            // Create package
            if (isCompleted == true)
            {
                using (edeaccountEntities context = new edeaccountEntities())
                {
                    bookingorder b = new bookingorder
                    {
                        bookingID = txtbookingID.Text,
                        accID = txtaccID.Text,
                        addrID = txtaddrID.Text,
                        datetime = DateTime.Now,
                        totalExpenses = 0,
                        status = "0",
                        pickupDate = cb_pickupDate.Text,
                        pickupTime = cb_pickupTime.Text
                    };
                    context.bookingorder.Add(b);

                    String posCode = txt_postcode.Text;
                    if (txt_postcode.Text == "")
                        posCode = "N/A";

                    addressbook a = new addressbook
                    {
                        addressId = txtaddrID.Text,
                        accountID = txtaccID.Text,
                        contectName = txt_contectName.Text,
                        companyName = txt_companyName.Text,
                        addressLn1 = txt_addrLn1.Text,
                        addressLn2 = txt_addrLn2.Text,
                        addressLn3 = txt_addrLn3.Text,
                        region = txt_region.Text,

                        postcode = posCode,

                        phoneNo = txt_phoneNo.Text,
                        faxNo = txt_faxNo.Text,
                        telexNo = txt_telexNo.Text
                    };
                    context.addressbook.Add(a);
                    context.SaveChanges();
                    MessageBox.Show("Booking Successful, Booking ID: " + dataGridView1.RowCount);
                }
                // Add the package information to DataGridView
                ReloadDataGrid();
            }
        }
        void ReloadDataGrid()
        {
            dataGridView1.Rows.Clear();
            using (var bookingrecord = new edeaccountEntities())
            {
                var record1 = (from list in bookingrecord.bookingorder
                               join c in bookingrecord.addressbook on list.addrID equals c.addressId
                               where list.status == "0"
                               select new
                               {
                                   list.accID,
                                   list.bookingID,
                                   c.companyName,
                                   address = c.addressLn1 + " " + c.addressLn2 + " " + c.addressLn3,
                                   c.region,
                                   c.postcode,
                                   c.contectName,
                                   c.phoneNo,
                                   c.faxNo,
                                   c.telexNo,
                                   list.pickupDate,
                                   list.pickupTime
                               }
                               );
                foreach (var record in record1.ToList())
                {
                    dataGridView1.Rows.Add(record.accID, record.bookingID, record.companyName, record.address, record.region, record.postcode, record.contectName, record.phoneNo, record.faxNo, record.telexNo, record.pickupDate + " " + record.pickupTime);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

            using (var context = new edeaccountEntities())
            {
                var searchData = context
                .bookingorder
                .Join(
                    context.addressbook,
                    booking => booking.addrID,
                    address => address.addressId,
                    (booking, address) => new
                    {
                        Booking = booking,
                        Address = address
                    })
                .Where(data =>
                    data.Booking.bookingID.Contains(txtSearch.Text) ||
                    data.Address.companyName.Contains(txtSearch.Text) ||
                    data.Address.addressLn1.Contains(txtSearch.Text) ||
                    data.Address.addressLn2.Contains(txtSearch.Text) ||
                    data.Address.addressLn3.Contains(txtSearch.Text) ||
                    data.Address.region.Contains(txtSearch.Text) ||
                    data.Address.postcode.Contains(txtSearch.Text) ||
                    data.Address.contectName.Contains(txtSearch.Text) ||
                    data.Address.phoneNo.Contains(txtSearch.Text) ||
                    data.Address.faxNo.Contains(txtSearch.Text) ||
                    data.Address.telexNo.Contains(txtSearch.Text) ||
                    data.Booking.pickupDate.Contains(txtSearch.Text) ||
                    data.Booking.pickupTime.Contains(txtSearch.Text)
                )
                .ToList();

                foreach (var row in searchData)
                {
                    dataGridView1.Rows.Add(
                        row.Booking.accID,
                        row.Booking.bookingID,
                        row.Address.companyName,
                        $"{row.Address.addressLn1} {row.Address.addressLn2} {row.Address.addressLn3}",
                        row.Address.region,
                        row.Address.postcode,
                        row.Address.contectName,
                        row.Address.phoneNo,
                        row.Address.faxNo,
                        row.Address.telexNo,
                        row.Booking.pickupDate + " " + row.Booking.pickupTime
                    );
                }
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bk1.bookingID = Convert.ToString(dataGridView1.CurrentRow.Cells["Column2"].Value);
                using (edeaccountEntities context = new edeaccountEntities())
                {
                    bookingorder bkDelete = context.bookingorder.Find(bk1.bookingID);
                    context.bookingorder.Remove(bkDelete);
                    context.SaveChanges();
                }
                // Show the package create successful message
                MessageBox.Show("Package record deleted");
                ReloadDataGrid();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ResetAllControls(this);
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_add.Enabled = true;
            btn_cancel.Enabled = false;
        }
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = -1;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
                if (control is RadioButton)
                {
                    RadioButton rad = (RadioButton)control;
                    rad.Checked = false;
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetAllControls(this);
        }


        // To Load a datafrom dataGrid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                bk1.bookingID = Convert.ToString(dataGridView1.CurrentRow.Cells["Column2"].Value);

                using (edeaccountEntities ede = new edeaccountEntities())
                {

                    bk1 = ede.bookingorder.Where(x => x.bookingID == bk1.bookingID).FirstOrDefault();
                    adr1 = ede.addressbook.Where(x => x.addressId == bk1.addrID).FirstOrDefault();

                    txtaccID.Text = bk1.accID;
                    txtbookingID.Text = bk1.bookingID;
                    txtaddrID.Text = Convert.ToString(bk1.addrID);

                    txt_companyName.Text = adr1.companyName;
                    txt_addrLn1.Text = adr1.addressLn1;
                    txt_addrLn2.Text = adr1.addressLn2;
                    txt_addrLn3.Text = adr1.addressLn3;
                    txt_region.Text = adr1.region;
                    txt_postcode.Text = adr1.postcode;
                    txt_contectName.Text = adr1.contectName;
                    txt_phoneNo.Text = adr1.phoneNo;
                    txt_faxNo.Text = adr1.faxNo;
                    txt_telexNo.Text = adr1.telexNo;

                    cb_pickupDate.Text = bk1.pickupDate;
                    cb_pickupTime.Text = bk1.pickupTime;
                }
                btn_delete.Enabled = true;
                btn_edit.Enabled = true;
                btn_add.Enabled = false;
                btn_cancel.Enabled = true;
                btn_edit.Enabled = true;
            }
        }




        private void btn_edit_Click(object sender, EventArgs e)
        {
            Boolean isCompleted = true;

            if (txtaccID.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please provide account ID.");
                return;
            }
            if (txtbookingID.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please provide booking ID.");
                return;
            }
            if (txtaddrID.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please provide address ID.");
                return;
            }

            if (txt_companyName.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please fill in the company name field.");
                return;
            }

            if (txt_addrLn1.Text == "" && txt_addrLn2.Text == "" && txt_addrLn3.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please fill in the address Line field.");
                return;
            }

            // would be better if this is combobox
            if (txt_region.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please provide the region information.");
                return;
            }

            if (txt_contectName.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please fill in the Contact Name field.");
                return;
            }

            if (txt_phoneNo.Text == "" && txt_faxNo.Text == "" && txt_telexNo.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please provide either [Phone number], [Fax Number] or [Telex Number] information");
                return;
            }

            switch (cb_pickupDate.Text)
            {
                case "":
                    isCompleted = false;
                    MessageBox.Show("Please select pickup date");
                    return;
            }
            switch (cb_pickupTime.Text)
            {
                case "":
                    isCompleted = false;
                    MessageBox.Show("Please select pickup time");
                    return;
            }

            // Create package
            if (isCompleted == true)
            {

                using (edeaccountEntities context = new edeaccountEntities())
                {
                    bk1 = context.bookingorder.Where(x => x.bookingID == bk1.bookingID).FirstOrDefault();
                    adr1 = context.addressbook.Where(x => x.addressId == bk1.addrID).FirstOrDefault();


                    bk1.bookingID = txtbookingID.Text;
                    bk1.accID = txtaccID.Text;
                    bk1.addrID = txtaddrID.Text;
                    bk1.datetime = DateTime.Now;
                    bk1.totalExpenses = 0;
                    bk1.status = "0";
                    bk1.pickupDate = cb_pickupDate.Text;
                    bk1.pickupTime = cb_pickupTime.Text;



                    String posCode = txt_postcode.Text;
                    if (txt_postcode.Text == "")
                        posCode = "N/A";


                    adr1.addressId = txtaddrID.Text;
                    adr1.accountID = txtaccID.Text;
                    adr1.contectName = txt_contectName.Text;
                    adr1.companyName = txt_companyName.Text;
                    adr1.addressLn1 = txt_addrLn1.Text;
                    adr1.addressLn2 = txt_addrLn2.Text;
                    adr1.addressLn3 = txt_addrLn3.Text;
                    adr1.region = txt_region.Text;
                    adr1.postcode = posCode;
                    adr1.phoneNo = txt_phoneNo.Text;
                    adr1.faxNo = txt_faxNo.Text;
                    adr1.telexNo = txt_telexNo.Text;

                    context.SaveChanges();
                };


                MessageBox.Show("Booking Info Update Successful");
            }
            // Add the package information to DataGridView
            ReloadDataGrid();
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var editPackageForm = new EditPackageStaff();
            editPackageForm.Show();
            this.Hide();
        }

        private void toolStripDestinationbtn_Click(object sender, EventArgs e)
        {
            var destinationForm = new EditDestinationStaff();
            destinationForm.Show();
            this.Hide();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            menu.Show();
            this.Close();
        }
    }
}



