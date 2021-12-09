using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDEapp
{
    public partial class ViewStaffAccount : Form
    {
        staff sf = new staff();
        jobtitle jb = new jobtitle();
        centre centre = new centre();
        public static string CIP = "";
        public static string log_user;
        public static string jobID;
        public static string centreID;
        public static bool statuscheck;
        public static string staffemailexist;
        public void getIP()  // get customer IP
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    CIP = ip.ToString();
                }
            }
        }
        public ViewStaffAccount()
        {
            InitializeComponent();
        }

        private void CreateAndManageStaffAccount_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("0");
            comboBox1.Items.Add("1");
            //ViewStaff();
        }

        void ViewStaff()
        {
            txt_accountID.Text = "";
            txt_email.Text = "";
            txt_FirstName.Text = "";
            txt_lastName.Text = "";
            txt_jobName.Text = "";
            txt_centreName.Text = "";
            txt_phoneNo.Text = "";
            comboBox1.SelectedIndex = -1;
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            using (var staffaccount = new edeaccountEntities())
            {
                var sta = (from list in staffaccount.staff
                           join j in staffaccount.jobtitle on list.jobID equals j.jobID
                           join c in staffaccount.centre on list.centreID equals c.centreID
                           select new
                           {
                               j.jobName,
                               c.name,
                               list.accountID,
                               list.firstName,
                               list.lastName,
                               list.email,
                               list.phoneNo,
                               list.status
                           }
                           );

                foreach (var sta2 in sta.ToList())
                {
                    dataGridView1.Rows.Add(sta2.accountID, sta2.firstName, sta2.lastName, sta2.email, sta2.phoneNo, sta2.jobName, sta2.name, sta2.status, "Edit");
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            using (edeaccountEntities ede = new edeaccountEntities())
            {
                var list = (from list2 in ede.staff
                            join j in ede.jobtitle on list2.jobID equals j.jobID
                            join c in ede.centre on list2.centreID equals c.centreID
                            where list2.accountID.Contains(txt_accountID.Text)
                            where list2.firstName.Contains(txt_FirstName.Text)
                            where list2.lastName.Contains(txt_lastName.Text)
                            where list2.email.Contains(txt_email.Text)
                            where list2.phoneNo.Contains(txt_phoneNo.Text)
                            where j.jobName.Contains(txt_jobName.Text)
                            where c.name.Contains(txt_centreName.Text)
                            where list2.status == comboBox1.SelectedIndex
                            select new
                            {
                                j.jobName,
                                c.name,
                                list2.accountID,
                                list2.firstName,
                                list2.lastName,
                                list2.email,
                                list2.phoneNo,
                                list2.status
                            });
                foreach (var serach2 in list.ToList())
                {
                    dataGridView1.Rows.Add(serach2.accountID, serach2.firstName, serach2.lastName, serach2.email, serach2.phoneNo, serach2.jobName, serach2.name, serach2.status, "Edit");
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_ViewALL_Click(object sender, EventArgs e)
        {
            ViewStaff();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {

                sf.accountID = Convert.ToString(dataGridView1.CurrentRow.Cells["accountID"].Value);
                jb.jobName = Convert.ToString(dataGridView1.CurrentRow.Cells["jobName"].Value);
                centre.name = Convert.ToString(dataGridView1.CurrentRow.Cells["centreName"].Value);
                sf.email = Convert.ToString(dataGridView1.CurrentRow.Cells["email"].Value);
                if (MessageBox.Show("Are you sure want to edit this account information?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    staffemailexist = sf.email;
                    log_user = sf.accountID;
                    jobID = jb.jobName;
                    centreID = centre.name;
                    if (sf.status == 1)
                    {
                        statuscheck = true;
                    }
                    else
                    {
                        statuscheck = false;
                    }
                    EditStaffAccount staffedit = new EditStaffAccount();
                    staffedit.Show();
                    this.Hide();
                }
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu main = new EDEapp_MainMenu();
            main.Show();
            this.Hide();
        }
    }
}
