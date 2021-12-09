using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*string shipperCompanyName, string shipperAddrLn1, string shipperAddrLn2, string shipperAddrLn3, string shipperContectName,
            string shipperPhoneNo, string shiptoCompanyName, string shiptoAddrLn1, string shiptoAddrLn2, string shiptoAddrLn3, string shiptoPostcode, string shiptoAddrRegion,
            string shipto*/
namespace EDEapp
{
    public partial class CommercialInvoice_Preview : Form
    {
        commercialinvoice comInvoice;
        addressbook shipperAddr;
        addressbook shiptoAddr;
        package pkg;
        bookingorder bko;
        airwaybill awb;

        string invoiceID, bookingID;

        public CommercialInvoice_Preview(string invoiceID, string bookingID)
        {
            InitializeComponent();
            this.invoiceID = invoiceID;
            this.bookingID = bookingID;
        }

        private void CommercialInvoice_Preview_Load(object sender, EventArgs e)
        {
            using (edeaccountEntities db = new edeaccountEntities())
            {
                comInvoice = db.commercialinvoices.SingleOrDefault(i => i.invoiceID == invoiceID);
                pkg = db.packages.SingleOrDefault(i => i.packageID == comInvoice.packageID);
                bko = db.bookingorder.SingleOrDefault(i => i.bookingID == bookingID);
                awb = db.airwaybill.SingleOrDefault(i => i.packageID == comInvoice.packageID);
                shipperAddr = db.addressbook.SingleOrDefault(i => i.addressId == bko.addrID);
                shiptoAddr = db.addressbook.SingleOrDefault(i => i.addressId == pkg.addrID);
            }

            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("shipperCompanyName", shipperAddr.companyName),
                    new Microsoft.Reporting.WinForms.ReportParameter("shipperAddress", shipperAddr.addressLn1 + "\n" + shipperAddr.addressLn2 + "\n" + shipperAddr.addressLn3),
                    new Microsoft.Reporting.WinForms.ReportParameter("shipperContactName", shipperAddr.contectName),
                    new Microsoft.Reporting.WinForms.ReportParameter("shipperPhoneNo", shipperAddr.phoneNo),
                    new Microsoft.Reporting.WinForms.ReportParameter("shiptoCompanyName", shiptoAddr.companyName),
                    new Microsoft.Reporting.WinForms.ReportParameter("shiptoAddress", shiptoAddr.addressLn1 + "\n" + shiptoAddr.addressLn2 + "\n" + shiptoAddr.addressLn3),
                    new Microsoft.Reporting.WinForms.ReportParameter("shiptoAreaCode", shiptoAddr.postcode),
                    new Microsoft.Reporting.WinForms.ReportParameter("shiptoCountry", shiptoAddr.region),
                    new Microsoft.Reporting.WinForms.ReportParameter("shiptoContactName", shiptoAddr.contectName),
                    new Microsoft.Reporting.WinForms.ReportParameter("shiptoPhoneNo", shiptoAddr.phoneNo),
                    new Microsoft.Reporting.WinForms.ReportParameter("airwaybillNo", awb.shippingNo),
                    new Microsoft.Reporting.WinForms.ReportParameter("noOfPieces", pkg.qty + " " + pkg.unit),
                    new Microsoft.Reporting.WinForms.ReportParameter("totalWeight", awb.weight.ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("pkgName", pkg.pkgName),
                    new Microsoft.Reporting.WinForms.ReportParameter("pkgUnitValue", pkg.unitValue.ToString("HK$ #,###.##")),
                    new Microsoft.Reporting.WinForms.ReportParameter("pkgTotalValue", (pkg.qty * pkg.unitValue).ToString("HK$ #,###.##")),
                    new Microsoft.Reporting.WinForms.ReportParameter("shipperRegion", shipperAddr.region)
                };
            reportViewer1.LocalReport.SetParameters(rParams);
            reportViewer1.RefreshReport();
        }
    }
}