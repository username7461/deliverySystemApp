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
    public partial class CreditcardRecord : Form
    {
        creditcard cardrecord1 = new creditcard();
        public CreditcardRecord()
        {
            InitializeComponent();
        }

        private void CreditcardRecord_Load(object sender, EventArgs e)
        {
            if(Payment.cardselect=="Visa")
            {
                visa();
            }
            else
            {
                master();
            }
        }
        private void visa()
        {
            using (var cardrecord = new edeaccountEntities())
            {
                var record1 = (from list in cardrecord.creditcard
                               where list.cardType == "Visa"
                               where list.accountID == Login.log_user
                               select list);
                foreach (var record in record1.ToList())
                {
                    //string result = record.cardNo.Substring(record.cardNo.Length - 4).PadLeft(record.cardNo.Length, '*');
                    dataGridView1.Rows.Add("", record.cardNo, record.expiryDate.ToString("MM/yyyy"), record.holderName, "Select");
                }
            }
        }
        private void master()
        {
            using (var cardrecord = new edeaccountEntities())
            {
                var record1 = (from list in cardrecord.creditcard
                               where list.cardType == "Master"
                               where list.accountID == Login.log_user
                               select list);
                foreach (var record in record1.ToList())
                {
                    //string result = record.cardNo.Substring(record.cardNo.Length - 4).PadLeft(record.cardNo.Length, '*');
                    dataGridView1.Rows.Add("",record.cardNo, record.expiryDate.ToString("MM/yyyy"), record.holderName, "Select");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Select")
            {
                cardrecord1.cardID = Convert.ToString(dataGridView1.CurrentRow.Cells["cardID"].Value);
                if (MessageBox.Show("Are You Sure Want To Select This Card To Do Payment?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Payment p = new Payment();
                    List<string> list = new List<string>();
                    Payment.savecardNo = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    Payment.saveexpirydate = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    Payment.saveholderName = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    //savecardNo = cardrecord1.cardNo;
                    // saveexpirydate = cardrecord1.expiryDate;
                    //saveholderName = cardrecord1.holderName;

                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length - 4) + e.Value.ToString().Substring(e.Value.ToString().Length - 4); ;
            }
        }
    }
}
