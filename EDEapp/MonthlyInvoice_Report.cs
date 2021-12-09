using DGVPrinterHelper;
using Microsoft.Reporting.WinForms;
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
    public partial class MonthlyInvoice_Report : Form
    {
        String log_user;
        String mInvoiceID;

        public MonthlyInvoice_Report(String mInv)
        {
            InitializeComponent();

            /* TEST ONLY */
            /*log_user = "c778825698";
            mInvoiceID = "M623567091";*/
            /* TEST ONLY */

            log_user = Login.log_user;
            mInvoiceID = mInv;

            // Initialize Buttons and Textbox
            txt_customerName.ReadOnly = true;
            txt_accountID.ReadOnly = true;
            txt_monthlyInvoiceID.ReadOnly = true;
            txt_totalValue.ReadOnly = true;
            txt_startDate.ReadOnly = true;
            txt_endDate.ReadOnly = true;
            btn_paymentStatus.Enabled = false;

            // Initialize DataGridView (View)
            dgv_list.ColumnCount = 7;
            dgv_list.Columns[0].HeaderText = "Invoice ID";
            dgv_list.Columns[1].HeaderText = "Package Name";
            dgv_list.Columns[2].HeaderText = "Package Type";
            dgv_list.Columns[3].HeaderText = "Service Type";
            dgv_list.Columns[4].HeaderText = "Unit Vaule";
            dgv_list.Columns[5].HeaderText = "Weight";
            dgv_list.Columns[6].HeaderText = "Expense";
            dgv_list.AllowUserToAddRows = false;
            dgv_list.ReadOnly = true;
            dgv_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_list.AutoGenerateColumns = false;

            // Initialize DataGridView (Hidden for print only)
            dgv_printList.ColumnCount = 7;
            dgv_printList.Columns[0].HeaderText = "Invoice ID";
            dgv_printList.Columns[1].HeaderText = "Package Name";
            dgv_printList.Columns[2].HeaderText = "Package Type";
            dgv_printList.Columns[3].HeaderText = "Service Type";
            dgv_printList.Columns[4].HeaderText = "Unit Vaule";
            dgv_printList.Columns[5].HeaderText = "Weight";
            dgv_printList.Columns[6].HeaderText = "Expense";
            dgv_printList.AllowUserToAddRows = false;
            dgv_printList.ReadOnly = true;
            dgv_printList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_printList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_printList.AutoGenerateColumns = false;
            dgv_printList.Visible = false;
        }

        private void MonthlyInvoice_Report_Load(object sender, EventArgs e)
        {
            customer cs;
            commercialinvoice cInv;
            consolidatemonthlyinvoice mInv;
            package pkg;

            using(edeaccountEntities db = new edeaccountEntities())
            {
                cs = db.customer.SingleOrDefault(i => i.accountID == log_user);
                mInv = db.consolidatemonthlyinvoice.SingleOrDefault(i => i.invoiceID == mInvoiceID);
            }

            // Fill the information to textbox
            txt_customerName.Text = cs.firstName + " " + cs.lastName;
            txt_accountID.Text = cs.accountID;
            txt_monthlyInvoiceID.Text = mInv.invoiceID;
            txt_totalValue.Text = mInv.value.ToString("$ #,###.##");
            txt_startDate.Text = mInv.startDate.ToString("yyyy-MM-dd");
            txt_endDate.Text = mInv.endDate.ToString("yyyy-MM-dd");
            paymentStatus(mInv.isPay);

            using(var pkgList = new edeaccountEntities())
            {
                var record = (from list in pkgList.commercialinvoices
                              join pk in pkgList.packages on list.packageID equals pk.packageID
                              where list.creationDate >= mInv.startDate && list.creationDate <= mInv.endDate
                              select new { 
                                  list.invoiceID,
                                  pk.pkgName,
                                  pk.packageType,
                                  pk.serviceType,
                                  pk.unitValue,
                                  pk.weight,
                                  pk.expense
                              });
                foreach(var record2 in record.ToList())
                {
                    // For View
                    dgv_list.Rows.Add(record2.invoiceID, record2.pkgName, record2.packageType, record2.serviceType, record2.unitValue.ToString("$ #,###.##"), record2.weight + " kg", record2.expense + " kg");

                    // For Print
                    dgv_printList.Rows.Add(record2.invoiceID, record2.pkgName, record2.packageType, record2.serviceType, record2.unitValue.ToString("$ #,###.##"), record2.weight + " kg", record2.expense + " kg");
                }
            }
        }

        private void paymentStatus(int isPay)
        {
            switch (isPay)
            {
                case 0:
                    btn_paymentStatus.Text = "Unpaid";
                    btn_paymentStatus.BackColor = Color.Red;
                    break;
                case 1:
                    btn_paymentStatus.Text = "Paid";
                    btn_paymentStatus.BackColor = Color.Green;
                    break;
                default:
                    btn_paymentStatus.Text = "Something Wrong";
                    btn_paymentStatus.BackColor = Color.Yellow;
                    MessageBox.Show("Please contect with our customer service.");
                    break;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            // Close Page
            this.Close();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            // Print Function
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Consolidate Monthly Invoice";
            printer.SubTitle = "Account ID: " + txt_accountID.Text + "\nCustomer Name: " + txt_customerName.Text + "\nInvoice ID: " + txt_monthlyInvoiceID.Text + "\nStart Date: " + txt_startDate.Text + "\n" + "End Date: " + txt_endDate.Text + "\n\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Eatern Delivery Express (EDE) Limited";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv_printList);
        }
    }
}
