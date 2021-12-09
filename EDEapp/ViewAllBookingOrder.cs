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
    public partial class ViewAllBookingOrder : Form
    {
        public static string pickupDate = null;
        public static string pickupTime = null;
        public ViewAllBookingOrder()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[0].HeaderText = "accountID";
            dataGridView1.Columns[1].HeaderText = "bookingID";
            dataGridView1.Columns[2].HeaderText = "Company Name";
            dataGridView1.Columns[3].HeaderText = "Address";
            dataGridView1.Columns[4].HeaderText = "Region";
            dataGridView1.Columns[5].HeaderText = "Postcode";
            dataGridView1.Columns[6].HeaderText = "Contact Name";
            dataGridView1.Columns[7].HeaderText = "Phone Number";
            dataGridView1.Columns[8].HeaderText = "Fax";
            dataGridView1.Columns[9].HeaderText = "Telex";
            dataGridView1.Columns[10].HeaderText = "Pickup Time";
            ReloadDataGrid();
        }

        private void ViewAllBookingOrder_Load(object sender, EventArgs e)
        {
            ReloadDataGrid();
        }
        void ReloadDataGrid()
        {

            dataGridView1.Rows.Clear();
            using (var bookingrecord = new edeaccountEntities())
            {
                var record1 = (from list in bookingrecord.bookingorder
                               join c in bookingrecord.addressbook on list.addrID equals c.addressId
                               select new
                               {
                                   list.accID,
                                   list.bookingID,
                                   c.companyName,
                                   address = c.addressLn1 + " " + c.addressLn2 + " " + c.addressLn3,
                                   c.region,
                                   c.postcode,
                                   c.contectName,
                                   c.phoneNo,
                                   c.faxNo,
                                   c.telexNo,
                                   list.pickupDate,
                                   list.pickupTime
                               }
                               );
                foreach (var record in record1.ToList())
                {
                    dataGridView1.Rows.Add(record.accID, record.bookingID, record.companyName, record.address, record.region, record.postcode, record.contectName, record.phoneNo,record.faxNo,record.telexNo, record.pickupDate +" "+ record.pickupTime);
                }
            }
        }


        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

            using (var context = new edeaccountEntities())
            {
                var searchData = context
                .bookingorder
                .Join(
                    context.addressbook,
                    booking => booking.addrID,
                    address => address.addressId,
                    (booking, address) => new
                    {
                        Booking = booking,
                        Address = address
                    })
                .Where(data =>
                    data.Booking.bookingID.Contains(txtSearch.Text) ||
                    data.Address.companyName.Contains(txtSearch.Text) ||
                    data.Address.addressLn1.Contains(txtSearch.Text) ||
                    data.Address.addressLn2.Contains(txtSearch.Text) ||
                    data.Address.addressLn3.Contains(txtSearch.Text) ||
                    data.Address.region.Contains(txtSearch.Text) ||
                    data.Address.postcode.Contains(txtSearch.Text) ||
                    data.Address.contectName.Contains(txtSearch.Text) ||
                    data.Address.phoneNo.Contains(txtSearch.Text) ||
                    data.Address.faxNo.Contains(txtSearch.Text) ||
                    data.Address.telexNo.Contains(txtSearch.Text) ||
                    data.Booking.pickupDate.Contains(txtSearch.Text) ||
                    data.Booking.pickupTime.Contains(txtSearch.Text)
                )
                .ToList();

                foreach (var row in searchData)
                {
                    dataGridView1.Rows.Add(
                        row.Booking.accID,
                        row.Booking.bookingID,
                        row.Address.companyName,
                        $"{row.Address.addressLn1} {row.Address.addressLn2} {row.Address.addressLn3}",
                        row.Address.region,
                        row.Address.postcode,
                        row.Address.contectName,
                        row.Address.phoneNo,
                        row.Address.faxNo,
                        row.Address.telexNo,
                        row.Booking.pickupDate + " " + row.Booking.pickupTime

                    );
                }
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu main = new EDEapp_MainMenu();
            main.Show();
            this.Hide();
        }
    }
}
