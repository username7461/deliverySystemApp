using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace EDEapp
{
    public partial class BookingImportOrder_04 : Form
    {
        public static string pickupAddrID;
        public static string pickupDate;
        public static string pickupTime;
        public static package[] pkgList = new package[100];

        string log_user;

        public BookingImportOrder_04()
        {
            InitializeComponent();
            log_user = Login.log_user;
            pickupAddrID = BookingImportOrder_01.addrID;
            pickupTime = BookingImportOrder_01.pickupTime;
            dgv_pkgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (edeaccountEntities database = new edeaccountEntities())
            {
                addressbook addrBk = database.addressbook.SingleOrDefault(i => i.addressId == pickupAddrID);
                txt_companyName.Text = addrBk.companyName;
                txt_addrLn1.Text = addrBk.addressLn1;
                txt_addrLn2.Text = addrBk.addressLn2;
                txt_addrLn3.Text = addrBk.addressLn3;
                txt_region.Text = addrBk.region;
                txt_postcode.Text = addrBk.postcode;
                txt_contectName.Text = addrBk.contectName;
                txt_phoneNo.Text = addrBk.phoneNo;
                txt_faxNo.Text = addrBk.faxNo;
                txt_telexNo.Text = addrBk.telexNo;
                txt_pickupDate.Text = pickupDate;
                txt_pickupTime.Text = pickupTime;
            }
            dgv_pkgList.AllowUserToAddRows = false;
            dgv_pkgList.Columns[0].HeaderText = "Package Name";
            dgv_pkgList.Columns[1].HeaderText = "Quantity";
            dgv_pkgList.Columns[2].HeaderText = "Unit";
            dgv_pkgList.Columns[3].HeaderText = "Unit Value";
            dgv_pkgList.Columns[4].HeaderText = "Package Type";
            dgv_pkgList.Columns[5].HeaderText = "Service Type";
            dgv_pkgList.Columns[6].HeaderText = "Remark";
            pkgList = BookingImportOrder_02.pkgList;
            for (int i = 0; i <= pkgList.Length; i++)
            {
                // If the next of pkgList is null, break out of the looping
                if (pkgList[i] == null)
                    break;
                dgv_pkgList.Rows.Add(pkgList[i].pkgName, pkgList[i].qty, pkgList[i].unit, pkgList[i].unitValue, pkgList[i].packageType, pkgList[i].serviceType, pkgList[i].remark);
            }
        }

        private void dgv_pkgList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PackageDetail pkgDetail = new PackageDetail(pkgList[dgv_pkgList.CurrentRow.Index]);
            pkgDetail.ShowDialog();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to create booking order? \nPlease check the details carefully.", "Create Booking Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (edeaccountEntities database = new edeaccountEntities())
                {
                    Random rand = new Random();
                    string bookingNo;
                    string packageNo;
                    int interval = int.Parse(BookingImportOrder_01.numInterval.Value.ToString());
                    int duration = int.Parse(BookingImportOrder_01.numDuration.Value.ToString());

                    for (int k = 0; k < duration; k++)
                    {
                        bookingNo = "B" + (rand.Next(999999999)).ToString();
                        bookingorder bko;
                        while (true)
                        {
                            bko = database.bookingorder.SingleOrDefault(i => i.bookingID == bookingNo);
                            if (bko != null)
                                bookingNo = "B" + (rand.Next(999999999)).ToString();
                            else
                                break;
                        }
                        bookingorder bk = new bookingorder
                        {
                            bookingID = bookingNo,
                            accID = log_user,
                            addrID = BookingImportOrder_01.addrID,
                            datetime = DateTime.Now,
                            serviceType = "Import",
                            totalExpenses = 0.0,
                            status = "0",
                            pickupDate = DateTime.Now.AddMonths(interval*k).AddDays(3).ToString("yyyy-MM-dd"),
                            pickupTime = BookingImportOrder_01.pickupTime
                        };
                        database.bookingorder.Add(bk);

                        package pk;
                        for (int i = 0; i <= pkgList.Length; i++)
                        {
                            if (pkgList[i] == null)
                                break;

                            packageNo = "P" + (rand.Next(999999999)).ToString();
                            while (true)
                            {
                                pk = database.packages.SingleOrDefault(j => j.packageID == packageNo);
                                if (pk != null)
                                    packageNo = "P" + (rand.Next(999999999)).ToString();
                                else
                                    break;
                            }
                            package pkg = new package
                            {
                                packageID = packageNo,
                                accID = log_user,
                                bookingID = bookingNo,
                                pkgName = pkgList[i].pkgName,
                                packageType = pkgList[i].packageType,
                                serviceType = pkgList[i].serviceType,
                                isImport = true,
                                qty = pkgList[i].qty,
                                unit = pkgList[i].unit,
                                unitValue = pkgList[i].unitValue,
                                addrID = pkgList[i].addrID,
                                statusTime = DateTime.Now,
                                status = "0",
                                isComplete = 0,
                                location = "N/A",
                                centreID = "N/A",
                                staffID = "N/A",
                                remark = pkgList[i].remark,
                                cusConfirm = false
                            };
                            database.packages.Add(pkg);
                        }
                        database.SaveChanges();
                    }


                    MessageBox.Show("Complete");
                    EDEapp_MainMenu menu = new EDEapp_MainMenu();
                    menu.Show();
                    this.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            BookingOrder_03 bk3 = new BookingOrder_03();
            bk3.Show();
            this.Close();
        }

        private void btn_backMenu_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
