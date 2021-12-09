﻿using System;
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
    public partial class BookingOrder_03 : Form
    {
        public static package[] pkgList = new package[100];

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

        public BookingOrder_03()
        {
            InitializeComponent();
            dgv_pkgList.AllowUserToAddRows = false;
            dgv_pkgList.Columns[0].HeaderText = "Package Name";
            dgv_pkgList.Columns[1].HeaderText = "Quantity";
            dgv_pkgList.Columns[2].HeaderText = "Unit";
            dgv_pkgList.Columns[3].HeaderText = "Unit Value";
            dgv_pkgList.Columns[4].HeaderText = "Package Type";
            dgv_pkgList.Columns[5].HeaderText = "Service Type";
            dgv_pkgList.Columns[6].HeaderText = "Remark";
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
            lbl_message.Text = "Please select the package one by one in the package list to import address information.";

            pkgList = BookingOrder_02.pkgList;
            for (int i = 0; i <= pkgList.Length; i++)
            {
                // If the next of pkgList is null, break out of the looping
                if (pkgList[i] == null)
                    break;
                dgv_pkgList.Rows.Add(pkgList[i].pkgName, pkgList[i].qty, pkgList[i].unit, pkgList[i].unitValue, pkgList[i].packageType, pkgList[i].serviceType, pkgList[i].remark);
            }
        }

        private void btn_addrBook_Click(object sender, EventArgs e)
        {
            AddressBook_Package addrBook = new AddressBook_Package();
            addrBook.ShowDialog();
        }

        private void btn_importAddr_Click(object sender, EventArgs e)
        {
            if (addrID != null)
            {
                // Add the addrID to the package
                int rowIndex = dgv_pkgList.CurrentRow.Index;

                dgv_pkgList.Rows[rowIndex].DefaultCellStyle.BackColor = Color.PaleGreen;
                pkgList[rowIndex].addrID = addrID;
                // MessageBox.Show("Address import successful.");
                lbl_message.Text = "Package (" + pkgList[rowIndex].pkgName + ") Address import successful.";
                lbl_message.ForeColor = Color.Green;
            }
            else
            {
                // If the user not select the address
                lbl_message.Text = "Please select the address in the address book.";
                lbl_message.ForeColor = Color.Red;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Boolean isImportAddr = true;
            // Check the user is imported address to all packages
            for(int i=0; i<=pkgList.Length; i++)
            {
                if (pkgList[i] == null)
                    break;
                if(pkgList[i].addrID == null)
                {
                    isImportAddr = false;
                }
            }

            if(isImportAddr == true)
            {
                // User imported address to all packages
                // Change to the next page
                BookingOrder_04 bk4 = new BookingOrder_04();
                bk4.Show();
                this.Hide();
            }
            else
            {
                // Message to user for import address to all packages
                MessageBox.Show("Please import address to all packages.");
            }
        }

        private void btn_backMenu_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu menu = new EDEapp_MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
