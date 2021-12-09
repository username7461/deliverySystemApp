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
    public partial class EditAirwayBillStaff : Form
    {
        public static string typeOfGoods;
        public static string destinatedCountry;

        // ***Useless*** bookingorder.accID is the receiver address
        // package.accID is the destination

        package pkg1 = new package();
        airwaybill ab1 = new airwaybill();
        edeaccountEntities db = new edeaccountEntities();
        addressbook adr1 = new addressbook();

        public static TextBox txtLength;
        public static TextBox txtWidth;
        public static TextBox txtHeight;
        public static TextBox txtWeight;
        public static TextBox txtExpense;
        public EditAirwayBillStaff()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            this.dataGridView1.AllowUserToAddRows = false;

            txtLength = txt_length;
            txtWidth = txt_width;
            txtHeight = txt_height;
            txtWeight = txt_weight;
            txtExpense = txt_expense;

            dataGridView1.Columns[0].HeaderText = "accountID";
            dataGridView1.Columns[1].HeaderText = "bookingID";
            dataGridView1.Columns[2].HeaderText = "packageID";
            dataGridView1.Columns[3].HeaderText = "Package Name";
            dataGridView1.Columns[4].HeaderText = "Destination";
            dataGridView1.Columns[5].HeaderText = "Dimension lxwxh (cm)";
            dataGridView1.Columns[6].HeaderText = "Weight (kg)";
            dataGridView1.Columns[7].HeaderText = "Expense";
            dataGridView1.Columns[8].HeaderText = "Package Type";
            dataGridView1.Columns[9].HeaderText = "Region";
            btn_cancel.Enabled = false;
            btn_edit.Enabled = false;
            btn_edit.Enabled = false;
            btn_calculateExpenses.Enabled = false;
            btn_printAirway.Enabled = false;
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
                address = address.addressLn1 + " " + address.addressLn2 + " " + address.addressLn3,
                dimension = package.length + " x " + package.width + " x " + package.height,
                weight = package.weight,
                expense = package.expense,

                type = package.packageType,
                region = address.region
            }



            )
                .ToList();



                foreach (var db in data)
                {
                    dataGridView1.Rows.Add(
                    db.accID,
                    db.bookId,
                    db.packageID,
                    db.packageName,
                    db.address,
                    db.dimension,
                    db.weight,
                    db.expense,
                    db.type,
                    db.region
                         );
                }
            }
            if (txt_length.Text != "" || txt_width.Text != "" ||
            txt_height.Text != "" ||
            txt_weight.Text != "" ||
            txt_expense.Text != "")
            {
                btn_printAirway.Enabled = true;
            }
            else
            {
                btn_printAirway.Enabled = false;
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
            txt_length.Text = "";
            txt_width.Text = "";
            txt_height.Text = "";
            txt_width.Text = "";
            txt_expense.Text = "";
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
                    txt_address.Text = adr1.addressLn1 + " " + adr1.addressLn2 + " " + adr1.addressLn3;

                    txt_length.Text = Convert.ToString(pkg1.length);
                    txt_width.Text = Convert.ToString(pkg1.width);
                    txt_height.Text = Convert.ToString(pkg1.height);
                    txt_weight.Text = Convert.ToString(pkg1.weight);
                    txt_expense.Text = Convert.ToString(pkg1.expense);
                    typeOfGoods = Convert.ToString(pkg1.packageType);
                    destinatedCountry = Convert.ToString(adr1.region);
                }
                btn_edit.Enabled = true;
                btn_cancel.Enabled = true;
                btn_edit.Enabled = true;
                btn_calculateExpenses.Enabled = true;

                if (txt_length.Text != "" || txt_width.Text != "" ||
                    txt_height.Text != "" ||
                    txt_weight.Text != "" ||
                    txt_expense.Text != "")
                {
                    btn_printAirway.Enabled = true;
                }
                else
                {
                    btn_printAirway.Enabled = false;
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            Boolean isCompleted = true;

            if (txt_length.Text == "" || txt_width.Text == "" ||
            txt_height.Text == "" ||
            txt_weight.Text == "" ||
            txt_expense.Text == "")
            {
                isCompleted = false;
                MessageBox.Show("Please calculate the expense first");
            }

            // Create package
            if (isCompleted == true)
            {
                using (edeaccountEntities context = new edeaccountEntities())
                {
                    pkg1 = context.packages.Where(x => x.packageID == pkg1.packageID).FirstOrDefault();
                    adr1 = context.addressbook.Where(x => x.addressId == pkg1.addrID).FirstOrDefault();

                    pkg1.length = Convert.ToDouble(txt_length.Text);
                    pkg1.width = Convert.ToDouble(txt_width.Text);
                    pkg1.height = Convert.ToDouble(txt_height.Text);
                    pkg1.weight = Convert.ToDouble(txt_weight.Text);
                    pkg1.expense = Convert.ToDouble(txt_expense.Text);

                    context.SaveChanges();
                    MessageBox.Show("Record update successful");
                }
                // Add the package information to DataGridView
                ReloadDataGrid();
            }
        }

        private void btn_printAirway_Click(object sender, EventArgs e)
        {
            AirwayBill_Print awbPrint = new AirwayBill_Print(txtpkgID.Text, Double.Parse(txt_length.Text), Double.Parse(txt_width.Text), Double.Parse(txt_height.Text), Double.Parse(txt_weight.Text));
            awbPrint.ShowDialog();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            menu.Show();
            this.Close();
        }

        private void btn_calculateExpenses_Click(object sender, EventArgs e)
        {
            var calc = new AirwayBillExpenseCalculator();
            calc.ShowDialog();
        }

        private void tsb_pkgStatus_Click(object sender, EventArgs e)
        {
            EditDeliveryStatus editDelivery = new EditDeliveryStatus();
            editDelivery.Show();
            this.Hide();
        }
    }
}


