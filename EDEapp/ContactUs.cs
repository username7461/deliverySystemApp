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
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void ContactUs_Load(object sender, EventArgs e)
        {
            groupbox_contactAustralia.Visible = false;
            groupbox_contactJP.Visible = false;
            groupbox_contactshanghai.Visible = false;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            using (edeaccountEntities content = new edeaccountEntities())
            {
                customer cs = content.customer.SingleOrDefault(i => i.accountID == Login.log_user);
                staff sf = content.staff.SingleOrDefault(i => i.accountID == Login.log_ad_user);
                if (cs!=null)
                {
                    EDEapp_MainMenu eDEapp_Main = new EDEapp_MainMenu();
                    eDEapp_Main.Show();
                    this.Hide();
                }
                else if(sf!=null)
                {
                    EDEapp_MainMenu eDEapp_Main = new EDEapp_MainMenu();
                    eDEapp_Main.Show();
                    this.Hide();
                }else
                {
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }

            }
            
        }

        private void btn_email1_Click(object sender, EventArgs e)
        {
            ContactEmailShaTin contactEmail = new ContactEmailShaTin();
            contactEmail.ShowDialog();
        }

        private void btn_email2_Click(object sender, EventArgs e)
        {
            ContactEmailLWL contactEmail = new ContactEmailLWL();
            contactEmail.ShowDialog();
        }

        private void btn_stgooglemap_Click(object sender, EventArgs e)
        {
            shaTinLocation shaTinLocation = new shaTinLocation();
            shaTinLocation.ShowDialog();
        }

        private void btn_lwlgooglemap_Click(object sender, EventArgs e)
        {
            LeeWaiLeeLocation leeWaiLeeLocation = new LeeWaiLeeLocation();
            leeWaiLeeLocation.ShowDialog();
        }

        private void btn_japan_Click(object sender, EventArgs e)
        {
            //ContactUsJP jp = new ContactUsJP();
            //jp.Show();
            //this.Hide();
            groupbox_contacthk.Visible = false;
            groupbox_contactAustralia.Visible = false;
            groupbox_contactJP.Visible = true;
            groupbox_contactshanghai.Visible = false;

        }

        private void btn_Shanghai_Click(object sender, EventArgs e)
        {
            groupbox_contacthk.Visible = false;
            groupbox_contactJP.Visible = false;
            groupbox_contactAustralia.Visible = false;
            groupbox_contactshanghai.Visible = true ;

        }

        private void btn_Australia_Click(object sender, EventArgs e)
        {
            groupbox_contactAustralia.Visible = true;
            groupbox_contacthk.Visible = false;
            groupbox_contactJP.Visible = false;
            groupbox_contactshanghai.Visible = false;
        }

        private void btn_hk_Click(object sender, EventArgs e)
        {
            groupbox_contacthk.Visible = true;
            groupbox_contactJP.Visible = false;
            groupbox_contactAustralia.Visible = false;
            groupbox_contactshanghai.Visible = false;
        }

        private void groupbox_contactJP_Enter(object sender, EventArgs e)
        {

        }

        private void btn_japanlocation_Click(object sender, EventArgs e)
        {
            EDEJapanLocation japan = new EDEJapanLocation();
            japan.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EDEAustraliaLocation australia = new EDEAustraliaLocation();
            australia.ShowDialog();
        }

        private void btn_sendemailAustralia_Click(object sender, EventArgs e)
        {
            ContactEmailShaTin shaTin = new ContactEmailShaTin();
            shaTin.ShowDialog();
        }

        private void btn_japancentre_Click(object sender, EventArgs e)
        {
            ContactEmailShaTin shaTin = new ContactEmailShaTin();
            shaTin.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            shaTinLocation location = new shaTinLocation();
            location.ShowDialog();
        }

        private void btn_sendemailshanghai_Click(object sender, EventArgs e)
        {
            ContactEmailShaTin shaTin = new ContactEmailShaTin();
            shaTin.ShowDialog();
        }
    }
}
