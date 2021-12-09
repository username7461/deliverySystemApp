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
    public partial class EditPackageStaff : Form
    {
        package pkg1 = new package();
        edeaccountEntities db = new edeaccountEntities();

        public EditPackageStaff()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].HeaderText = "accountID";
            dataGridView1.Columns[1].HeaderText = "bookingID";
            dataGridView1.Columns[2].HeaderText = "packageID";
            dataGridView1.Columns[3].HeaderText = "Package Name";
            dataGridView1.Columns[4].HeaderText = "Package Type";
            dataGridView1.Columns[5].HeaderText = "Service Type";
            dataGridView1.Columns[6].HeaderText = "Quantity";
            dataGridView1.Columns[7].HeaderText = "Unit";
            dataGridView1.Columns[8].HeaderText = "Unit Value";
            dataGridView1.Columns[9].HeaderText = "Remark";
            btn_cancel.Enabled = false;
            btn_edit.Enabled = false;
            cb_serviceType.Enabled = false;
            btn_edit.Enabled = false;
            toolStripPackagebtn.Enabled = false;
        }

        // Add a row record
        private void btn_add_Click(object sender, EventArgs e)
        {
            String pkgTypeName = null;
            String pkgServiceTypeName = null;
            Boolean pkgInfoComplete = true;

            if (txtpkgName.Text.Trim() == "")
            {
                MessageBox.Show("Please input the package name.");
                pkgInfoComplete = false;
            }
            else if (rad_pkgTypeEnvelope.Checked == false && rad_pkgTypeFreight.Checked == false)
            {
                MessageBox.Show("Please select the package type.");
                pkgInfoComplete = false;
            }
            else if (txtUnit.Text.Trim() == "")
            {
                MessageBox.Show("Please input the unit value.");
                pkgInfoComplete = false;
            }
            else
            {
                if (rad_pkgTypeEnvelope.Checked == true)
                {
                    switch (cb_serviceType.Text)
                    {
                        case "Document":
                            pkgServiceTypeName = "Document";
                            break;
                        case "Express Document":
                            pkgServiceTypeName = "Express Document";
                            break;
                        case "Domestic":
                            pkgServiceTypeName = "Domestic";
                            break;
                        case "Worldmail (Airmail)":
                            pkgServiceTypeName = "Worldmail (Airmail)";
                            break;
                        case "Worldmail(Printed Master)":
                            pkgServiceTypeName = "Worldmail (Printed Master)";
                            break;
                        default:
                            pkgInfoComplete = false;
                            MessageBox.Show("Please select the service type.");
                            break;
                    }
                }
                else if (rad_pkgTypeFreight.Checked == true)
                {
                    switch (cb_serviceType.Text)
                    {
                        case "Package Express":
                            pkgServiceTypeName = "Package Express";
                            break;
                        case "Domestic":
                            pkgServiceTypeName = "Domestic";
                            break;
                        case "Worldmail (Airmail)":
                            pkgServiceTypeName = "Worldmail (Airmail)";
                            break;
                        case "Worldmail (Printed Master)":
                            pkgServiceTypeName = "Worldmail (Printed Master)";
                            break;
                        default:
                            pkgInfoComplete = false;
                            MessageBox.Show("Please select the service type.");
                            break;
                    }
                }
            }

            if (rad_pkgTypeEnvelope.Checked == true)
            {
                pkgTypeName = "Envelope";
            }
            else if (rad_pkgTypeFreight.Checked == true)
            {
                pkgTypeName = "Freight";
            }

            // Create package
            if (pkgInfoComplete == true)
            {
                // Create package object to store the information in local variable
                package pkg = new package();

                // accid pkgid bookingid
                pkg.accID = txtaccID.Text;
                pkg.packageID = txtpkgID.Text;
                pkg.bookingID = txtbookingID.Text;
                pkg.pkgName = txtpkgName.Text;
                pkg.qty = int.Parse(txtQuantity.Text);
                pkg.unit = txtUnit.Text;
                pkg.packageType = pkgTypeName;
                pkg.serviceType = pkgServiceTypeName;
                pkg.remark = txt_Remark.Text;
                pkg.unitValue = Convert.ToDouble(txtUnitVal.Text);

                // Add the package information to DataGridView
                dataGridView1.Rows.Add(pkg.accID, pkg.bookingID, pkg.packageID, pkg.pkgName,
                    pkg.packageType, pkg.qty, pkg.unit, pkg.unitValue, pkg.remark);


                // Show the package create successful message


                using (edeaccountEntities context = new edeaccountEntities())
                {
                    package p = new package
                    {
                        // accid pkgid bookingid
                        accID = txtaccID.Text,
                        packageID = txtpkgID.Text,
                        bookingID = txtbookingID.Text,

                        pkgName = txtpkgName.Text,
                        qty = int.Parse(txtQuantity.Text),
                        unit = txtUnit.Text,
                        unitValue = double.Parse(txtUnitVal.Text),
                        packageType = pkgTypeName,
                        serviceType = pkgServiceTypeName,
                        remark = txt_Remark.Text

                    };
                    context.packages.Add(p);

                    try
                    {
                        context.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                    {
                        Exception raise = dbEx;
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                string message = string.Format("{0}:{1}",
                                    validationErrors.Entry.Entity.ToString(),
                                    validationError.ErrorMessage);
                                // raise a new exception nesting
                                // the current instance as InnerException
                                raise = new InvalidOperationException(message, raise);
                            }
                        }
                        throw raise;
                    }
                }

                MessageBox.Show("Package Create Successful, Currently package number: " + dataGridView1.RowCount);
            }


        }
        private void EditPackageStaff_Load(object sender, EventArgs e)
        {
            ReloadDataGrid();
        }
        void ReloadDataGrid()
        {
            dataGridView1.Rows.Clear();
            txtDummyBox.Show();
            using (var content = new edeaccountEntities())
            {
                var package = (from r in content.packages select r);
                foreach (var adb2 in package.ToList())
                {
                    dataGridView1.Rows.Add(adb2.accID, adb2.bookingID, adb2.packageID,
                        adb2.pkgName, adb2.packageType, adb2.serviceType, adb2.qty, adb2.unit, adb2.unitValue, adb2.remark);
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

            using (edeaccountEntities ede = new edeaccountEntities())
            {
                var list = ede.packages.Where(i => i.accID.Contains(txtSearch.Text) ||
                i.bookingID.Contains(txtSearch.Text) ||
                i.packageID.Contains(txtSearch.Text) ||
                i.pkgName.Contains(txtSearch.Text) ||
                i.packageType.Contains(txtSearch.Text) ||
                i.serviceType.Contains(txtSearch.Text) ||
                i.qty.ToString().Contains(txtSearch.Text) ||
                i.unit.Contains(txtSearch.Text) ||
                i.remark.Contains(txtSearch.Text)
                );

                foreach (var adb2 in list.ToList())
                {
                    dataGridView1.Rows.Add(adb2.accID, adb2.bookingID, adb2.packageID,
                        adb2.pkgName, adb2.packageType, adb2.serviceType, adb2.qty, adb2.unit, adb2.unitValue, adb2.remark);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double unitVal = 0;
            double quantity = 0;

            if (txtQuantity.Text != "" && txtUnitVal.Text != "")
            {
                quantity = Convert.ToDouble(txtQuantity.Text);
                unitVal = Convert.ToDouble(txtUnitVal.Text);
                txtTotal.Text = Convert.ToString(quantity * unitVal);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))  //bypass control keys
            {
                int dotIndex = txtUnitVal.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))     //ensure it's a digit
                {   //we cannot accept another digit if
                    if (dotIndex != -1 &&  //there is already a dot and
                                           //dot is to the left from the cursor position and
                        dotIndex < txtUnitVal.SelectionStart &&
                        //there're already 2 symbols to the right from the dot
                        txtUnitVal.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else //we cannot accept this char if
                    e.Handled = e.KeyChar != '.' || //it's not a dot or
                                                    //there is already a dot in the text or
                                dotIndex != -1 ||
                                //text is empty or
                                txtUnitVal.Text.Length == 0 ||
                                //there are more than 2 symbols from cursor position
                                //to the end of the text
                                txtUnitVal.SelectionStart + 2 < txtUnitVal.Text.Length;
            }
        }
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            double unitVal = 0;
            double quantity = 0;

            if (txtQuantity.Text != "" && txtUnitVal.Text != "")
            {
                quantity = Convert.ToDouble(txtQuantity.Text);
                unitVal = Convert.ToDouble(txtUnitVal.Text);
                txtTotal.Text = Convert.ToString(quantity * unitVal);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pkg1.packageID = Convert.ToString(dataGridView1.CurrentRow.Cells["Column3"].Value);
                using (edeaccountEntities context = new edeaccountEntities())
                {
                    package pkDelete = context.packages.Find(pkg1.packageID);
                    context.packages.Remove(pkDelete);
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetAllControls(this);
            txtDummyBox.Show();
        }
        // To Load a datafrom dataGrid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                pkg1.packageID = Convert.ToString(dataGridView1.CurrentRow.Cells["Column3"].Value);

                using (edeaccountEntities ede = new edeaccountEntities())
                {

                    pkg1 = ede.packages.Where(x => x.packageID == pkg1.packageID).FirstOrDefault();

                    txtaccID.Text = pkg1.accID;
                    txtbookingID.Text = pkg1.bookingID;
                    txtpkgID.Text = pkg1.packageID;

                    txtpkgName.Text = pkg1.pkgName;
                    txtUnitVal.Text = Convert.ToString(pkg1.unitValue);

                    if (pkg1.packageType == "Document/ Envelope")
                    { rad_pkgTypeEnvelope.Checked = true; }
                    else
                    { rad_pkgTypeFreight.Checked = true; }
                    cb_serviceType.Text = pkg1.serviceType;
                    txtQuantity.Text = Convert.ToString(pkg1.qty);
                    txtUnit.Text = pkg1.unit;
                    txt_Remark.Text = pkg1.remark;
                }
                btn_delete.Enabled = true;
                btn_edit.Enabled = true;
                btn_add.Enabled = false;
                btn_cancel.Enabled = true;
                btn_edit.Enabled = true;
                txtaccID.Enabled = false;
                txtbookingID.Enabled = false;
                txtpkgID.Enabled = false;
            }
        }
        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void btn_edit_Click(object sender, EventArgs e)
        {
            String pkgTypeName = null;
            String pkgServiceTypeName = null;
            Boolean pkgInfoComplete = true;


            if (txtpkgName.Text.Trim() == "")
            {
                MessageBox.Show("Please input the package name.");
                pkgInfoComplete = false;
            }
            else if (rad_pkgTypeEnvelope.Checked == false && rad_pkgTypeFreight.Checked == false)
            {
                MessageBox.Show("Please select the package type.");
                pkgInfoComplete = false;
            }
            else if (txtUnit.Text.Trim() == "")
            {
                MessageBox.Show("Please input the unit value.");
                pkgInfoComplete = false;
            }
            else
            {
                if (rad_pkgTypeEnvelope.Checked == true)
                {
                    switch (cb_serviceType.Text)
                    {
                        case "Document":
                            pkgServiceTypeName = "Document";
                            break;
                        case "Express Document":
                            pkgServiceTypeName = "Express Document";
                            break;
                        case "Domestic":
                            pkgServiceTypeName = "Domestic";
                            break;
                        case "Worldmail (Airmail)":
                            pkgServiceTypeName = "Worldmail (Airmail)";
                            break;
                        case "Worldmail(Printed Master)":
                            pkgServiceTypeName = "Worldmail (Printed Master)";
                            break;
                        default:
                            MessageBox.Show("Please select the service type.");
                            pkgInfoComplete = false;
                            break;
                    }
                }
                else if (rad_pkgTypeFreight.Checked == true)
                {
                    switch (cb_serviceType.Text)
                    {
                        case "Package Express":
                            pkgServiceTypeName = "Package Express";
                            break;
                        case "Domestic":
                            pkgServiceTypeName = "Domestic";
                            break;
                        case "Worldmail (Airmail)":
                            pkgServiceTypeName = "Worldmail (Airmail)";
                            break;
                        case "Worldmail (Printed Master)":
                            pkgServiceTypeName = "Worldmail (Printed Master)";
                            break;
                        default:
                            pkgInfoComplete = false;
                            MessageBox.Show("Please select the service type.");
                            break;
                    }
                }
            }

            if (rad_pkgTypeEnvelope.Checked == true)
            {
                pkgTypeName = "Envelope";
            }
            else if (rad_pkgTypeFreight.Checked == true)
            {
                pkgTypeName = "Freight";
            }

            // Create package
            if (pkgInfoComplete == true)
            {
                // Create package object to store the information in local variable
                pkg1.packageID = Convert.ToString(dataGridView1.CurrentRow.Cells["Column3"].Value);
                using (edeaccountEntities context = new edeaccountEntities())
                {
                    package pk = context.packages.SingleOrDefault(i => i.packageID == pkg1.packageID);
                    if (pk != null)
                    {
                        pk.pkgName = txtpkgName.Text;
                        pk.qty = int.Parse(txtQuantity.Text);
                        pk.unit = txtUnit.Text;
                        pk.packageType = pkgTypeName;
                        pk.serviceType = pkgServiceTypeName;
                        pk.remark = txt_Remark.Text;
                        pk.unitValue = Convert.ToDouble(txtUnitVal.Text);
                    };
                    context.SaveChanges();
                }
                // Show the package create successful message
                MessageBox.Show("Package Info Update Successful");
                ReloadDataGrid();
            }

        }

        private void rad_pkgTypeFreight_CheckedChanged(object sender, EventArgs e)
        {
            cb_serviceType.Enabled = true;
            cb_serviceType.Items.Clear();
            txtDummyBox.Hide();

            if (rad_pkgTypeFreight.Checked == true)
            {
                cb_serviceType.Items.Add("Package Express");
                cb_serviceType.Items.Add("Domestic");
                cb_serviceType.Items.Add("Worldmail (Airmail)");
                cb_serviceType.Items.Add("Worldmail (Printed Master)");
            }
        }
        private void rad_pkgTypeEnvelope_CheckedChanged(object sender, EventArgs e)
        {
            cb_serviceType.Enabled = true;
            cb_serviceType.Items.Clear();
            txtDummyBox.Hide();

            if (rad_pkgTypeEnvelope.Checked == true)
            {
                cb_serviceType.Items.Add("Document");
                cb_serviceType.Items.Add("Express Document");
                cb_serviceType.Items.Add("Domestic");
                cb_serviceType.Items.Add("Worldmail (Airmail)");
                cb_serviceType.Items.Add("Worldmail (Printed Master)");
            }
        }
        private void txtDummyBox_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Please select an airway type first.", "Warning");
        }
        private void txtDummyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Please select an airway type first.", "Warning");
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

        private void btn_return_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            menu.Show();
            this.Close();
        }
    }
}


