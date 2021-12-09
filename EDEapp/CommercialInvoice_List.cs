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
    public partial class CommercialInvoice_List : Form
    {
        static string log_user;

        public static package pkg;
        public static airwaybill awb;

        public CommercialInvoice_List()
        {
            InitializeComponent();
            log_user = Login.log_user;
            btn_print.Enabled = false;

            constructDataGridView();
        }

        private void constructDataGridView()
        {
            dgv_commercialInvoiceList.ColumnCount = 3;
            dgv_commercialInvoiceList.Columns[0].Name = "Invoice ID";
            dgv_commercialInvoiceList.Columns[1].Name = "Package Name";
            dgv_commercialInvoiceList.Columns[2].Name = "Total Value";

            dgv_commercialInvoiceList.AllowUserToAddRows = false;
            dgv_commercialInvoiceList.ReadOnly = true;
            dgv_commercialInvoiceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_commercialInvoiceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            addRows();
        }

        private void addRows()
        {
            dgv_commercialInvoiceList.Rows.Clear();
            using (var database = new edeaccountEntities())
            {
                var cInvoice = (from list in database.commercialinvoices
                                where list.accountID == log_user
                                select list);

                foreach (var cInvoice2 in cInvoice.ToList())
                {
                    pkg = database.packages.SingleOrDefault(i => i.packageID == cInvoice2.packageID);
                    dgv_commercialInvoiceList.Rows.Add(cInvoice2.invoiceID, pkg.pkgName, cInvoice2.totalValue);
                }
                foreach (DataGridViewColumn c in dgv_commercialInvoiceList.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
                }
            }
            dgv_commercialInvoiceList.ClearSelection();
        }

        private string invoiceID;
        private string bookingID;
        private void dgv_commercialInvoiceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (edeaccountEntities db = new edeaccountEntities())
            {
                invoiceID = dgv_commercialInvoiceList.Rows[e.RowIndex].Cells[0].Value.ToString();
                commercialinvoice comI = db.commercialinvoices.SingleOrDefault(i => i.invoiceID == invoiceID);
                package pkg = db.packages.SingleOrDefault(i => i.packageID == comI.packageID);
                bookingID = pkg.bookingID;
            }
            btn_print.Enabled = true;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            CommercialInvoice_Preview preview = new CommercialInvoice_Preview(invoiceID, bookingID);
            preview.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            menu.Show();
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_commercialInvoiceList.Rows.Clear();

            using(var comInvList = new edeaccountEntities())
            {
                var cInv = (from list in comInvList.commercialinvoices
                            join pk in comInvList.packages on list.packageID equals pk.packageID
                            where list.accountID == log_user
                            where list.invoiceID.Contains(txt_search.Text)
                            select new { 
                                list.invoiceID,
                                pk.pkgName,
                                list.totalValue
                            });

                foreach(var cInv2 in cInv.ToList())
                {
                    dgv_commercialInvoiceList.Rows.Add(cInv2.invoiceID, cInv2.pkgName, cInv2.totalValue);
                }
            }
            dgv_commercialInvoiceList.ClearSelection();
            btn_print.Enabled = false;
        }

        private void tsb_mInv_Click(object sender, EventArgs e)
        {
            MonthlyInvoice_List mList = new MonthlyInvoice_List();
            mList.Show();
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
