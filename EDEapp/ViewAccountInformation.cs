using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDEapp
{
    public partial class ViewAccountInformation : Form
    {
        public static string CIP = "";
        public void getIP()  // get customer IP
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    CIP = ip.ToString();
                }
            }
        }
        public ViewAccountInformation()
        {
            InitializeComponent();
            txt_accountID.Text = Login.log_user;
            using (edeaccountEntities content = new edeaccountEntities())
            {
                customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user);
                if (cs != null)
                {
                    txt_FName.Text = cs.firstName;
                    txt_LastName.Text = cs.lastName;
                    txt_email.Text = cs.email;
                    txt_phone.Text = cs.phoneNo;
                    txt_credibility.Text = Convert.ToString(cs.credibility);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu eDEapp_Main = new EDEapp_MainMenu();
            eDEapp_Main.Show();
            this.Hide();
        }

        private void ViewAccountInformation_Load(object sender, EventArgs e)
        {
            getIP();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditAccount edit = new EditAccount();
            edit.Show();
            this.Hide();
        }

        private void btn_creditcardinformation_Click(object sender, EventArgs e)
        {
            CheckSavedCreditCard record = new CheckSavedCreditCard();
            record.Show();
            this.Hide();
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ReSetPassWord reset = new ReSetPassWord();
            reset.Show();
            this.Hide();
        }
    }
}
