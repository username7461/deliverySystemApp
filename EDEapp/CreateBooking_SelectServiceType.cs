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
    public partial class CreateBooking_SelectServiceType : Form
    {
        public CreateBooking_SelectServiceType()
        {
            InitializeComponent();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            BookingImportOrder_01 bk1 = new BookingImportOrder_01();
            bk1.Show();
            this.Close();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            BookingOrder_01 bk1 = new BookingOrder_01();
            bk1.Show();
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
