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
    public partial class StaffAccountInfomation : Form
    {
        public static string jobName;
        public static string WorkingLocation;
        public StaffAccountInfomation()
        {
            InitializeComponent();
            txt_accountID.Text = Login.log_ad_user;
            using (edeaccountEntities content = new edeaccountEntities())
            {
                staff sf = content.staff.SingleOrDefault(i => i.accountID == Login.log_ad_user);
                if (sf.jobID == 0)
                {
                    jobName = "Booking Clerk";
                }
                if (sf.jobID ==1)
                {
                    jobName = "Shipping Clerk";
                }
                if (sf.jobID == 2)
                {
                    jobName = "Accounting Clerk";
                }
                if (sf.jobID == 3)
                {
                    jobName = "Managing Director";
                }
                if (sf.jobID == 4)
                {
                    jobName = "Customer Service Officer";
                }
                if(sf.jobID==5)
                {
                    jobName = "System Administrator";
                }
                if(sf.centreID == "001")
                {
                    WorkingLocation = "EDE company(Sha Tin)";
                }
                if (sf.centreID == "002")
                {
                    WorkingLocation = "EDE company(Tseung Kwan O)";
                }
                if (sf.centreID == "003")
                {
                    WorkingLocation = "EDE company(Japan)";
                }
                if (sf.centreID == "004")
                {
                    WorkingLocation = "EDE company(Australia)";
                }
                if (sf.centreID == "005")
                {
                    WorkingLocation = "EDE company(China ShangHai)";
                }
                if (sf != null)
                {
                    txt_FName.Text = sf.firstName;
                    txt_LastName.Text = sf.lastName;
                    txt_email.Text = sf.email;
                    txt_phone.Text = sf.phoneNo;
                    txt_jobname.Text = jobName;
                    txt_wkcenter.Text = WorkingLocation;
                }
            }
        }

        private void StaffAccountInfomation_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu main = new EDEapp_MainMenu();
            main.Show();
            this.Hide();
        }

        private void txt_wkcenter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_jobname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
