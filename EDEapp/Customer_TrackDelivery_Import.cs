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
    public partial class Customer_TrackDelivery_Import : Form
    {
        private string log_user;

        public Customer_TrackDelivery_Import()
        {
            InitializeComponent();

            log_user = Login.log_user;
            lbl_message.Text = "";


            /*  Case 0 = Booking order received, Waiting for pickup
                Case 1 = Waiting for Measure
                Case 2 = Waiting for Shipping
                Case 3 = Shipping in progress
                Case 4 = Shipment arrived in " + addr.region + ", waiting for pickup
                Case 5 = Shipment collected by delivery staff. Now delivering to destination
                Case 6 = The shipment has arrived the destination
                Case 7 = Confirmed  */
            cb_status.Items.Add("0_All");
            cb_status.Items.Add("1_Waiting for pickup");         // Case "0"
            cb_status.Items.Add("2_Waiting for Measure");        // Case "1"
            cb_status.Items.Add("3_Waiting for Shipping");       // Case "2"
            cb_status.Items.Add("4_Shipping in progress");       // Case "3" + "4" + "5"
            cb_status.Items.Add("5_Arrived");                    // Case "6"
            cb_status.Items.Add("6_Confirmed");                  // Case "7"
            cb_status.SelectedIndex = 0;

            cb_searchType.Items.Add("Booking ID");
            cb_searchType.Items.Add("Package ID");
            cb_searchType.Text = "Select...";
        }

        private void Customer_TrackDelivery_Import_Load(object sender, EventArgs e)
        {
            constructDataGridView(-1);
        }

        private void constructDataGridView(int targetStatus)
        {
            // Add columns
            dgv_pkgList.ColumnCount = 6;
            dgv_pkgList.Columns[0].Name = "Booking ID";
            dgv_pkgList.Columns[1].Name = "Package ID";
            dgv_pkgList.Columns[2].Name = "Package Name";
            dgv_pkgList.Columns[3].Name = "Update Time";
            dgv_pkgList.Columns[4].Name = "Status";
            dgv_pkgList.Columns[5].Name = "Location";

            // DataGridView property setting
            dgv_pkgList.AllowUserToAddRows = false;
            dgv_pkgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Construct DataGridView
            dgv_pkgList.Rows.Clear();
            addRows(targetStatus);
            addButton();
        }

        private void addRows(int targetStatus)
        {
            // Add record to the DataGridView's row
            using (var database = new edeaccountEntities())
            {
                int target = pkgStatusNo(targetStatus);
                var pkg = (from list in database.packages
                           where list.accID == log_user && list.isImport == true
                           select list);

                if (target == -1)
                {
                    pkg = (from list in database.packages
                           where list.accID == log_user && list.status != "7" && list.isImport == true
                           select list);
                }
                else if (target == 345)
                {
                    pkg = (from list in database.packages
                           where list.accID == log_user && (list.status != "7" || list.status == "3" || list.status == "4" || list.status == "5") && list.isImport == true
                           select list);
                }
                else
                {
                    pkg = (from list in database.packages
                           where list.accID == log_user && list.status == target.ToString() && list.status != "7" && list.isImport == true
                           select list);
                }

                string status;
                    foreach (var pkg2 in pkg.ToList())
                    {
                        switch (pkg2.status)
                        {
                            case "0":
                                status = "Booking order received, Waiting for pickup";
                                break;
                            case "1":
                                status = "Waiting for Measure";
                                break;
                            case "2":
                                status = "Waiting for Shipping";
                                break;
                            case "3":
                                status = "Shipping in progress";
                                break;
                            case "4":
                                addressbook addr = database.addressbook.SingleOrDefault(i => i.addressId == pkg2.addrID);
                                status = "Shipment arrived in " + addr.region + ", waiting for pickup";
                                break;
                            case "5":
                                status = "Shipment collected by delivery staff. Now delivering to destination";
                                break;
                            case "6":
                                status = "The shipment has arrived the destination";
                                break;
                            case "7":
                                status = "Confirmed";
                                break;
                            default:
                                status = "Error: Please contect with customer service";
                                break;
                        }
                        dgv_pkgList.Rows.Add(pkg2.bookingID, pkg2.packageID, pkg2.pkgName, pkg2.statusTime, status, pkg2.location);
                    }
            }
        }

        private void addButton()
        {
            DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
            dgv_pkgList.Columns.Add(btn);
            btn.HeaderText = "Confirm Package";
            btn.Text = "Confirm";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            for (int i = 0; i <= dgv_pkgList.RowCount - 1; i++)
            {
                if (dgv_pkgList.Rows[i].Cells[4].Value != "The shipment has arrived the destination")
                {
                    DataGridViewDisableButtonCell btn2 = (DataGridViewDisableButtonCell)dgv_pkgList.Rows[i].Cells[6];
                    btn2.Enabled = false;
                }
            }
        }

        private void dgv_pkgList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (edeaccountEntities database = new edeaccountEntities())
            {
                // Double click the row of data can open the package detail windows form
                string selectedPkgID = dgv_pkgList.SelectedCells[1].Value.ToString();
                package pkg = database.packages.SingleOrDefault(i => i.packageID == selectedPkgID);
                PackageDetail pkgDetail = new PackageDetail(pkg);
                pkgDetail.ShowDialog();
            }
        }

        private void dgv_pkgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                string pkgStatus = dgv_pkgList.Rows[e.RowIndex].Cells[4].Value.ToString();
                string pkgName = dgv_pkgList.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (pkgStatus == "The shipment has arrived the destination")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you confirm the package was arrived?", "Confirm Package", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Change Package 'status' and 'isComplete' and 'cusConfirm'
                        using (var db = new edeaccountEntities())
                        {
                            string pkgID = dgv_pkgList.Rows[e.RowIndex].Cells[1].Value.ToString();
                            var pkg = db.packages.SingleOrDefault(i => i.packageID == pkgID);
                            pkg.isComplete = 1;
                            pkg.cusConfirm = true;
                            pkg.status = "7";
                            pkg.statusTime = DateTime.Now;
                            db.SaveChanges();
                        }

                        // Create Import Invoice
                        using(var db = new edeaccountEntities())
                        {
                            string pkgID = dgv_pkgList.Rows[e.RowIndex].Cells[1].Value.ToString();
                            var pkg = db.packages.SingleOrDefault(i => i.packageID == pkgID);
                            var bko = db.bookingorder.SingleOrDefault(i => i.bookingID == pkg.bookingID);

                            Boolean isAllPkgComplete = true;
                            var pkgList = (from list in db.packages
                                           where list.bookingID == bko.bookingID
                                           select list);
                            double total = 0.0;
                            foreach(var pkgList2 in pkgList.ToList())
                            {
                                if(pkgList2.cusConfirm != true)
                                    isAllPkgComplete = false;
                                else
                                    total += (Double)pkgList2.expense;
                            }
                            if (isAllPkgComplete)
                            {
                                using(edeaccountEntities database = new edeaccountEntities())
                                {
                                    Random rand = new Random();
                                    string iInvoice = "I" + rand.Next(999999999);
                                    importinvoice ii_check;
                                    while (true)
                                    {
                                        ii_check = database.importinvoices.SingleOrDefault(i => i.invoiceID == iInvoice);
                                        if (ii_check != null)
                                            iInvoice = "I" + rand.Next(999999999);
                                        else
                                            break;
                                    }
                                    importinvoice ii = new importinvoice
                                    {
                                        invoiceID = iInvoice,
                                        accountID = log_user,
                                        bookingID = pkg.bookingID,
                                        pickupAddrID = bko.addrID,
                                        recevierAddrID = pkg.addrID,
                                        totalValue = total,
                                        creationDate = DateTime.Now
                                    };
                                    database.importinvoices.Add(ii);
                                    database.SaveChanges();

                                    bko.totalExpenses = total;
                                    bko.status = "1";
                                    database.SaveChanges();
                                }
                            }
                            constructDGV();
                            lbl_message.Text = pkgName + " , Confirmed";
                            lbl_message.ForeColor = Color.Green;
                        }
                    }
                }
            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            constructDGV();
        }

        private void constructDGV()
        {
            switch (cb_status.SelectedIndex)
            {
                case 0:
                    // All case
                    constructDataGridView(-1);
                    break;
                case 1:
                    // Waiting for pickup
                    constructDataGridView(0);
                    break;
                case 2:
                    // Waiting for Measure
                    constructDataGridView(1);
                    break;
                case 3:
                    // Waiting for Shipping
                    constructDataGridView(2);
                    break;
                case 4:
                    // Shipping in progress
                    // Shipment arrived in " + addr.region + ", waiting for pickup
                    // Shipment collected by delivery staff. Now delivering to destination
                    constructDataGridView(345);
                    break;
                case 5:
                    // The shipment has arrived the destination
                    constructDataGridView(6);
                    break;
                case 6:
                    // Confirmed
                    constructDataGridView(7);
                    break;
                default:
                    break;
            }
        }

        private int pkgStatusNo(int targetStatus)
        {
            switch (targetStatus)
            {
                case -1:
                    return -1;
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 345:
                    return 345;
                case 6:
                    return 6;
                case 7:
                    return 7;
                default:
                    return -1;
            }
        }

        private void cb_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_searchType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_pkgList.Rows.Clear();
            dgv_pkgList.ColumnCount = 6;

            cb_status.Text = "Searching...";

            using (var database = new edeaccountEntities())
            {
                var pkg = (from list in database.packages
                           where list.accID == log_user && list.status != "7" && list.isImport == true
                           select list);

                if (cb_searchType.SelectedIndex == 0)
                {
                    pkg = (from list in database.packages
                           where list.accID == log_user && list.bookingID.Contains(txt_search.Text) && list.status != "7" && list.isImport == true
                           select list);
                }
                else if (cb_searchType.SelectedIndex == 1)
                {
                    pkg = (from list in database.packages
                           where list.accID == log_user && list.packageID.Contains(txt_search.Text) && list.status != "7" && list.isImport == true
                           select list);
                }
                foreach (var pkg2 in pkg.ToList())
                {
                    string status;
                    switch (pkg2.status)
                    {
                        case "0":
                            status = "Booking order received, Waiting for pickup";
                            break;
                        case "1":
                            status = "Waiting for Measure";
                            break;
                        case "2":
                            status = "Waiting for Shipping";
                            break;
                        case "3":
                            status = "Shipping in progress";
                            break;
                        case "4":
                            addressbook addr = database.addressbook.SingleOrDefault(i => i.addressId == pkg2.addrID);
                            status = "Shipment arrived in " + addr.region + ", waiting for pickup";
                            break;
                        case "5":
                            status = "Shipment collected by delivery staff. Now delivering to destination";
                            break;
                        case "6":
                            status = "The shipment has arrived the destination";
                            break;
                        case "7":
                            status = "Confirmed";
                            break;
                        default:
                            status = "Error: Please contect with customer service";
                            break;
                    }
                    dgv_pkgList.Rows.Add(pkg2.bookingID, pkg2.packageID, pkg2.pkgName, pkg2.statusTime, status, pkg2.location);
                }
                addButton();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            menu.Show();
            this.Close();
        }

        private void tsb_export_Click(object sender, EventArgs e)
        {
            Customer_TrackDelivery_Export export = new Customer_TrackDelivery_Export();
            export.Show();
            this.Close();
        }

        
    }
}
