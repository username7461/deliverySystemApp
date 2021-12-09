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
    public partial class ViewAllPackage : Form
    {
        public ViewAllPackage()
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
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu main = new EDEapp_MainMenu();
            main.Show();
            this.Hide();
        }
        void ReloadDataGrid()
        {
            dataGridView1.Rows.Clear();
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

        private void ViewAllPackage_Load(object sender, EventArgs e)
        {
            ReloadDataGrid();
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
    }
}
