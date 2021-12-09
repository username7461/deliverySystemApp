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
    public partial class EditDeliveryStatus : Form
    {
        package pkg1 = new package();
        edeaccountEntities db = new edeaccountEntities();
        prealertrecord alert = new prealertrecord();
        public EditDeliveryStatus()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].HeaderText = "packageID";
            dataGridView1.Columns[1].HeaderText = "accID";
            dataGridView1.Columns[2].HeaderText = "bookingID";
            dataGridView1.Columns[3].HeaderText = "Package Name";
            dataGridView1.Columns[4].HeaderText = "isImport";
            dataGridView1.Columns[5].HeaderText = "Status";
            dataGridView1.Columns[6].HeaderText = "Confirmed ?";
            dataGridView1.Columns[7].HeaderText = "Customer Confirmed?";
            dataGridView1.Columns[8].HeaderText = "Location";
            dataGridView1.Columns[9].HeaderText = "Last Updated";

            cbStatus.Items.Add("Booking order received, Waiting for pickup");
            cbStatus.Items.Add("Waiting for Measure");
            cbStatus.Items.Add("Waiting for Shipping");
            cbStatus.Items.Add("Shipping in progress");
            cbStatus.Items.Add("Shipment arrived, waiting for pickup");
            cbStatus.Items.Add("Shipment collected by delivery staff. Now delivering to destination");
            cbStatus.Items.Add("The shipment arrived the destination");
            cbStatus.Items.Add("Confirmed");

            btn_cancel.Enabled = false;
            btn_edit.Enabled = false;
            btn_edit.Enabled = false;

            chkConfirmDelivered.Enabled = false;
            chkIsImport.Enabled = false;
        }
        private void EditPackageStaff_Load(object sender, EventArgs e)
        {
            ReloadDataGrid();
        }
        void ReloadDataGrid()
        {
            dataGridView1.Rows.Clear();
            using (var content = new edeaccountEntities())
            {
                var package = (from r in content.packages select r);
                foreach (var adb2 in package.ToList())
                {
                    var status = adb2.status;
                    switch (status)
                    {
                        case "0":
                            status = "Booking order received, Waiting for pickup";
                            break;
                        case "1":
                            status = "Waiting for Measure";
                            break;
                        case "2":
                            status = "Waiting for Shipping";
                            break;
                        case "3":
                            status = "Shipping in progress";
                            break;
                        case "4":
                            status = "Shipment arrived, waiting for pickup";
                            break;
                        case "5":
                            status = "Shipment collected by delivery staff. Now delivering to destination";
                            break;
                        case "6":
                            status = "The shipment arrived the destination";
                            break;
                        case "7":
                            status = "Confirmed";
                            break;
                    }
                    String confirmByStaff = Convert.ToString(adb2.isComplete);
                    if (confirmByStaff == "1")
                    {
                        confirmByStaff = "True";
                    }
                    else
                    {
                        confirmByStaff = "False";
                    }


                    dataGridView1.Rows.Add(adb2.packageID, adb2.accID, adb2.bookingID,
                        adb2.pkgName, adb2.isImport, status, confirmByStaff, adb2.cusConfirm, adb2.location, adb2.statusTime);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ResetAllControls(this);
            btn_edit.Enabled = false;
            btn_cancel.Enabled = false;
            txtaccID.Enabled = true;
            txtbookingID.Enabled = true;
            txtpkgID.Enabled = true;
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

        // To Load a datafrom dataGrid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                pkg1.packageID = Convert.ToString(dataGridView1.CurrentRow.Cells["Column1"].Value);

                using (edeaccountEntities ede = new edeaccountEntities())
                {
                    pkg1 = ede.packages.Where(x => x.packageID == pkg1.packageID).FirstOrDefault();
                    txtpkgID.Text = pkg1.packageID;
                    txtaccID.Text = pkg1.accID;
                    txtbookingID.Text = pkg1.bookingID;
                    txtpkgName.Text = pkg1.pkgName;

                    if (pkg1.isImport)
                    {
                        chkIsImport.Checked = true;
                    }
                    else
                    {
                        chkIsImport.Checked = false;
                    }

                    if (pkg1.isComplete == 1)
                    {
                        chkConfirmDelivered.Checked = true;
                    }
                    else
                    {
                        chkConfirmDelivered.Checked = false;
                    }

                    if (pkg1.status != null)
                        cbStatus.SelectedIndex = Convert.ToInt32(pkg1.status);

                    txtLocation.Text = pkg1.location;
                }
                btn_edit.Enabled = true;
                btn_cancel.Enabled = true;
                btn_edit.Enabled = true;
                txtaccID.Enabled = false;
                txtbookingID.Enabled = false;
                txtpkgID.Enabled = false;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Boolean pkgInfoComplete = true;

            if (txtpkgName.Text.Trim() == "")
            {
                MessageBox.Show("Please input the package name.");
                pkgInfoComplete = false;
            }
            if (txtLocation.Text.Trim() == "")
            {
                MessageBox.Show("Please input the address.");
                pkgInfoComplete = false;
            }

            if (pkgInfoComplete)
            {

                using (edeaccountEntities context = new edeaccountEntities())
                {
                    pkg1 = context.packages.Where(x => x.packageID == pkg1.packageID).FirstOrDefault();

                    pkg1.pkgName = txtpkgName.Text;

                    if (chkConfirmDelivered.Checked) { pkg1.isComplete = 1; } else { pkg1.isComplete = 0; }

                    if (chkIsImport.Checked) { pkg1.isImport = true; } else { pkg1.isImport = false; }

                    pkg1.location = txtLocation.Text;

                    pkg1.statusTime = DateTime.Now;

                    if (pkg1.status != Convert.ToString(cbStatus.SelectedIndex))
                    {
                        pkg1.status = Convert.ToString(cbStatus.SelectedIndex);

                        var status = pkg1.status;
                        switch (status)
                        {
                            case "0":
                                status = "Booking order received, Waiting for pickup";
                                break;
                            case "1":
                                status = "Waiting for Measure";
                                break;
                            case "2":
                                status = "Waiting for Shipping";
                                break;
                            case "3":
                                status = "Shipping in progress";
                                break;
                            case "4":
                                status = "Shipment arrived, waiting for pickup";
                                break;
                            case "5":
                                status = "Shipment collected by delivery staff. Now delivering to destination";
                                break;
                            case "6":
                                status = "The shipment arrived the destination";
                                break;
                            case "7":
                                status = "Confirmed";
                                break;
                        }
                        status = status + " Location: " + pkg1.location;

                        prealertrecord a = new prealertrecord
                        {
                            accID = pkg1.accID,
                            packageID = pkg1.packageID,
                            statusID = Convert.ToInt32(pkg1.status),
                            isRead = 0,
                            message = status,
                            pkgName = pkg1.pkgName,
                            timeUpdated = DateTime.Now
                        };
                        context.prealertrecord.Add(a);
                    }
                    context.SaveChanges();
                };





                MessageBox.Show("Status Info Update Successful");
                ReloadDataGrid();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e) { }

        private void toolStripBookingbtn_Click(object sender, EventArgs e)
        {
            var bookForm = new EditBookingStaff();
            bookForm.Show();
            this.Hide();
        }

        private void toolStripDestinationbtn_Click(object sender, EventArgs e)
        {
            var destinationForm = new EditDestinationStaff();
            destinationForm.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            Login.editAirwayBillStaff.Show();
            this.Hide();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            menu.Show();
            this.Close();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            using (edeaccountEntities ede = new edeaccountEntities())
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();

                var list = ede.packages.Where(i =>
                i.accID.Contains(txtSearch.Text) ||
                i.bookingID.Contains(txtSearch.Text) ||
                i.packageID.Contains(txtSearch.Text) ||
                i.pkgName.Contains(txtSearch.Text) ||
                i.isImport.ToString().Contains(txtSearch.Text) ||
                i.isComplete.ToString().Contains(txtSearch.Text) ||
                i.status.Contains(txtSearch.Text) ||
                i.location.Contains(txtSearch.Text) ||
                i.statusTime.ToString().Contains(txtSearch.Text)
                );

                foreach (var adb2 in list.ToList())
                {
                    var status = adb2.status;
                    switch (status)
                    {
                        case "0":
                            status = "Booking order received, Waiting for pickup";
                            break;
                        case "1":
                            status = "Waiting for Measure";
                            break;
                        case "2":
                            status = "Waiting for Shipping";
                            break;
                        case "3":
                            status = "Shipping in progress";
                            break;
                        case "4":
                            status = "Shipment arrived, waiting for pickup";
                            break;
                        case "5":
                            status = "Shipment collected by delivery staff. Now delivering to destination";
                            break;
                        case "6":
                            status = "The shipment arrived the destination";
                            break;
                        case "7":
                            status = "Confirmed";
                            break;
                    }
                    String confirmByStaff = Convert.ToString(adb2.isComplete);
                    if (confirmByStaff == "1")
                    {
                        confirmByStaff = "True";
                    }
                    else
                    {
                        confirmByStaff = "False";
                    }

                    dataGridView1.Rows.Add(adb2.packageID, adb2.accID, adb2.bookingID,
                            adb2.pkgName, adb2.isImport, status, confirmByStaff, adb2.cusConfirm, adb2.location, adb2.statusTime);
                }
            }
        }

        private void tsb_airwaybill_Click(object sender, EventArgs e)
        {
            EditAirwayBillStaff editAirwaybill = new EditAirwayBillStaff();
            editAirwaybill.Show();
            this.Hide();
        }
    }
}



