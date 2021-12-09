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
    public partial class EditDestinationStaff : Form
    {
        // ***Useless*** bookingorder.accID is the receiver address
        // package.accID is the destination

        package pkg1 = new package();
        addressbook adr1 = new addressbook();
        edeaccountEntities db = new edeaccountEntities();

        public EditDestinationStaff()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].HeaderText = "accountID";
            dataGridView1.Columns[1].HeaderText = "bookingID";
            dataGridView1.Columns[2].HeaderText = "packageID";

            dataGridView1.Columns[3].HeaderText = "Package Name";

            //dataGridView1.Columns[4].HeaderText = "Origin";
            dataGridView1.Columns[4].HeaderText = "Receiver";

            dataGridView1.Columns[5].HeaderText = "Contact Method";

            dataGridView1.Columns[6].HeaderText = "Region";
            dataGridView1.Columns[7].HeaderText = "PostCode";
            dataGridView1.Columns[8].HeaderText = "Company Name";
            dataGridView1.Columns[9].HeaderText = "Address";
            btn_cancel.Enabled = false;
            btn_edit.Enabled = false;
            btn_edit.Enabled = false;
            toolStripDestinationbtn.Enabled = false;
        }

        private void EditPackageStaff_Load(object sender, EventArgs e)
        {
            ReloadDataGrid();
        }

        void ReloadDataGrid()
        {
            dataGridView1.Rows.Clear();
            using (var context = new edeaccountEntities())
            {
                var data = context.packages
            .Join(

            context.addressbook,
            package => package.addrID,
            address => address.addressId,

            (package, address) => new
            {
                accID = package.accID,
                bookId = package.bookingID,
                packageID = package.packageID,

                packageName = package.pkgName,


                receiver = address.contectName,

                contactMethod = "Phone: " + address.phoneNo + " Fax: " + address.faxNo + " Telex: " + address.telexNo,

                region = address.region,
                postcode = address.postcode,

                companyName = address.companyName,
                address = address.addressLn1 + " " + address.addressLn2 + " " + address.addressLn3
            }



            ).ToList();



                foreach (var db in data)
                {
                    dataGridView1.Rows.Add(
                db.accID,
                db.bookId,
                db.packageID,

                db.packageName,


                db.receiver,


                db.contactMethod,
                db.region,
                db.postcode,

                db.companyName,
                db.address
                     );
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

                .packages
                .Join(
                    context.addressbook,
                    package => package.addrID,
                    addressbook => addressbook.addressId,
                    (package, addressbook) => new
                    {
                        Package = package,
                        Address = addressbook
                    })

                .Where(data =>
                data.Package.accID.Contains(txtSearch.Text) ||
                data.Package.bookingID.Contains(txtSearch.Text) ||
                data.Package.packageID.Contains(txtSearch.Text) ||
                data.Package.pkgName.Contains(txtSearch.Text) ||
                data.Address.contectName.Contains(txtSearch.Text) ||
                data.Address.phoneNo.Contains(txtSearch.Text) ||
                data.Address.faxNo.Contains(txtSearch.Text) ||
                data.Address.telexNo.Contains(txtSearch.Text) ||
                data.Address.region.Contains(txtSearch.Text) ||
                data.Address.postcode.Contains(txtSearch.Text) ||
                data.Address.companyName.Contains(txtSearch.Text) ||
                data.Address.addressLn1.Contains(txtSearch.Text) ||
                data.Address.addressLn2.Contains(txtSearch.Text) ||
                data.Address.addressLn3.Contains(txtSearch.Text)
                )
                .ToList();

                foreach (var row in searchData)
                {
                    dataGridView1.Rows.Add(
                     row.Package.accID,
                row.Package.bookingID,
                row.Package.packageID,
                row.Package.pkgName,
                row.Address.contectName,
                $"{row.Address.phoneNo}{row.Address.faxNo}{row.Address.telexNo}",
                row.Address.region,
                row.Address.postcode,
                row.Address.companyName,
                $"{row.Address.addressLn1} {row.Address.addressLn2} {row.Address.addressLn3}"

                        );

                }
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ResetAllControls(this);
            btn_edit.Enabled = false;
            btn_cancel.Enabled = false;
        }

        public void ResetAllControls(Control form)
        {
            txt_companyName.Text = "";
            txt_postcode.Text = "";
            txt_region.Text = "";
            txt_addrLn1.Text = "";
            txt_addrLn2.Text = "";
            txt_addrLn3.Text = "";
            txt_contectName.Text = "";
            txt_phoneNo.Text = "";
            txt_faxNo.Text = "";
            txt_telexNo.Text = "";
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
                pkg1.packageID = Convert.ToString(dataGridView1.CurrentRow.Cells["Column3"].Value);

                using (edeaccountEntities ede = new edeaccountEntities())
                {
                    pkg1 = ede.packages.Where(x => x.packageID == pkg1.packageID).FirstOrDefault();
                    adr1 = ede.addressbook.Where(x => x.addressId == pkg1.addrID).FirstOrDefault();

                    txtaccID.Text = pkg1.accID;
                    txtbookingID.Text = pkg1.bookingID;
                    txtpkgID.Text = pkg1.packageID;
                    txt_pkgName.Text = pkg1.pkgName;
                    txt_companyName.Text = adr1.companyName;
                    txt_postcode.Text = adr1.postcode;
                    txt_region.Text = adr1.region;
                    txt_addrLn1.Text = adr1.addressLn1;
                    txt_addrLn2.Text = adr1.addressLn2;
                    txt_addrLn3.Text = adr1.addressLn3;
                    txt_contectName.Text = adr1.contectName;
                    txt_phoneNo.Text = adr1.phoneNo;
                    txt_faxNo.Text = adr1.faxNo;
                    txt_telexNo.Text = adr1.faxNo;
                }
                btn_edit.Enabled = true;
                btn_cancel.Enabled = true;
                btn_edit.Enabled = true;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            Boolean isCompleted = true;

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


            // Create package
            if (isCompleted == true)
            {
                using (edeaccountEntities context = new edeaccountEntities())
                {

                    pkg1 = context.packages.Where(x => x.packageID == pkg1.packageID).FirstOrDefault();
                    adr1 = context.addressbook.Where(x => x.addressId == pkg1.addrID).FirstOrDefault();

                    String posCode = txt_postcode.Text;
                    if (txt_postcode.Text == "")
                        posCode = "N/A";

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
                    MessageBox.Show("Record update successful");
                }
                // Add the package information to DataGridView
                ReloadDataGrid();
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var editPackageForm = new EditPackageStaff();
            editPackageForm.Show();
            this.Hide();
        }

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


