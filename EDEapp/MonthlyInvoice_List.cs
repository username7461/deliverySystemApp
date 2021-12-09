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
    public partial class MonthlyInvoice_List : Form
    {
        private String log_user;

        public MonthlyInvoice_List()
        {
            InitializeComponent();

            /* TEST ONLY */
            // log_user = "c778825698";
            /* TEST ONLY */

            // Initialize Variable
            log_user = Login.log_user;

            // Initialize DataGridView
            dgv_list.ColumnCount = 5;
            dgv_list.Columns[0].HeaderText = "Invoice ID";
            dgv_list.Columns[1].HeaderText = "Start Date";
            dgv_list.Columns[2].HeaderText = "End Date";
            dgv_list.Columns[3].HeaderText = "Value";
            dgv_list.Columns[4].HeaderText = "Payment Status";
            dgv_list.AllowUserToAddRows = false;
            dgv_list.ReadOnly = true;
            dgv_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Initialize ComboBox
            cb_status.Text = "Select...";
            cb_status.Items.Add("All");
            cb_status.Items.Add("Unpaid");
            cb_status.Items.Add("Paid");
        }

        private void MonthlyInvoice_List_Load(object sender, EventArgs e)
        {
            refreshDGV(-1);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            this.Close();
            menu.Show();
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_status.SelectedIndex)
            {
                case 0:
                    dgv_list.Rows.Clear();
                    refreshDGV(-1);
                    break;
                case 1:
                    dgv_list.Rows.Clear();
                    refreshDGV(0);
                    break;
                case 2:
                    dgv_list.Rows.Clear();
                    refreshDGV(1);
                    break;
            }
        }

        private void cb_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgv_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MonthlyInvoice_Report report = new MonthlyInvoice_Report(dgv_list.SelectedCells[0].Value.ToString());
            report.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            cb_status.Text = "Select...";
            
            // Clear the data in DataGridView
            dgv_list.Rows.Clear();

            using(var monInvList = new edeaccountEntities())
            {
                var mInv = (from list in monInvList.consolidatemonthlyinvoice
                            where list.accountID == log_user
                            where list.invoiceID.Contains(txt_search.Text)
                            select new
                            {
                                list.invoiceID,
                                list.startDate,
                                list.endDate,
                                list.value,
                                list.isPay
                            });

                foreach (var mInv2 in mInv.ToList())
                {
                    string status = "";

                    switch (mInv2.isPay)
                    {
                        case 0:
                            status = "Unpaid";
                            break;
                        case 1:
                            status = "Paid";
                            break;
                        default:
                            break;
                    }
                    dgv_list.Rows.Add(mInv2.invoiceID, mInv2.startDate.ToString("yyyy-MM-dd"), mInv2.endDate.ToString("yyyy-MM-dd"), mInv2.value.ToString("$ #,###.##"), status);
                }
                foreach (DataGridViewColumn c in dgv_list.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
                }
            }
            // Change DataGridView row color to green if the payment status is "Paid"
            for (int i = 0; i < dgv_list.RowCount; i++)
            {
                if (dgv_list.Rows[i].Cells[4].Value == "Paid")
                    dgv_list.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                else
                    dgv_list.Rows[i].DefaultCellStyle.BackColor = Color.Silver;
            }
        }

        private void refreshDGV(int payStatus)
        {
            using (var monInvList = new edeaccountEntities())
            {
                if (payStatus == -1)
                {
                    var mInv = (from list in monInvList.consolidatemonthlyinvoice
                                where list.accountID == log_user
                                select new
                                {
                                    list.invoiceID,
                                    list.startDate,
                                    list.endDate,
                                    list.value,
                                    list.isPay
                                });

                    foreach (var mInv2 in mInv.ToList())
                    {
                        string status = "";

                        switch (mInv2.isPay)
                        {
                            case 0:
                                status = "Unpaid";
                                break;
                            case 1:
                                status = "Paid";
                                break;
                            default:
                                break;
                        }
                        dgv_list.Rows.Add(mInv2.invoiceID, mInv2.startDate.ToString("yyyy-MM-dd"), mInv2.endDate.ToString("yyyy-MM-dd"), mInv2.value.ToString("$ #,###.##"), status);
                    }
                    foreach (DataGridViewColumn c in dgv_list.Columns)
                    {
                        c.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
                    }
                }
                else
                {
                    var mInv = (from list in monInvList.consolidatemonthlyinvoice
                                where list.accountID == log_user && list.isPay == payStatus
                                select new
                                {
                                    list.invoiceID,
                                    list.startDate,
                                    list.endDate,
                                    list.value,
                                    list.isPay
                                });

                    foreach (var mInv2 in mInv.ToList())
                    {
                        string status = "";

                        switch (mInv2.isPay)
                        {
                            case 0:
                                status = "Unpaid";
                                break;
                            case 1:
                                status = "Paid";
                                break;
                            default:
                                break;
                        }
                        dgv_list.Rows.Add(mInv2.invoiceID, mInv2.startDate.ToString("yyyy-MM-dd"), mInv2.endDate.ToString("yyyy-MM-dd"), mInv2.value.ToString("$ #,###.##"), status);
                    }
                    foreach (DataGridViewColumn c in dgv_list.Columns)
                    {
                        c.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
                    }
                }
            }
            // Change DataGridView row color to green if the payment status is "Paid"
            for (int i = 0; i < dgv_list.RowCount; i++)
            {
                if (dgv_list.Rows[i].Cells[4].Value == "Paid")
                    dgv_list.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                else
                    dgv_list.Rows[i].DefaultCellStyle.BackColor = Color.Silver;
            }
            dgv_list.ClearSelection();
        }

        private void tsb_cInv_Click(object sender, EventArgs e)
        {
            CommercialInvoice_List cList = new CommercialInvoice_List();
            cList.Show();
            this.Close();
        }

        private void tsb_iInv_Click(object sender, EventArgs e)
        {
            ImportInvoice_List iList = new ImportInvoice_List();
            iList.Show();
            this.Close();
        }
    }
}
