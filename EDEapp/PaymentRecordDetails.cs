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
    public partial class PaymentRecordDetailsCreditCard : Form
    {
        public PaymentRecordDetailsCreditCard()
        {
            InitializeComponent();
        }

        private void PaymentRecordDetails_Load(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                paymentrecord record = content.paymentrecord.SingleOrDefault(i => i.paymentID == EDEapp_PaymentRecord.Paymentid && i.payMethod == "Credit Card");

                if (record != null) 
                { 
                    showdetailcreditcard();
                }
                else
                {
                    showdetailcashandcheque();
                }
            }
        }

        private void showdetailcreditcard()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Columns["CentreName"].Visible = false;
            dataGridView1.Columns["HandleBy"].Visible = false;
            using (var paymentrecord = new edeaccountEntities())
            {
                var record1 = (from list in paymentrecord.paymentrecord
                               join c in paymentrecord.creditcard on list.accountID equals c.accountID
                               where list.payMethod == "Credit Card"
                               where list.paymentID == EDEapp_PaymentRecord.Paymentid
                               where list.cardID == c.cardID
                                select new
                                {
                                    c.cardNo,
                                    list.payMethod,
                                    c.cardType
                                }
                                );
                foreach (var record in record1.ToList())
                {
                    dataGridView1.Rows.Add(record.payMethod,record.cardType,record.cardNo);
                }
            }
        }
        private void showdetailcashandcheque()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Columns["cardType"].Visible = false;
            dataGridView1.Columns["cardNo"].Visible = false;
            using (var paymentrecord = new edeaccountEntities())
            {
                var record1 = (from list in paymentrecord.paymentrecord
                               join c in paymentrecord.creditcard on list.accountID equals c.accountID
                               join st in paymentrecord.staff on list.stfID equals st.accountID
                               join centre1 in paymentrecord.centre on list.centreID equals centre1.centreID
                               where list.payMethod == "Cash" || list.payMethod == "Cheque"
                               //where list.payMethod == "Cheque"
                               where list.paymentID == EDEapp_PaymentRecord.Paymentid
                               select new
                               {
                                    list.payMethod,
                                    list.stfID,
                                    centre1.name
                               }
                               );
                foreach (var record in record1.ToList())
                {
                    dataGridView1.Rows.Add(record.payMethod,"","",record.name,record.stfID);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length - 4) + e.Value.ToString().Substring(e.Value.ToString().Length - 4); ;
            }
        }
    }
}
