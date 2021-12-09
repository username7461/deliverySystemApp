using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDEapp
{
    public partial class ManageCentreInformation : Form
    {
        centre cen1 = new centre();
        public ManageCentreInformation()
        {
            InitializeComponent();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddNewCentre_Load(object sender, EventArgs e)
        {
            combo_region.Items.Add("Hong Kong");
            combo_region.Items.Add("Australia");
            combo_region.Items.Add("Japan");
            combo_region.Items.Add("China Shanghai");
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            showallcentre();
        }

        private void showallcentre()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            using (var centreinfo = new edeaccountEntities())
            {
                var cen1 = (from list in centreinfo.centre
                            select list);

                foreach (var cen2 in cen1.ToList())
                {
                    dataGridView1.Rows.Add(cen2.centreID, cen2.name, cen2.address, cen2.region);
                }
            }
            txt_centreID.Text = "";
            txt_centreName.Text = "";
            txt_address.Text = "";
            combo_region.SelectedIndex = -1;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool checkcentreexist = false;
            bool checkcentreIDexist = false;
            if (txt_centreName.Text.Trim() == "")
            {
                MessageBox.Show("You Should Provide the Centre Name");
            }
            else if (txt_centreID.Text.Trim() == "")
            {
                MessageBox.Show("You Should Provide the Centre ID");
            }
            else if (txt_address.Text.Trim() == "")
            {
                MessageBox.Show("You Should Provide the Centre address");
            }
            else if (combo_region.SelectedIndex == -1)
            {
                MessageBox.Show("You Should Choose the Centre Region");
            }
            else
            {
                using (var centrecheck = new edeaccountEntities())
                {
                    var centre1 = (from list in centrecheck.centre
                                   select list
                                   );
                    var centrename = (from list in centrecheck.centre
                                      select list
                                  );
                    foreach (var centrename2 in centrename.ToList())
                    {
                        if (centrename2.centreID == txt_centreID.Text)
                        {
                            checkcentreIDexist = true;
                            break;
                        }
                    }
                    foreach (var centre2 in centre1.ToList())
                    {

                        if (centre2.name == txt_centreName.Text)
                        {
                            checkcentreexist = true;
                            break;
                        }
                    }
                }
                if (checkcentreIDexist)
                {
                    MessageBox.Show("Centre ID exist");
                }
                else if (checkcentreexist)
                {
                    MessageBox.Show("Centre name exist");
                }
                else
                {
                    using (edeaccountEntities content = new edeaccountEntities())
                    {

                        centre cen = new centre
                        {
                            centreID = txt_centreID.Text,
                            name = txt_centreName.Text,
                            address = txt_address.Text,
                            region = combo_region.GetItemText(combo_region.SelectedItem)
                        };
                        MessageBox.Show("create centre successful!");
                        content.centre.Add(cen);
                        content.SaveChanges();
                    }
                    showallcentre();
                }

            }
        }
    


        private void txt_centreName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            bool checkcentreexist = false;
            if (txt_centreName.Text.Trim() == "")
            {
                MessageBox.Show("You Should Provide the Centre Name");
            }
            else if (txt_address.Text.Trim() == "")
            {
                MessageBox.Show("You Should Provide the Centre address");
            }
            else if (combo_region.SelectedIndex == -1)
            {
                MessageBox.Show("You Should Choose the Centre Region");
            }
            else
            {
                using (var centrecheck = new edeaccountEntities())
                {
                    var centre1 = (from list in centrecheck.centre
                                   where list.name !=cen1.name
                                   select list
                                   );
                    foreach (var centre2 in centre1.ToList())
                    {

                        if (centre2.name == txt_centreName.Text)
                        {
                            checkcentreexist = true;
                            break;
                        }
                    }
                }

                if(checkcentreexist)
                {
                    MessageBox.Show("Centre Name Exist");
                }
                else
                { 
                    cen1.centreID = Convert.ToString(dataGridView1.CurrentRow.Cells["centreID"].Value);
                    using (edeaccountEntities content = new edeaccountEntities())
                    {
                        centre editcentre = content.centre.SingleOrDefault(i => i.centreID == cen1.centreID);
                        if (editcentre != null)
                        {
                            editcentre.centreID = txt_centreID.Text;
                            editcentre.name = txt_centreName.Text;
                            editcentre.address = txt_address.Text;
                            editcentre.region = combo_region.GetItemText(combo_region.SelectedItem);
                            MessageBox.Show("Centre edit successful!");
                            content.SaveChanges();
                            showallcentre();
                        } 
                    }
                }

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_centreID.Text = "";
            txt_centreName.Text = "";
            txt_address.Text = "";
            combo_region.SelectedIndex = -1;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            btn_add.Enabled = true;
            txt_centreID.Enabled = true;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                cen1.centreID = Convert.ToString(dataGridView1.CurrentRow.Cells["centreID"].Value);
                using (edeaccountEntities ede = new edeaccountEntities())
                {
                    cen1 = ede.centre.Where(i => i.centreID == cen1.centreID).FirstOrDefault();
                    txt_centreID.Text = cen1.centreID;
                    txt_centreName.Text = cen1.name;
                    txt_address.Text = cen1.address;
                    combo_region.SelectedItem = cen1.region;
                }
                btn_delete.Enabled = true;
                btn_edit.Enabled = true;
                btn_add.Enabled = false;
                txt_centreID.Enabled = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Delete this Centre? ", "Delete Address?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (edeaccountEntities customeraddressbook = new edeaccountEntities())
                {
                    var entry = customeraddressbook.Entry(cen1);
                    if (entry.State == EntityState.Detached)
                        customeraddressbook.centre.Attach(cen1);
                    customeraddressbook.centre.Remove(cen1);
                    customeraddressbook.SaveChanges();
                    MessageBox.Show("centre delete");
                    showallcentre();
                }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu main = new EDEapp_MainMenu();
            main.Show();
            this.Hide();
        }

        private void txt_centreID_TextChanged(object sender, EventArgs e)
        {
            txt_centreID.MaxLength = 3;

        }

        private void txt_centreID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
