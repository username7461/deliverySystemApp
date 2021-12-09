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
    public partial class PackageDetail : Form
    {
        public PackageDetail(package pkg)
        {
            InitializeComponent();
            txt_pkgName.Text = pkg.pkgName;
            txt_pkgQty.Text = pkg.qty.ToString();
            txt_pkgUnitValue.Text = pkg.unitValue.ToString();
            txt_pkgTotalValue.Text = "$ " + Convert.ToString(pkg.qty * pkg.unitValue);
            txt_pkgType.Text = pkg.packageType;
            txt_pkgServiceType.Text = pkg.serviceType;
            txt_pkgRemark.Text = pkg.remark;
            using (edeaccountEntities database = new edeaccountEntities())
            {
                addressbook addrBk = database.addressbook.SingleOrDefault(i => i.addressId == pkg.addrID);
                txt_addrContectName.Text = addrBk.contectName;
                txt_addrCompanyName.Text = addrBk.companyName;
                txt_addrLn1.Text = addrBk.addressLn1;
                txt_addrLn2.Text = addrBk.addressLn2;
                txt_addrLn3.Text = addrBk.addressLn3;
                txt_addrRegion.Text = addrBk.region;
                txt_addrPostcode.Text = addrBk.postcode;
                txt_addrPhoneNo.Text = addrBk.phoneNo;
                txt_addrFaxNo.Text = addrBk.faxNo;
                txt_addrTelexNo.Text = addrBk.telexNo;
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
