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
    public partial class PayCash : Form
    {
        consolidatemonthlyinvoice comsolid = new consolidatemonthlyinvoice();
        public PayCash()
        {
            InitializeComponent();
        }

        private void PayCash_Load(object sender, EventArgs e)
        {
            loadInvoiceID();
            dgv_invoiceList.AllowUserToAddRows = false;
            dgv_invoiceList.ReadOnly = true;
            dgv_invoiceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_invoiceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_invoiceList.AutoGenerateColumns = false;
        }

        private void loadInvoiceID()
        {
            dgv_invoiceList.Rows.Clear();
            using (var invoiceID = new edeaccountEntities())
            {
                var invoicelist = (from list in invoiceID.consolidatemonthlyinvoice
                                   where list.isPay == 0
                                   select list);

                foreach (var item in invoicelist)
                {
                    dgv_invoiceList.Rows.Add(item.invoiceID, item.accountID, item.value.ToString("$ #,###.##"), item.startDate.ToString("yyyy-MM-dd HH:mm:ss"), item.endDate.ToString("yyyy-MM-dd HH:mm:ss"), "Pay");
                    dgv_invoiceList.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_invoiceList.Columns[e.ColumnIndex].Name == "Pay")
            {
                comsolid.invoiceID = Convert.ToString(dgv_invoiceList.CurrentRow.Cells["invoiceID"].Value);
                if (MessageBox.Show("Really Pay?", "Pay?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                        
                    using (edeaccountEntities content = new edeaccountEntities())
                    {
                        consolidatemonthlyinvoice comsolidate = content.consolidatemonthlyinvoice.SingleOrDefault(i => i.invoiceID == comsolid.invoiceID);
                        if(comsolidate!=null)
                        {
                            comsolidate.isPay = 1;
                            content.SaveChanges();
                            MessageBox.Show("Pay successful!");
                        }
                    }
                    txt_search.Text = "";
                    loadInvoiceID();
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu main = new EDEapp_MainMenu();
            main.Show();
            this.Hide();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_invoiceList.Rows.Clear();
            using (var db = new edeaccountEntities())
            {
                var monInv = (from list in db.consolidatemonthlyinvoice
                              where list.accountID.Contains(txt_search.Text)
                              where list.isPay == 0
                              select list);
                foreach(var item in monInv.ToList())
                {
                    dgv_invoiceList.Rows.Add(item.invoiceID, item.accountID, item.value.ToString("$ #,###.##"), item.startDate.ToString("yyyy-MM-dd HH:mm:ss"), item.endDate.ToString("yyyy-MM-dd HH:mm:ss"), "Pay");
                    dgv_invoiceList.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
                }
            }
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txt_search.Text = "";
            }
        }
    }
}
