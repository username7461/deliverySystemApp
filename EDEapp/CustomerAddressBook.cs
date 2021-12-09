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

namespace EDEapp
{
    public partial class CustomerAddressBook : Form
    {
        private string randomCode;
        addressbook adb1 = new addressbook();
        public CustomerAddressBook()
        {
            InitializeComponent();
            //customeraddressbook = new edeaccountEntities();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerAddressBook_Load(object sender, EventArgs e)
        {
            comboBox_region.Items.Add("Hong Kong");
            comboBox_region.Items.Add("Australia");
            comboBox_region.Items.Add("Japan");
            comboBox_region.Items.Add("China Shanghai");
            Clear();
            reloaddatagrid();

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Regex namevalid = new Regex("^[a-zA-Z]*$");
            Regex addressvalid = new Regex("^[a-zA-Z0-9]*$");
            Regex numbervalid = new Regex(@"^(?=.*?[0-9]).{1,20}$");
            Regex faxvalid = new Regex(@"^(?=.*?[0-9]).{8,8}$");
            Regex televalid = new Regex(@"^(?=.*?[0-9]).{8,12}$");
            bool nameValid = namevalid.IsMatch(txt_ContentName.Text.Trim());
            bool addressValid = addressvalid.IsMatch(txt_Address1.Text.Trim());
            bool addressValid2 = addressvalid.IsMatch(txt_Address2.Text.Trim());
            bool addressValid3 = addressvalid.IsMatch(txt_Address3.Text.Trim());
            bool postcodeValid = numbervalid.IsMatch(txt_postcode.Text.Trim());
            bool faxNoValid = faxvalid.IsMatch(txt_faxNo.Text.Trim());
            bool teleValid = televalid.IsMatch(txt_telexNo.Text.Trim());
            if (txt_ContentName.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide ContentName");
            }
            else if (!nameValid)
            {
                MessageBox.Show("Contect Name is InValid");
            }
            else if (txt_Address1.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide Address");
            }
            else if (!addressValid)
            {
                MessageBox.Show("Address Is InValid");
            }
            else if (txt_Address2.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide Address");
            }
            else if (!addressValid2)
            {
                MessageBox.Show("Address Is InValid");
            }
            else if (txt_Address3.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide Address");
            }
            else if (!addressValid3)
            {
                MessageBox.Show("Address Is InValid");
            }
            else if (txt_postcode.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide postcode");
            }
            else if (!postcodeValid)
            {
                MessageBox.Show("Postcode Is InValid");
            }
            else if (txt_faxNo.Text.Trim() !="" && !faxNoValid)
            {
                MessageBox.Show("FaxNo Is InValid");
            }
            else if (txt_telexNo.Text.Trim() !="" && teleValid)
            {
                MessageBox.Show("Telephone Is InValid");
            }
            else if (comboBox_region.SelectedIndex == -1)
            {
                MessageBox.Show("Region should be select");
            }
            else
            {
                using (edeaccountEntities content = new edeaccountEntities())
                {
                    Random rand = new Random();
                    randomCode = (rand.Next(999999999)).ToString();
                    addressbook adb = new addressbook
                    {
                        addressId = "a" + randomCode,
                        contectName = txt_ContentName.Text,
                        companyName = txt_CompanyName.Text,
                        addressLn1 = txt_Address1.Text,
                        addressLn2 = txt_Address2.Text,
                        addressLn3 = txt_Address3.Text,
                        region = comboBox_region.GetItemText(comboBox_region.SelectedItem),
                        postcode = txt_postcode.Text,
                        phoneNo = txt_phoneNo.Text,
                        faxNo = txt_faxNo.Text,
                        accountID = Login.log_user,
                        telexNo = txt_telexNo.Text,

                    };
                    MessageBox.Show("AddressBook is added");
                    content.addressbook.Add(adb);
                    content.SaveChanges();
                    Clear();
                    reloaddatagrid();

                }
                
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                adb1.addressId = Convert.ToString(dataGridView1.CurrentRow.Cells["addressId"].Value);
                using (edeaccountEntities ede = new edeaccountEntities())
                {
                    adb1 = ede.addressbook.Where(x => x.addressId == adb1.addressId).FirstOrDefault();
                    txt_ContentName.Text = adb1.contectName;
                    txt_CompanyName.Text = adb1.companyName;
                    txt_Address1.Text = adb1.addressLn1;
                    txt_Address2.Text = adb1.addressLn2;
                    txt_Address3.Text = adb1.addressLn3;
                    comboBox_region.SelectedItem = adb1.region;
                    txt_postcode.Text = adb1.postcode;
                    txt_phoneNo.Text = adb1.phoneNo; 
                    txt_faxNo.Text = adb1.faxNo;
                    txt_telexNo.Text = adb1.telexNo;
                }
                btn_delete.Enabled = true;
                btn_edit.Enabled = true;
                btn_add.Enabled = false;
            }
        }
        //void PopulateDataGridView()
        //{
         //   using (var customeraddress = new edeaccountEntities())
        //    {
         //       var adb = (from list in customeraddress.addressbook
         //                  where list.accountID == Login.log_user
         //                  select list);

         //       // select * from employees

         //       foreach (var adb2 in adb.ToList())
         //       {
         //           dataGridView1.Rows.Add(adb2.addressId, adb2.contectName, adb2.companyName, adb2.addressLn1, adb2.addressLn2, adb2.addressLn3,adb2.region,adb2.postcode, adb2.phoneNo, adb2.faxNo);

         //       }
         //   }

     //   }

        void Clear()
        {
            txt_ContentName.Text = txt_CompanyName.Text = txt_Address1.Text = txt_Address2.Text = txt_Address3.Text = txt_faxNo.Text = txt_phoneNo.Text = txt_postcode.Text = txt_telexNo.Text = "";
            comboBox_region.SelectedIndex = -1;
            btn_add.Text = "Add";
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_add.Enabled = true;
            adb1.addressId = Convert.ToString(0);
        }
        void reloaddatagrid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            using (var customeraddress = new edeaccountEntities())
            {
                var adb = (from list in customeraddress.addressbook
                           where list.accountID == Login.log_user
                           select list);

                foreach (var adb2 in adb.ToList())
                {

                    dataGridView1.Rows.Add(adb2.addressId, adb2.contectName, adb2.companyName, adb2.addressLn1, adb2.addressLn2, adb2.addressLn3, adb2.region,adb2.postcode, adb2.phoneNo, adb2.faxNo,adb2.telexNo);

                }
            }

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
                    reloaddatagrid();
                    Clear();
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Regex namevalid = new Regex("^[a-zA-Z]*$");
            Regex addressvalid = new Regex("^[a-zA-Z0-9]*$");
            Regex numbervalid = new Regex(@"^(?=.*?[0-9]).{1,20}$");
            Regex faxvalid = new Regex(@"^(?=.*?[0-9]).{8,8}$");
            bool nameValid = namevalid.IsMatch(txt_ContentName.Text.Trim());
            bool addressValid = addressvalid.IsMatch(txt_Address1.Text.Trim());
            bool addressValid2 = addressvalid.IsMatch(txt_Address2.Text.Trim());
            bool addressValid3 = addressvalid.IsMatch(txt_Address3.Text.Trim());
            bool postcodeValid = numbervalid.IsMatch(txt_postcode.Text.Trim());
            bool faxNoValid = faxvalid.IsMatch(txt_faxNo.Text.Trim());
            if (txt_ContentName.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide ContentName");
            }
            else if (!nameValid)
            {
                MessageBox.Show("Contect Name is InValid");
            }
            else if (txt_Address1.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide Address");
            }
            else if (!addressValid)
            {
                MessageBox.Show("address is InValid");
            }
            else if (txt_Address2.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide Address");
            }
            else if (!addressValid2)
            {
                MessageBox.Show("address is InValid");
            }
            else if (txt_Address3.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide Address");
            }
            else if (!addressValid3)
            {
                MessageBox.Show("address is InValid");
            }
            else if (txt_postcode.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide postcode");
            }
            else if (!postcodeValid)
            {
                MessageBox.Show("postcode is InValid");
            }
            else if (txt_faxNo.Text.Trim() != "" && !faxNoValid)
            {
                MessageBox.Show("faxNo is InValid");
            }
            else
            {
                adb1.addressId = Convert.ToString(dataGridView1.CurrentRow.Cells["addressId"].Value);
                using (edeaccountEntities content = new edeaccountEntities())
                {
                    addressbook cs = content.addressbook.SingleOrDefault(i => i.addressId == adb1.addressId);
                    if (cs != null) 
                    {
                        cs.contectName = txt_ContentName.Text;
                        cs.companyName = txt_CompanyName.Text;
                        cs.addressLn1 = txt_Address1.Text;
                        cs.addressLn2 = txt_Address2.Text;
                        cs.addressLn3 = txt_Address3.Text;
                        cs.region = comboBox_region.GetItemText(comboBox_region.SelectedItem);
                        cs.faxNo = txt_faxNo.Text;
                        cs.postcode = txt_postcode.Text;
                        cs.phoneNo = txt_phoneNo.Text;
                        cs.telexNo = txt_telexNo.Text;
                        content.SaveChanges();
                        MessageBox.Show("address has been edit!");
                        Clear();
                        reloaddatagrid();
                    }

                }
            }
        }

        private void txt_Address3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Address1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_ContentName.Text = "";
            txt_CompanyName.Text = "";
            txt_Address1.Text = "";
            txt_Address2.Text = "";
            txt_Address3.Text = "";
            comboBox_region.SelectedIndex = -1;
            txt_postcode.Text = "";
            txt_phoneNo.Text = "";
            txt_faxNo.Text = "";
            txt_telexNo.Text = "";
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
        }

        private void comboBox_region_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu main = new EDEapp_MainMenu();
            main.Show();
            this.Hide();
        }

        private void txt_faxNo_TextChanged(object sender, EventArgs e)
        {
            txt_faxNo.MaxLength = 8;
        }

        private void txt_telexNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_faxNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_phoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_postcode_TextChanged(object sender, EventArgs e)
        {
            txt_postcode.MaxLength = 12;
        }

        private void txt_postcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_phoneNo_TextChanged(object sender, EventArgs e)
        {
            txt_phoneNo.MaxLength = 12;
        }

        private void txt_telexNo_TextChanged(object sender, EventArgs e)
        {
            txt_telexNo.MaxLength = 12;
        }
    }
}
