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
    public partial class AccountReport_Print : Form
    {
        String creationDate;
        String accountID;
        String staffName;
        String startDate;
        String endDate;
        double totalPackage;
        double totalValue;
        double staffCosts;
        double rent;
        double electricity;
        double netIncome;

        public AccountReport_Print(String accountID, String startDate, String endDate, int totalPkg, double totalValue, double staffCost, double electricity, double rent, double netIncome)
        {
            InitializeComponent();

            // Initialize Variable
            using(edeaccountEntities db = new edeaccountEntities())
            {
                staff sta = db.staff.SingleOrDefault(i => i.accountID == accountID);

                this.creationDate = DateTime.Now.ToString("yyyy - MM - dd");
                this.accountID = accountID;
                this.staffName = sta.firstName + " " + sta.lastName;
                this.startDate = startDate;
                this.endDate = endDate;
                this.totalPackage = totalPkg;
                this.totalValue = totalValue;
                this.staffCosts = staffCost;
                this.rent = rent;
                this.electricity = electricity;
                this.netIncome = netIncome;
            }
        }

        private void AccountReport_Print_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("CreationDate", creationDate),
                    new Microsoft.Reporting.WinForms.ReportParameter("AccountID", accountID),
                    new Microsoft.Reporting.WinForms.ReportParameter("StaffName", staffName),
                    new Microsoft.Reporting.WinForms.ReportParameter("StartDate", startDate),
                    new Microsoft.Reporting.WinForms.ReportParameter("EndDate", endDate),
                    new Microsoft.Reporting.WinForms.ReportParameter("TotalPackage", totalPackage.ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("TotalValue", totalValue.ToString("$ #,###.##")),
                    new Microsoft.Reporting.WinForms.ReportParameter("StaffCosts", staffCosts.ToString("$ #,###.##")),
                    new Microsoft.Reporting.WinForms.ReportParameter("Rent", rent.ToString("$ #,###.##")),
                    new Microsoft.Reporting.WinForms.ReportParameter("Electricity", electricity.ToString("$ #,###.##")),
                    new Microsoft.Reporting.WinForms.ReportParameter("NetIncome", netIncome.ToString("$ #,###.##"))
                };
            reportViewer1.LocalReport.SetParameters(rParams);
            this.reportViewer1.RefreshReport();
        }
    }
}
