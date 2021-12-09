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
    public partial class BookingImportOrder_02 : Form
    {
        public static package[] pkgList = new package[100];
        static string log_user;

        public BookingImportOrder_02()
        {
            InitializeComponent();
            log_user = Login.log_user;
            dgv_pkgList.AllowUserToAddRows = false;
            dgv_pkgList.Columns[0].HeaderText = "Package Name";
            dgv_pkgList.Columns[1].HeaderText = "Quantity";
            dgv_pkgList.Columns[2].HeaderText = "Unit";
            dgv_pkgList.Columns[3].HeaderText = "Unit Value";
            dgv_pkgList.Columns[4].HeaderText = "Package Type";
            dgv_pkgList.Columns[5].HeaderText = "Service Type";
            dgv_pkgList.Columns[6].HeaderText = "Remark";
            dgv_pkgList.AllowUserToResizeRows = false;
            dgv_pkgList.AllowUserToResizeColumns = true;
            dgv_pkgList.ClearSelection();
            txt_totalValue.Text = "$ 0.00";
            btn_pkgAdd.Enabled = true;
            btn_pkgUpdate.Enabled = false;
            btn_pkgEdit.Enabled = false;
            btn_pkgDelete.Enabled = false;
            cb_serviceType.Enabled = false;
            lbl_message.Text = "";
        }

        private void btn_pkgAdd_Click(object sender, EventArgs e)
        {
            String pkgTypeName = null;
            String pkgServiceTypeName = null;
            Boolean pkgInfoComplete = true;

            if (txt_pkgName.Text.Trim() == "")
            {
                // MessageBox.Show("Please input the package name.");
                lbl_message.Text = "Please input the package name.";
                lbl_message.ForeColor = Color.Red;
                pkgInfoComplete = false;
            }
            else if (txt_pkgQty.Text.Trim() == "")
            {
                lbl_message.Text = "Please input the quantity.";
                lbl_message.ForeColor = Color.Red;
                pkgInfoComplete = false;
            }
            else if (txt_pkgUnit.Text.Trim() == "")
            {
                lbl_message.Text = "Please input the unit.";
                lbl_message.ForeColor = Color.Red;
                pkgInfoComplete = false;
            }
            else if (txt_unitValue.Text.Trim() == "")
            {
                // MessageBox.Show("Please input the unit value.");
                lbl_message.Text = "Please input the unit value.";
                lbl_message.ForeColor = Color.Red;
                pkgInfoComplete = false;
            }
            else if (rad_pkgTypeEnvelope.Checked == false && rad_pkgTypeFreight.Checked == false)
            {
                // MessageBox.Show("Please select the package type.");
                lbl_message.Text = "Please select the package type.";
                lbl_message.ForeColor = Color.Red;
                pkgInfoComplete = false;
            }
            else
            {
                pkgServiceTypeName = pkgServiceTypeNameFind();
                if (pkgServiceTypeName == null)
                {
                    // MessageBox.Show("Please select service type.");
                    lbl_message.Text = "Please select service type.";
                    lbl_message.ForeColor = Color.Red;
                    pkgInfoComplete = false;
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
                pkg.pkgName = txt_pkgName.Text;
                pkg.qty = int.Parse(txt_pkgQty.Text);
                pkg.unit = txt_pkgUnit.Text;
                pkg.unitValue = double.Parse(txt_unitValue.Text);
                pkg.packageType = pkgTypeName;
                pkg.serviceType = pkgServiceTypeName;
                pkg.remark = txt_pkgRemark.Text;

                // Add the package information to DataGridView
                pkgList[dgv_pkgList.RowCount] = pkg;
                dgv_pkgList.Rows.Add(pkg.pkgName, pkg.qty, pkg.unit, "$ " + pkg.unitValue, pkgTypeName, pkgServiceTypeName, pkg.remark);

                // Show the package create successful message
                // MessageBox.Show("Package Create Successful, Currently package number: " + dgv_pkgList.RowCount);
                lbl_message.Text = pkg.pkgName + " Create Successful.";
                lbl_message.ForeColor = Color.Green;
                clear();
            }
        }

        private void btn_pkgUpdate_Click(object sender, EventArgs e)
        {
            // Update the exist package information
            // The update button need the user selected the package and press the edit button to enable
            int indexRow = dgv_pkgList.CurrentCell.RowIndex;

            pkgList[indexRow].pkgName = txt_pkgName.Text;
            pkgList[indexRow].qty = int.Parse(txt_pkgQty.Text);
            pkgList[indexRow].unit = txt_pkgUnit.Text;
            pkgList[indexRow].unitValue = double.Parse(txt_unitValue.Text);
            if (rad_pkgTypeEnvelope.Checked == true)
                pkgList[indexRow].packageType = "Envelope";
            else if (rad_pkgTypeFreight.Checked == true)
                pkgList[indexRow].packageType = "Freight";
            pkgList[indexRow].serviceType = pkgServiceTypeNameFind();
            pkgList[indexRow].remark = txt_pkgRemark.Text;

            DataGridViewRow newDataRow = dgv_pkgList.Rows[indexRow];
            newDataRow.Cells[0].Value = pkgList[indexRow].pkgName;
            newDataRow.Cells[1].Value = pkgList[indexRow].qty;
            newDataRow.Cells[2].Value = pkgList[indexRow].unit;
            newDataRow.Cells[3].Value = "$" + pkgList[indexRow].unitValue;
            newDataRow.Cells[4].Value = pkgList[indexRow].packageType;
            newDataRow.Cells[5].Value = pkgList[indexRow].serviceType;
            newDataRow.Cells[6].Value = pkgList[indexRow].remark;
            clear();
            btn_pkgAdd.Enabled = true;
            btn_pkgUpdate.Enabled = false;
            dgv_pkgList.Enabled = true;
            lbl_addPackage.Text = "Create Package";
            lbl_message.Text = pkgList[indexRow].pkgName + " Edit Successful.";
            lbl_message.ForeColor = Color.Green;
        }

        private void btn_pkgEdit_Click(object sender, EventArgs e)
        {
            // Select the exist package to edit
            // The edit button need the user selected the package to enable
            txt_pkgName.Text = pkgList[dgv_pkgList.CurrentCell.RowIndex].pkgName;
            txt_pkgQty.Text = pkgList[dgv_pkgList.CurrentCell.RowIndex].qty.ToString();
            txt_pkgUnit.Text = pkgList[dgv_pkgList.CurrentCell.RowIndex].unit;
            txt_unitValue.Text = pkgList[dgv_pkgList.CurrentCell.RowIndex].unitValue.ToString();
            if (pkgList[dgv_pkgList.CurrentCell.RowIndex].packageType == "Envelope")
                rad_pkgTypeEnvelope.Checked = true;
            else
                rad_pkgTypeFreight.Checked = true;
            cb_serviceTypeItemsAdd(pkgList[dgv_pkgList.CurrentCell.RowIndex].packageType);
            cb_serviceType.SelectedIndex = cb_serviceType.FindStringExact(pkgList[dgv_pkgList.CurrentCell.RowIndex].serviceType);
            txt_pkgRemark.Text = pkgList[dgv_pkgList.CurrentCell.RowIndex].remark;
            btn_pkgAdd.Enabled = false;
            btn_pkgUpdate.Enabled = true;
            btn_pkgEdit.Enabled = false;
            btn_pkgDelete.Enabled = false;
            dgv_pkgList.Enabled = false;
            lbl_addPackage.Text = "Edit Package";
        }

        private void btn_pkgDelete_Click(object sender, EventArgs e)
        {
            // Select the exist package to delete
            // The delete button need the user selected the package to enable
            int indexRow = dgv_pkgList.CurrentCell.RowIndex;
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete \"" + pkgList[indexRow].pkgName + "\" package?", "Delete Package", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Delete package
                string deletePkgName = pkgList[indexRow].pkgName;
                for (int i = indexRow; i <= pkgList.Length; i++)
                {
                    if (pkgList[i + 1] != null)
                        pkgList[i] = pkgList[i + 1];
                    else
                        break;
                }
                dgv_pkgList.Rows.RemoveAt(indexRow);
                lbl_message.Text = deletePkgName + "Delete Successful.";
                lbl_message.ForeColor = Color.Green;
            }
            else if (dialogResult == DialogResult.No)
            {
                // Cancel delete package
                return;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            // Goto next page
            if (dgv_pkgList.RowCount > 0)
            {
                BookingImportOrder_03 next = new BookingImportOrder_03();
                next.Show();
                this.Hide();
            }
            else
            {
                // MessageBox.Show("You must add at least one package into the list.");
                lbl_message.Text = "You must add at least one package into the list.";
                lbl_message.ForeColor = Color.Red;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            BookingImportOrder_01 bk1 = new BookingImportOrder_01();
            bk1.Show();
            this.Close();
        }

        private void llb_remarkQA_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("What is this?", llb_remarkQA);
        }

        private void llb_remarkQA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Write anything that be should aware of by our staff during the delivery process. " +
                "\n\nFor example: You can tell should the item be handled in special care OR mention whether the " +
                "package requires extra manpower to deliver.");
        }

        private void dgv_pkgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_pkgEdit.Enabled = true;
            btn_pkgDelete.Enabled = true;
        }

        private void rad_pkgTypeEnvelope_CheckedChanged(object sender, EventArgs e)
        {
            // When the user select the radio button, the combobox items will be change and reset the selected item
            cb_serviceTypeItemsAdd("Envelope");
        }

        private void rad_pkgTypeFreight_CheckedChanged(object sender, EventArgs e)
        {
            // When the user select the radio button, the combobox items will be change and reset the selected item
            cb_serviceTypeItemsAdd("Freight");
        }

        private string pkgServiceTypeNameFind()
        {
            if (rad_pkgTypeEnvelope.Checked == true)
            {
                switch (cb_serviceType.SelectedIndex)
                {
                    case 0:
                        return "Document";
                    case 1:
                        return "Express Document";
                    case 2:
                        return "Domestic";
                    case 3:
                        return "Worldmail (Airmail)";
                    case 4:
                        return "Worldmail (Printed Master)";
                    default:
                        return null;
                }
            }
            else
            {
                switch (cb_serviceType.SelectedIndex)
                {
                    case 0:
                        return "Package Express";
                    case 1:
                        return "Domestic";
                    case 2:
                        return "Worldmail (Airmail)";
                    case 3:
                        return "Worldmail (Printed Master)";
                    default:
                        return null;
                }
            }
        }

        private void cb_serviceTypeItemsAdd(String packageType)
        {
            if (packageType == "Envelope")
            {
                cb_serviceType.Items.Clear();
                cb_serviceType.ResetText();

                cb_serviceType.Enabled = true;
                cb_serviceType.Items.Add("Document");
                cb_serviceType.Items.Add("Express Document");
                cb_serviceType.Items.Add("Domestic");
                cb_serviceType.Items.Add("Worldmail (Airmail)");
                cb_serviceType.Items.Add("Worldmail (Printed Master)");
            }
            else if (packageType == "Freight")
            {
                cb_serviceType.Items.Clear();
                cb_serviceType.ResetText();

                cb_serviceType.Enabled = true;
                cb_serviceType.Items.Add("Package Express");
                cb_serviceType.Items.Add("Domestic");
                cb_serviceType.Items.Add("Worldmail (Airmail)");
                cb_serviceType.Items.Add("Worldmail (Printed Master)");
            }
        }

        private void clear()
        {
            txt_pkgName.Text = "";
            txt_pkgQty.Text = "";
            txt_pkgUnit.Text = "";
            txt_unitValue.Text = "";
            txt_totalValue.Text = "$ 0.00";
            rad_pkgTypeEnvelope.Checked = false;
            rad_pkgTypeFreight.Checked = false;
            cb_serviceType.Items.Clear();
            cb_serviceType.ResetText();
            cb_serviceType.Enabled = false;
            txt_pkgRemark.Text = "";
        }

        private void txt_pkgQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_unitValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Limit the user only can type number and only one dot (.) letter and two number after dot letter
            if (!char.IsControl(e.KeyChar))
            {
                int dotIndex = txt_unitValue.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))
                {
                    if (dotIndex != -1 && dotIndex < txt_unitValue.SelectionStart && txt_unitValue.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else
                    e.Handled = e.KeyChar != '.' || dotIndex != -1 || txt_unitValue.Text.Length == 0 || txt_unitValue.SelectionStart + 2 < txt_unitValue.Text.Length;
            }
        }

        private void txt_pkgQty_TextChanged(object sender, EventArgs e)
        {
            double unitVal = 0.0;
            double quantity = 0.0;

            if (txt_pkgQty.Text != "" && txt_unitValue.Text != "")
            {
                quantity = Convert.ToDouble(txt_pkgQty.Text);
                unitVal = Convert.ToDouble(txt_unitValue.Text);
                txt_totalValue.Text = "$ " + Convert.ToString(quantity * unitVal);
            }
            else
            {
                txt_totalValue.Text = "$ 0.00";
            }
        }

        private void txt_unitValue_TextChanged(object sender, EventArgs e)
        {
            double unitVal = 0.0;
            double quantity = 0.0;

            if (txt_pkgQty.Text != "" && txt_unitValue.Text != "")
            {
                quantity = Convert.ToDouble(txt_pkgQty.Text);
                unitVal = Convert.ToDouble(txt_unitValue.Text);
                txt_totalValue.Text = "$ " + Convert.ToString(quantity * unitVal);
            }
            else
            {
                txt_totalValue.Text = "$ 0.00";
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
