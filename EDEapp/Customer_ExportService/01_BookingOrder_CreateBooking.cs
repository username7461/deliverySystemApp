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
    public partial class BookingOrder_01 : Form
    {
        static string log_user;
        public static string addrID = null;
        public static TextBox txtContectName;
        public static TextBox txtCompanyName;
        public static TextBox txtAddrLn1;
        public static TextBox txtAddrLn2;
        public static TextBox txtAddrLn3;
        public static TextBox txtRegion;
        public static TextBox txtPostcode;
        public static TextBox txtPhoneNo;
        public static TextBox txtFaxNo;
        public static TextBox txtTelexNo;
        public static ComboBox cbPickupDate;
        public static ComboBox cbPickupTime;

        public static string pickupDate = null;
        public static string pickupTime = null;

        public BookingOrder_01()
        {
            InitializeComponent();
            log_user = Login.log_user;
            txtContectName = txt_contectName;
            txtCompanyName = txt_companyName;
            txtAddrLn1 = txt_addrLn1;
            txtAddrLn2 = txt_addrLn2;
            txtAddrLn3 = txt_addrLn3;
            txtRegion = txt_region;
            txtPostcode = txt_postcode;
            txtPhoneNo = txt_phoneNo;
            txtFaxNo = txt_faxNo;
            txtTelexNo = txt_telexNo;
            cbPickupDate = cb_pickupDate;
            cbPickupTime = cb_pickupTime;
            cb_pickupDate.Text = "Select Date...";
            cb_pickupTime.Text = "Select Time...";
            for (int i = 1; i <= 7; i++)
                cb_pickupDate.Items.Add(DateTime.Now.AddDays(i).ToString("yyyy-MM-dd"));
            cb_pickupTime.Items.Add("10:00 - 14:00");
            cb_pickupTime.Items.Add("14:00 - 18:00");
        }

        private void CreateBK1_Paint(object sender, PaintEventArgs e)
        {
            /*e.Graphics.FillEllipse(Brushes.Red, new Rectangle(300, 10, 120, 100));
            e.Graphics.FillEllipse(Brushes.White, new Rectangle(500, 10, 120, 100));
            e.Graphics.FillEllipse(Brushes.White, new Rectangle(700, 10, 120, 100));*/
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (addrID == null)
            {
                MessageBox.Show("Please select pickup address.");
                return;
            }
            else
            {
                switch (cb_pickupDate.SelectedIndex)
                {
                    case 0:
                        pickupDate = cb_pickupDate.Items[0].ToString();
                        break;
                    case 1:
                        pickupDate = cb_pickupDate.Items[1].ToString();
                        break;
                    case 2:
                        pickupDate = cb_pickupDate.Items[2].ToString();
                        break;
                    case 3:
                        pickupDate = cb_pickupDate.Items[3].ToString();
                        break;
                    case 4:
                        pickupDate = cb_pickupDate.Items[4].ToString();
                        break;
                    case 5:
                        pickupDate = cb_pickupDate.Items[5].ToString();
                        break;
                    case 6:
                        pickupDate = cb_pickupDate.Items[6].ToString();
                        break;
                    default:
                        MessageBox.Show("Please select pickup date");
                        return;
                }
                switch (cb_pickupTime.SelectedIndex)
                {
                    case 0:
                        pickupTime = cb_pickupTime.Items[0].ToString();
                        break;
                    case 1:
                        pickupTime = cb_pickupTime.Items[1].ToString();
                        break;
                    default:
                        MessageBox.Show("Please select pickup time");
                        return;
                }
            }

            BookingOrder_02 next = new BookingOrder_02();
            next.Show();
            this.Hide();
        }

        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }
            }
            cbPickupDate.ResetText();
            cbPickupTime.ResetText();
            cbPickupDate.Text = "Select Date...";
            cbPickupTime.Text = "Select Time...";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the form?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                addrID = null;
                ResetAllControls(this);
            }
        }

        private void btn_addrBook_Click(object sender, EventArgs e)
        {
            AddressBook_Pickup addrBook = new AddressBook_Pickup();
            addrBook.ShowDialog();
        }

        private void cb_pickupDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_pickupTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_backMenu_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
