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
    public partial class AirwayBill_Print : Form
    {
        Bitmap bitmap;

        string log_ad_user;
        customer cus;
        bookingorder bko;
        package pkg;
        airwaybill awb;
        addressbook seAddr;
        addressbook reAddr;

        public AirwayBill_Print(string pkgID, double length, double width, double height, double weight)
        {
            InitializeComponent();

            importInfo(pkgID);
            generateAwb(length, width, height, weight);
            writeForm();
        }

        private void importInfo(string pkgID)
        {
            using (edeaccountEntities database = new edeaccountEntities())
            {
                pkg = database.packages.SingleOrDefault(i => i.packageID == pkgID);
                reAddr = database.addressbook.SingleOrDefault(i => i.addressId == pkg.addrID);
                bko = database.bookingorder.SingleOrDefault(i => i.bookingID == pkg.bookingID);
                seAddr = database.addressbook.SingleOrDefault(i => i.addressId == bko.addrID);
                cus = database.customer.SingleOrDefault(i => i.accountID == pkg.accID);
            }
        }

        private void generateAwb(double length, double width, double height, double weight)
        {
            
            using (edeaccountEntities database = new edeaccountEntities())
            {
                airwaybill awbCheck = database.airwaybill.SingleOrDefault(i => i.packageID == pkg.packageID);
                if(awbCheck == null)
                {
                    Random rand = new Random();
                    airwaybill awb2;
                    string awbNo = "S" + (rand.Next(999999999)).ToString();
                    while (true)
                    {
                        awb2 = database.airwaybill.SingleOrDefault(i => i.shippingNo == awbNo);
                        if (awb2 != null)
                            awbNo = "S" + (rand.Next(999999999)).ToString();
                        else
                            break;
                    }
                    airwaybill awb = new airwaybill
                    {
                        shippingNo = awbNo,
                        packageID = pkg.packageID,
                        accID = cus.accountID,
                        shippingExpenses = 0,
                        date = DateTime.Now,
                        service = pkg.serviceType,
                        length = length,
                        width = width,
                        height = height,
                        weight = weight,
                        destinationTax = "1",
                        transportCharge = "1",
                        typeOfExport = "1"
                    };
                    database.airwaybill.Add(awb);
                    database.SaveChanges();
                }
            }
        }

        private void writeForm()
        {
            using (edeaccountEntities database = new edeaccountEntities())
                awb = database.airwaybill.SingleOrDefault(i => i.packageID == pkg.packageID);

            // 1. From (Sender)
            lbl_accountID.Text = awb.accID;
            lbl_senderName.Text = cus.firstName + " " + cus.lastName;
            lbl_senderReference.Text = "";
            lbl_senderCompanyName.Text = seAddr.companyName;
            lbl_senderAddress.Text = seAddr.addressLn1 + "\n" + seAddr.addressLn2 + "\n" + seAddr.addressLn3;
            lbl_senderPostcode.Text = seAddr.postcode;
            if (seAddr.phoneNo != "")
            {
                lbl_senderPhoneNo.Text = seAddr.phoneNo;
                lbl_senderDeletePhone.Text = "";
                lbl_senderDeleteFax.Text = "----";
                lbl_senderDeleteTelex.Text = "----";
            }
            else if (seAddr.faxNo != "")
            {
                lbl_senderPhoneNo.Text = seAddr.faxNo;
                lbl_senderDeletePhone.Text = "----";
                lbl_senderDeleteFax.Text = "";
                lbl_senderDeleteTelex.Text = "----";
            }
            else if (seAddr.telexNo != "")
            {
                lbl_senderPhoneNo.Text = seAddr.telexNo;
                lbl_senderDeletePhone.Text = "----";
                lbl_senderDeleteFax.Text = "----";
                lbl_senderDeleteTelex.Text = "";
            }

            // 2. To (Receiver)
            lbl_receiverCompanyName.Text = reAddr.companyName;
            lbl_receiverAddress.Text = reAddr.addressLn1 + "\n" + reAddr.addressLn2 + "\n" + reAddr.addressLn3;
            lbl_receiverPostcode.Text = reAddr.postcode;
            lbl_receiverCountry.Text = reAddr.region;
            lbl_receiverContectName.Text = reAddr.contectName;
            if (reAddr.phoneNo != "")
            {
                lbl_receiverPhoneNo.Text = reAddr.phoneNo;
                lbl_receiverDeletePhone.Text = "";
                lbl_receiverDeleteFax.Text = "----";
                lbl_receiverDeleteTelex.Text = "----";
            }
            else if (reAddr.faxNo != "")
            {
                lbl_receiverPhoneNo.Text = reAddr.faxNo;
                lbl_receiverDeletePhone.Text = "----";
                lbl_receiverDeleteFax.Text = "";
                lbl_receiverDeleteTelex.Text = "----";
            }
            else if (reAddr.telexNo != "")
            {
                lbl_receiverPhoneNo.Text = reAddr.telexNo;
                lbl_receiverDeletePhone.Text = "----";
                lbl_receiverDeleteFax.Text = "----";
                lbl_receiverDeleteTelex.Text = "";
            }

            // 3. Shipment details
            lbl_shipmentNo.Text = awb.shippingNo;
            switch (pkg.serviceType)
            {
                case "Document":
                    ckb_serviceDocument.Checked = true;
                    lbl_serviceDeleteAirmail.Text = "";
                    lbl_serviceDeletePrintedMaster.Text = "";
                    break;
                case "Package Express":
                    ckb_servicePackageExpress.Checked = true;
                    lbl_serviceDeleteAirmail.Text = "";
                    lbl_serviceDeletePrintedMaster.Text = "";
                    break;
                case "Express Document":
                    ckb_serviceExpressDocument.Checked = true;
                    lbl_serviceDeleteAirmail.Text = "";
                    lbl_serviceDeletePrintedMaster.Text = "";
                    break;
                case "Domestic":
                    ckb_serviceDomestic.Checked = true;
                    lbl_serviceDeleteAirmail.Text = "";
                    lbl_serviceDeletePrintedMaster.Text = "";
                    break;
                case "Worldmail (Airmail)":
                    ckb_serviceWorldmail.Checked = true;
                    lbl_serviceDeleteAirmail.Text = "";
                    lbl_serviceDeletePrintedMaster.Text = "-------------------";
                    break;
                case "Worldmail (Printed Master)":
                    ckb_serviceWorldmail.Checked = true;
                    lbl_serviceDeleteAirmail.Text = "-----";
                    lbl_serviceDeletePrintedMaster.Text = "";
                    break;
            }
            lbl_pkgDesc.Text = pkg.remark;
            lbl_pkgValue.Text = (pkg.unitValue * pkg.qty).ToString("HK$#,###.##");
            ckb_taxesReceiver.Checked = true;

            // 4. Size and weight
            lbl_pkgQty.Text = pkg.qty.ToString();
            lbl_pkgWeight.Text = awb.weight.ToString() + "kg";
            lbl_pkgDimensions.Text = awb.length + "x" + awb.width + "x" + awb.height + "x" + pkg.qty + pkg.unit;

            // 5. Sender's authorization and signature
            lbl_date.Text = awb.date.ToString("dd-MM-yyyy");
        }


        private void printAirwayBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void print()
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, Size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            this.printAirwayBill.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printAirwayBill;
            printPreviewDialog1.ShowDialog();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            print();
        }
    }
}
