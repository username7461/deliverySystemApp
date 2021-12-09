using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace EDEapp
{
    public partial class Logging : Form
    {
        edeaccountEntities logging;
        public Logging()
        {

            InitializeComponent();
            logging = new edeaccountEntities();
        }

        private void Logging_Load(object sender, EventArgs e)
        {
            txt_search.Enabled = false;
            checkSystemLog();
            // dataGridView1.DataSource = logging.customerlogging.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            txt_search.Enabled = false;
            checkSystemLog();
            logging.SaveChanges();
            MessageBox.Show("Date Refresh");
        }
        void checkSystemLog()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            using (var custlog = new edeaccountEntities())
            {
                var log = (from list in custlog.log
                           select list);

                // select * from employees

                foreach (var log2 in log.ToList())
                {

                    dataGridView1.Rows.Add(log2.accountID, log2.actionPerformed, log2.times.Value.ToString("yyyy-MM-dd HH:mm:ss"), log2.ipAddress);

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

            using (edeaccountEntities ede = new edeaccountEntities())
            {
                var list = ede.log.Where(i => i.accountID.Contains(txt_search.Text) || i.actionPerformed.Contains(txt_search.Text) || i.ipAddress.Contains(txt_search.Text)|| i.times.Value.ToString().Contains(txt_search.Text));
                
                foreach (var log2 in list.ToList())
                {
                    if(log2.times > date_from.Value && log2.times < date_to.Value)
                    { 
                        dataGridView1.Rows.Add(log2.accountID, log2.actionPerformed, log2.times.Value.ToString("yyyy-MM-dd HH:mm:ss"), log2.ipAddress);
                    }
                }
            }
        }

        private void btn_serach_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            using (edeaccountEntities datasearch = new edeaccountEntities())
            {
                var result = (from list in datasearch.log
                              where list.times >= date_from.Value && list.times <= date_to.Value
                              select list );
                foreach (var log2 in result.ToList())
                {
                    dataGridView1.Rows.Add(log2.accountID, log2.actionPerformed, log2.times.Value.ToString("yyyy-MM-dd HH:mm:ss"), log2.ipAddress);
                }
                txt_search.Enabled = true;
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
