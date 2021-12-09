using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDEapp
{
    
    public partial class EDEapp_PaymentRecord : Form
    {
        public static string Paymentid;
        paymentrecord payrecord1 = new paymentrecord();
        public static string CIP = "";

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
        public EDEapp_PaymentRecord()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu mainMenu = new EDEapp_MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void EDEapp_PaymentRecord_Load(object sender, EventArgs e)
        {
            showpaymentrecord();
        }

        private void combo_paymentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_date_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void showpaymentrecord()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            this.combo_paymentID.Items.Clear();
            using (var paymentrecord = new edeaccountEntities())
            {
                var payment1 = (from list in paymentrecord.paymentrecord
                                where list.accountID == Login.log_user
                                select list);

                foreach (var payment2 in payment1.ToList())
                {
                    dataGridView1.Rows.Add(payment2.paymentID, payment2.payDateTime.ToString("yyyy-MM-dd HH-mm"), payment2.payValue, "Detail", payment2.payMethod);
                   // if (!combo_paymentID.Items.Contains(payment2.paymentID))
                   // { 
                    combo_paymentID.Items.Add(payment2.paymentID);
                   // }
                if (!combo_value.Items.Contains(payment2.payValue))
                    {
                        combo_value.Items.Add(payment2.payValue);
                    }
                }
            }
        }

        private void combo_value_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            using (var paymentrecord = new edeaccountEntities())
            {
                var payment1 = (from list in paymentrecord.paymentrecord
                                where list.accountID == Login.log_user
                                where list.payValue.ToString() == combo_value.Text
                                select list);
                foreach (var payment2 in payment1.ToList())
                {
                    dataGridView1.Rows.Add(payment2.paymentID, payment2.payDateTime.ToString("yyyy-MM-dd HH-mm"), payment2.payValue, "Detail", payment2.payMethod);
                }
            }
        }

        private void combo_paymentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            using (var paymentrecord = new edeaccountEntities())
            {
                var payment1 = (from list in paymentrecord.paymentrecord
                                where list.accountID == Login.log_user
                                where list.paymentID == combo_paymentID.Text
                                select list);
                foreach (var payment2 in payment1.ToList())
                {
                    dataGridView1.Rows.Add(payment2.paymentID, payment2.payDateTime.ToString("yyyy-MM-dd HH-mm"), payment2.payValue, "Detail", payment2.payMethod);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            using (edeaccountEntities datasearch = new edeaccountEntities())
            {
                //var paymentrecordsearch = datasearch.paymentrecord.Where(i => i.paymentID.Contains(txt_paymentID.Text) || i.payDateTime == dateTime_date.Value);
                var paymentrecordsearch = (from list in datasearch.paymentrecord
                                           where list.payDateTime >= date_from.Value && list.payDateTime <= date_to.Value
                                           where list.paymentID.Contains(txt_paymentID.Text)
                                           select list);
                foreach (var paymentrecordsearch2 in paymentrecordsearch.ToList())
                {
                    dataGridView1.Rows.Add(paymentrecordsearch2.paymentID, paymentrecordsearch2.payDateTime.ToString("yyyy-MM-dd HH-mm"), paymentrecordsearch2.payValue, "Detail",paymentrecordsearch2.payMethod);
                }
            }
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
           combo_paymentID.SelectedIndex = -1;
           combo_value.SelectedIndex = -1;
            using (edeaccountEntities datasearch = new edeaccountEntities())
            {
                paymentrecord checkpayment = datasearch.paymentrecord.FirstOrDefault(x => x.accountID == Login.log_user);
                //var checkpayment = datasearch.paymentrecord.Where(i => i.accountID == Login.log_user);


                if (checkpayment != null)
                {
                    showpaymentrecord();
                }
                else
                {
                    MessageBox.Show("You Dont Have Any Payment Record");
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Detail")
            {
                payrecord1.paymentID = Convert.ToString(dataGridView1.CurrentRow.Cells["PaymentID"].Value);
                if (MessageBox.Show("Are You Sure Want To See This Payment Detail?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Paymentid= payrecord1.paymentID;
                    PaymentRecordDetailsCreditCard paymentRecord = new PaymentRecordDetailsCreditCard();
                    paymentRecord.Show();
                }
            }
        }

        private void txt_paymentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_paymentID_TextChanged(object sender, EventArgs e)
        {
            txt_paymentID.MaxLength = 12;
        }
    }
}
