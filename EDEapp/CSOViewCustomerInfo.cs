using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EDEapp
{
    public partial class CSOViewCustomerInfo : Form
    {
        customer cs = new customer();
        
        public static string log_user;
        public static string useremail;
        public CSOViewCustomerInfo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                cs.email = Convert.ToString(dataGridView1.CurrentRow.Cells["email"].Value);
                cs.accountID = Convert.ToString(dataGridView1.CurrentRow.Cells["accountID"].Value);
                if (MessageBox.Show("Are you sure want to edit this account information?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    useremail = cs.email;
                    log_user = cs.accountID;
                    CSOEditCustomerInfo csoedc = new CSOEditCustomerInfo();
                    csoedc.Show();
                    this.Hide();
                }
            }
        }

        private void CSOEditCustomerInformation_Load(object sender, EventArgs e)
        {
            viewCustomerInfo();
        }
        void viewCustomerInfo()
        {
            using (var customeraccount = new edeaccountEntities())
            {
                var csa = (from list in customeraccount.customer
                           select list);

                // select * from employees

                foreach (var csa2 in csa.ToList())
                {
                    dataGridView1.Rows.Add(csa2.accountID, csa2.firstName, csa2.lastName, csa2.email, csa2.phoneNo, csa2.status, csa2.credibility, "Edit");
                }
            }
        }
        void ReviewCustomerInfo()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            using (var customeraccount = new edeaccountEntities())
            {
                var csa = (from list in customeraccount.customer
                           select list);

                // select * from employees

                foreach (var csa2 in csa.ToList())
                {

                    dataGridView1.Rows.Add(csa2.accountID, csa2.firstName, csa2.lastName, csa2.email, csa2.phoneNo, csa2.status, csa2.credibility, "Edit");
                }
               
            }
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

            using (edeaccountEntities ede = new edeaccountEntities())
            {
                var list = ede.customer.Where(i => i.accountID.Contains(txt_search.Text)|| i.firstName.Contains(txt_search.Text)||i.lastName.Contains(txt_search.Text)||i.email.Contains(txt_search.Text)||i.phoneNo.Contains(txt_search.Text)||i.credibility.ToString().Contains(txt_search.Text));

                foreach (var csa2 in list.ToList())
                {
                    dataGridView1.Rows.Add(csa2.accountID, csa2.firstName, csa2.lastName, csa2.email, csa2.phoneNo, csa2.status, csa2.credibility, "Edit");
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
