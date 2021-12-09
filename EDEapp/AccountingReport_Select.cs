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
    public partial class AccountingReport_Select : Form
    {
        private String log_ad_user = "";

        // Staff Cost
        private double operationsManager = 0.0;     // 30,000 x 5
        private double operationsSupervisor = 0.0;  // 15,000 x 20
        private double accountExecutive = 0.0;      // 10,000 x 20
        private double bookingClerk = 0.0;          // 8,000 x 35
        private double shippingClerk = 0.0;         // 8,000 x 30
        private double vanDriver = 0.0;             // 10,000 x 30

        private double systemAnalyst = 0.0;         // 26,000 x 3
        private double programmer = 0.0;            // 17,000 x 5
        private double operators = 0.0;             // 11,000 x 10

        private double staffCost = 0.0;

        // Other Cost
        private double operationCentreRent = 0.0;   // 60,000
        private double expressCentreRent = 0.0;     // 20,000
        private double haadOfficeRent = 0.0;        // 120,000
        private double totalRent = 0.0;

        private double operationCentreElectricity = 0.0;    // 8,000
        private double expressCentreElectricity = 0.0;      // 4,000
        private double haadOfficeElectricity = 0.0;         // 12,000

        private double totalElectricity = 0.0;

        // Net Income
        private double netIncome = 0.0;

        // Package
        private int totalOfPkg = 0;
        private double totalOfExpense = 0.0;

        public AccountingReport_Select()
        {
            InitializeComponent();

            log_ad_user = Login.log_ad_user;

            // Initialize Staff Cost
            operationsManager = 30000 * 5;
            operationsSupervisor = 15000 * 20;
            accountExecutive = 10000 * 20;
            bookingClerk = 8000 * 35;
            shippingClerk = 8000 * 30;
            vanDriver = 10000 * 30;

            systemAnalyst = 26000 * 3;
            programmer = 17000 * 5;
            operators = 11000 * 10;

            staffCost = operationsManager + operationsSupervisor + accountExecutive + bookingClerk + shippingClerk + vanDriver + systemAnalyst + programmer + operators;

            // Initialize Rent Cost
            operationCentreRent = 60000;
            expressCentreRent = 20000;
            haadOfficeRent = 120000;

            totalRent = operationCentreRent + expressCentreRent + haadOfficeRent;

            // Initialize Electricity Cose
            operationCentreElectricity = 8000;
            expressCentreElectricity = 4000;
            haadOfficeElectricity = 12000;

            totalElectricity = operationCentreElectricity + expressCentreElectricity + haadOfficeElectricity;

            // Initialize DateTimePicker
            dtp_date.Value = new DateTime(int.Parse(DateTime.Now.ToString("yyyy")), int.Parse(DateTime.Now.AddMonths(-1).ToString("MM")), 1);
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            DateTime endDate = new DateTime(int.Parse(DateTime.Now.ToString("yyyy")), int.Parse(DateTime.Now.ToString("MM")), int.Parse(((dtp_date.Value).AddMonths(1).AddDays(-1)).ToString("dd")), 23, 59, 59);

            try
            {
                using (var db = new edeaccountEntities())
                {
                    var pkg = (from list in db.packages
                               where list.statusTime >= dtp_date.Value && list.statusTime <= endDate
                               select new
                               {
                                   list.expense
                               });
                    foreach (var pkg2 in pkg.ToList())
                    {
                        totalOfExpense += (double)pkg2.expense;
                        totalOfPkg += 1;
                    }
                }
                netIncome = totalOfExpense - staffCost - totalRent - totalElectricity;
                AccountReport_Print print = new AccountReport_Print(log_ad_user, dtp_date.Value.ToString("yyyy - MM - dd"), endDate.ToString("yyyy - MM - dd"), totalOfPkg, totalOfExpense, staffCost, totalElectricity, totalRent, netIncome);
                print.ShowDialog();
                // MessageBox.Show("Start Date: " + dtp_date.Value.ToString() + "\nEnd Date: " + endDate.ToString());
                // MessageBox.Show("Expense: $ " + totalOfExpense + "\nTotal of package: " + totalOfPkg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error: " + ex.Message);
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
