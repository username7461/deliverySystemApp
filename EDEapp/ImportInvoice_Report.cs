using DGVPrinterHelper;
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
    public partial class ImportInvoice_Report : Form
    {
        String log_user;
        String iInvoiceID;

        public ImportInvoice_Report(String iInv)
        {
            InitializeComponent();

            log_user = Login.log_user;
            iInvoiceID = iInv;

            // Initialize Buttons and Textbox
            txt_customerName.ReadOnly = true;
            txt_accountID.ReadOnly = true;
            txt_importInvoiceID.ReadOnly = true;
            txt_totalValue.ReadOnly = true;
            txt_creationDate.ReadOnly = true;
            rtb_pickupAddress.ReadOnly = true;
            rtb_receiverAddress.ReadOnly = true;

            // Initialize DataGridView (View)
            dgv_list.ColumnCount = 7;
            dgv_list.Columns[0].HeaderText = "Package ID";
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

            // Initialize DataGridView (Print)
            dgv_printList.ColumnCount = 7;
            dgv_printList.Columns[0].HeaderText = "Package ID";
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

        private void ImportInvoice_Report_Load(object sender, EventArgs e)
        {
            customer cs;
            importinvoice iInv;
            bookingorder bko;
            addressbook pickupAddr;
            addressbook receiverAddr;

            using (edeaccountEntities db = new edeaccountEntities())
            {
                cs = db.customer.SingleOrDefault(i => i.accountID == log_user);
                iInv = db.importinvoices.SingleOrDefault(i => i.invoiceID == iInvoiceID);
                bko = db.bookingorder.SingleOrDefault(i => i.bookingID == iInv.bookingID);
                pickupAddr = db.addressbook.SingleOrDefault(i => i.addressId == iInv.pickupAddrID);
                receiverAddr = db.addressbook.SingleOrDefault(i => i.addressId == iInv.recevierAddrID);
            }

            // Fill the information to textbox
            txt_customerName.Text = cs.firstName + " " + cs.lastName;
            txt_accountID.Text = cs.accountID;
            txt_importInvoiceID.Text = iInv.invoiceID;
            txt_totalValue.Text = iInv.totalValue.ToString("$ #,###.##");
            txt_creationDate.Text = iInv.creationDate.ToString("yyyy-MM-dd");
            rtb_pickupAddress.Text = pickupAddr.addressLn1 + "\n" + pickupAddr.addressLn2 + "\n" + pickupAddr.addressLn3;
            rtb_receiverAddress.Text = receiverAddr.addressLn1 + "\n" + receiverAddr.addressLn2 + "\n" + receiverAddr.addressLn3;

            using (var pkgList = new edeaccountEntities())
            {
                var record = (from list in pkgList.packages
                              where list.bookingID == bko.bookingID
                              select new
                              {
                                  list.packageID,
                                  list.pkgName,
                                  list.packageType,
                                  list.serviceType,
                                  list.unitValue,
                                  list.weight,
                                  list.expense
                              });
                foreach (var record2 in record.ToList())
                {
                    dgv_list.Rows.Add(record2.packageID, record2.pkgName, record2.packageType, record2.serviceType, record2.unitValue, record2.weight, record2.expense);
                    dgv_printList.Rows.Add(record2.packageID, record2.pkgName, record2.packageType, record2.serviceType, record2.unitValue, record2.weight, record2.expense);
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            // Print Function
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Import Service Invoice";
            printer.SubTitle = "Account ID: " + txt_accountID.Text + "\nCustomer Name: " + txt_customerName.Text + "\nInvoice ID: " + txt_importInvoiceID.Text + "\n\nPickup Address: \n" + rtb_pickupAddress.Text + "\n\nReceiver Address: \n" + rtb_receiverAddress.Text + "\n\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Eatern Delivery Express (EDE) Limited";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv_printList);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
