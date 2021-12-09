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
    public partial class CheckNotifications : Form
    {
        public CheckNotifications()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].HeaderText = "PackageID";
            dataGridView1.Columns[1].HeaderText = "Package Name";
            dataGridView1.Columns[2].HeaderText = "Message";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "Time Updated:";
        }

        private void CheckNotifications_Load(object sender, EventArgs e)
        {
            label1.AutoSize = false;
            label1.Height = 2;
            label1.BorderStyle = BorderStyle.Fixed3D;

            ReloadDataGrid();
        }
        void ReloadDataGrid()
        {
            dataGridView1.Rows.Clear();
            using (var content = new edeaccountEntities())
            {
                var alert = (from r in content.prealertrecord
                             where r.accID == Login.log_user
                             select r);

                foreach (var adb2 in alert.ToList())
                {
                    dataGridView1.Rows.Add(adb2.packageID, adb2.pkgName, adb2.message, adb2.isRead, adb2.messageID, adb2.timeUpdated);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EDEapp_MainMenu().Show();
        }


        prealertrecord al = new prealertrecord();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                al.messageID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column5"].Value);
                using (edeaccountEntities context = new edeaccountEntities())
                {
                    prealertrecord del = context.prealertrecord.Find(al.messageID);
                    context.prealertrecord.Remove(del);
                    context.SaveChanges();
                }
                // Show the package create successful message
                MessageBox.Show("Package record deleted");
                ReloadDataGrid();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int isRead = Convert.ToInt32(row.Cells[3].Value);
                if (isRead == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Coral;
                    //row.DefaultCellStyle.ForeColor = Color.Gray;
                }
            }
        }
        prealertrecord alert = new prealertrecord();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void btnReadAll_Click(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                var alert = (from r in content.prealertrecord
                             where r.accID == Login.log_user && r.isRead==0
                             select r);

                foreach (var adb2 in alert.ToList())
                {
                    if (adb2.isRead == 0)
                    {
                        adb2.isRead = 1;
                    }
                }
                content.SaveChanges();
            }
            ReloadDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                alert.messageID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column5"].Value);
                using (edeaccountEntities ede = new edeaccountEntities())
                {
                    prealertrecord al = ede.prealertrecord.SingleOrDefault(x => x.messageID == alert.messageID);
                    if (al != null)
                    {
                        al.isRead = 1;
                    };
                    ede.SaveChanges();
                }
                ReloadDataGrid();
            }
        }
    }
}

