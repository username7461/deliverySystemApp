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
    public partial class ImportInvoice_List : Form
    {
        private String log_user;

        public ImportInvoice_List()
        {
            InitializeComponent();

            /* TEST ONLY */
            // log_user = "c778825698";
            /* TEST ONLY */

            // Initialize Variable
            log_user = Login.log_user;

            // Initialize ComboBox and Textbox
            cb_searchType.Text = "Select...";
            cb_searchType.Items.Add("Invoice ID");
            cb_searchType.Items.Add("Booking ID");
            txt_search.Text = "";
            txt_search.MaxLength = 10;

            // Initialize DataGridView
            dgv_list.ColumnCount = 5;
            dgv_list.Columns[0].HeaderText = "Invoice ID";
            dgv_list.Columns[1].HeaderText = "Booking ID";
            dgv_list.Columns[2].HeaderText = "Pickup Region";
            dgv_list.Columns[3].HeaderText = "Total Value";
            dgv_list.Columns[4].HeaderText = "Creation Date";
            dgv_list.AllowUserToAddRows = false;
            dgv_list.ReadOnly = true;
            dgv_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ImportInvoice_List_Load(object sender, EventArgs e)
        {
            using(var db = new edeaccountEntities())
            {
                var iInv = (from list in db.importinvoices
                            join addr in db.addressbook on list.pickupAddrID equals addr.addressId
                            where list.accountID == log_user
                            select new
                            {
                                list.invoiceID,
                                list.bookingID,
                                addr.region,
                                list.totalValue,
                                list.creationDate
                            });
                foreach(var iInv2 in iInv.ToList())
                {
                    dgv_list.Rows.Add(iInv2.invoiceID, iInv2.bookingID, iInv2.region, iInv2.totalValue, iInv2.creationDate);
                }
            }
            dgv_list.ClearSelection();
        }

        private void dgv_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ImportInvoice_Report report = new ImportInvoice_Report(dgv_list.SelectedCells[0].Value.ToString());
            report.ShowDialog();
        }

        private void tsb_cInv_Click(object sender, EventArgs e)
        {
            CommercialInvoice_List cList = new CommercialInvoice_List();
            cList.Show();
            this.Close();
        }

        private void tsb_mInv_Click(object sender, EventArgs e)
        {
            MonthlyInvoice_List mList = new MonthlyInvoice_List();
            mList.Show();
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                search();
            }
        }

        private void search()
        {
            dgv_list.Rows.Clear();

            using(var db = new edeaccountEntities())
            {
                if(cb_searchType.SelectedIndex == 0)
                {
                    // Search by Invoice ID
                    var iInv = (from list in db.importinvoices
                                join addr in db.addressbook on list.pickupAddrID equals addr.addressId
                                where list.accountID == log_user
                                where list.invoiceID.Contains(txt_search.Text)
                                select new
                                {
                                    list.invoiceID,
                                    list.bookingID,
                                    addr.region,
                                    list.totalValue,
                                    list.creationDate
                                });
                    foreach (var iInv2 in iInv.ToList())
                    {
                        dgv_list.Rows.Add(iInv2.invoiceID, iInv2.bookingID, iInv2.region, iInv2.totalValue, iInv2.creationDate);
                    }
                }
                else if(cb_searchType.SelectedIndex == 1)
                {
                    // Search by Booking ID
                    var iInv = (from list in db.importinvoices
                                join addr in db.addressbook on list.pickupAddrID equals addr.addressId
                                where list.accountID == log_user
                                where list.bookingID.Contains(txt_search.Text)
                                select new
                                {
                                    list.invoiceID,
                                    list.bookingID,
                                    addr.region,
                                    list.totalValue,
                                    list.creationDate
                                });
                    foreach (var iInv2 in iInv.ToList())
                    {
                        dgv_list.Rows.Add(iInv2.invoiceID, iInv2.bookingID, iInv2.region, iInv2.totalValue, iInv2.creationDate);
                    }
                }
                else
                {
                    // Search by Invoice ID
                    var iInv = (from list in db.importinvoices
                                join addr in db.addressbook on list.pickupAddrID equals addr.addressId
                                where list.accountID == log_user
                                where list.invoiceID.Contains(txt_search.Text)
                                select new
                                {
                                    list.invoiceID,
                                    list.bookingID,
                                    addr.region,
                                    list.totalValue,
                                    list.creationDate
                                });
                    foreach (var iInv2 in iInv.ToList())
                    {
                        dgv_list.Rows.Add(iInv2.invoiceID, iInv2.bookingID, iInv2.region, iInv2.totalValue, iInv2.creationDate);
                    }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
