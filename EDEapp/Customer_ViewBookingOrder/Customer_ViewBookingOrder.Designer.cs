
namespace EDEapp.Customer_ViewBookingOrder
{
    partial class CustomerViewBookingOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_exitEdit = new System.Windows.Forms.Button();
            this.btn_cancelBooking = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_telexNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_faxNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_phoneNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pickupTime = new System.Windows.Forms.TextBox();
            this.lbl_pickupTime = new System.Windows.Forms.Label();
            this.lbl_pickupDate = new System.Windows.Forms.Label();
            this.txt_addr3 = new System.Windows.Forms.TextBox();
            this.lab_address3 = new System.Windows.Forms.Label();
            this.txt_addr2 = new System.Windows.Forms.TextBox();
            this.lab_address2 = new System.Windows.Forms.Label();
            this.txt_addr1 = new System.Windows.Forms.TextBox();
            this.lab_address1 = new System.Windows.Forms.Label();
            this.dgv_bkoList = new System.Windows.Forms.DataGridView();
            this.txt_serviceType = new System.Windows.Forms.TextBox();
            this.txt_bookingID = new System.Windows.Forms.TextBox();
            this.lbl_bookingID = new System.Windows.Forms.Label();
            this.btn_changeAddr = new System.Windows.Forms.Button();
            this.lbl_serviceType = new System.Windows.Forms.Label();
            this.txt_pickupDate = new System.Windows.Forms.TextBox();
            this.txt_bookingCreationDate = new System.Windows.Forms.TextBox();
            this.lbl_bookingCreationDateTime = new System.Windows.Forms.Label();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_companyName = new System.Windows.Forms.TextBox();
            this.lab_CompanyName = new System.Windows.Forms.Label();
            this.txt_contectName = new System.Windows.Forms.TextBox();
            this.lab_contectName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_region = new System.Windows.Forms.TextBox();
            this.btn_viewPackage = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bkoList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(213, 246);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(219, 23);
            this.btn_edit.TabIndex = 100;
            this.btn_edit.Text = "Edit Booking";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_exitEdit
            // 
            this.btn_exitEdit.Location = new System.Drawing.Point(1085, 278);
            this.btn_exitEdit.Name = "btn_exitEdit";
            this.btn_exitEdit.Size = new System.Drawing.Size(105, 23);
            this.btn_exitEdit.TabIndex = 99;
            this.btn_exitEdit.Text = "Exit Editing";
            this.btn_exitEdit.UseVisualStyleBackColor = true;
            this.btn_exitEdit.Click += new System.EventHandler(this.btn_exitEdit_Click);
            // 
            // btn_cancelBooking
            // 
            this.btn_cancelBooking.Location = new System.Drawing.Point(943, 278);
            this.btn_cancelBooking.Name = "btn_cancelBooking";
            this.btn_cancelBooking.Size = new System.Drawing.Size(105, 23);
            this.btn_cancelBooking.TabIndex = 98;
            this.btn_cancelBooking.Text = "Cancel Booking";
            this.btn_cancelBooking.UseVisualStyleBackColor = true;
            this.btn_cancelBooking.Click += new System.EventHandler(this.btn_cancelBooking_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(213, 275);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(219, 23);
            this.btn_update.TabIndex = 97;
            this.btn_update.Text = "Update Booking";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_telexNo
            // 
            this.txt_telexNo.Location = new System.Drawing.Point(943, 213);
            this.txt_telexNo.Name = "txt_telexNo";
            this.txt_telexNo.Size = new System.Drawing.Size(219, 22);
            this.txt_telexNo.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.label2.Location = new System.Drawing.Point(852, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 14);
            this.label2.TabIndex = 94;
            this.label2.Text = "Telex Number";
            // 
            // txt_faxNo
            // 
            this.txt_faxNo.Location = new System.Drawing.Point(943, 176);
            this.txt_faxNo.Name = "txt_faxNo";
            this.txt_faxNo.Size = new System.Drawing.Size(219, 22);
            this.txt_faxNo.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.label3.Location = new System.Drawing.Point(862, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 93;
            this.label3.Text = "Fax Number";
            // 
            // txt_phoneNo
            // 
            this.txt_phoneNo.Location = new System.Drawing.Point(943, 140);
            this.txt_phoneNo.Name = "txt_phoneNo";
            this.txt_phoneNo.Size = new System.Drawing.Size(219, 22);
            this.txt_phoneNo.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.label4.Location = new System.Drawing.Point(849, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 14);
            this.label4.TabIndex = 92;
            this.label4.Text = "Phone Number";
            // 
            // txt_pickupTime
            // 
            this.txt_pickupTime.Location = new System.Drawing.Point(213, 174);
            this.txt_pickupTime.Name = "txt_pickupTime";
            this.txt_pickupTime.Size = new System.Drawing.Size(219, 22);
            this.txt_pickupTime.TabIndex = 86;
            // 
            // lbl_pickupTime
            // 
            this.lbl_pickupTime.AutoSize = true;
            this.lbl_pickupTime.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lbl_pickupTime.Location = new System.Drawing.Point(126, 177);
            this.lbl_pickupTime.Name = "lbl_pickupTime";
            this.lbl_pickupTime.Size = new System.Drawing.Size(81, 14);
            this.lbl_pickupTime.TabIndex = 91;
            this.lbl_pickupTime.Text = "Pickup Time:";
            // 
            // lbl_pickupDate
            // 
            this.lbl_pickupDate.AutoSize = true;
            this.lbl_pickupDate.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lbl_pickupDate.Location = new System.Drawing.Point(129, 143);
            this.lbl_pickupDate.Name = "lbl_pickupDate";
            this.lbl_pickupDate.Size = new System.Drawing.Size(78, 14);
            this.lbl_pickupDate.TabIndex = 90;
            this.lbl_pickupDate.Text = "Pickup Date:";
            // 
            // txt_addr3
            // 
            this.txt_addr3.Location = new System.Drawing.Point(616, 213);
            this.txt_addr3.Name = "txt_addr3";
            this.txt_addr3.Size = new System.Drawing.Size(219, 22);
            this.txt_addr3.TabIndex = 80;
            // 
            // lab_address3
            // 
            this.lab_address3.AutoSize = true;
            this.lab_address3.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lab_address3.Location = new System.Drawing.Point(524, 216);
            this.lab_address3.Name = "lab_address3";
            this.lab_address3.Size = new System.Drawing.Size(90, 14);
            this.lab_address3.TabIndex = 85;
            this.lab_address3.Text = "Address Line 3";
            // 
            // txt_addr2
            // 
            this.txt_addr2.Location = new System.Drawing.Point(616, 176);
            this.txt_addr2.Name = "txt_addr2";
            this.txt_addr2.Size = new System.Drawing.Size(219, 22);
            this.txt_addr2.TabIndex = 79;
            // 
            // lab_address2
            // 
            this.lab_address2.AutoSize = true;
            this.lab_address2.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lab_address2.Location = new System.Drawing.Point(524, 179);
            this.lab_address2.Name = "lab_address2";
            this.lab_address2.Size = new System.Drawing.Size(90, 14);
            this.lab_address2.TabIndex = 84;
            this.lab_address2.Text = "Address Line 2";
            // 
            // txt_addr1
            // 
            this.txt_addr1.Location = new System.Drawing.Point(616, 140);
            this.txt_addr1.Name = "txt_addr1";
            this.txt_addr1.Size = new System.Drawing.Size(219, 22);
            this.txt_addr1.TabIndex = 78;
            // 
            // lab_address1
            // 
            this.lab_address1.AutoSize = true;
            this.lab_address1.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lab_address1.Location = new System.Drawing.Point(524, 143);
            this.lab_address1.Name = "lab_address1";
            this.lab_address1.Size = new System.Drawing.Size(90, 14);
            this.lab_address1.TabIndex = 83;
            this.lab_address1.Text = "Address Line 1";
            // 
            // dgv_bkoList
            // 
            this.dgv_bkoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bkoList.Location = new System.Drawing.Point(15, 307);
            this.dgv_bkoList.Name = "dgv_bkoList";
            this.dgv_bkoList.RowTemplate.Height = 24;
            this.dgv_bkoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bkoList.Size = new System.Drawing.Size(1175, 273);
            this.dgv_bkoList.TabIndex = 72;
            this.dgv_bkoList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bkoList_CellClick);
            // 
            // txt_serviceType
            // 
            this.txt_serviceType.Location = new System.Drawing.Point(213, 104);
            this.txt_serviceType.Name = "txt_serviceType";
            this.txt_serviceType.Size = new System.Drawing.Size(219, 22);
            this.txt_serviceType.TabIndex = 77;
            // 
            // txt_bookingID
            // 
            this.txt_bookingID.Location = new System.Drawing.Point(213, 70);
            this.txt_bookingID.Name = "txt_bookingID";
            this.txt_bookingID.Size = new System.Drawing.Size(219, 22);
            this.txt_bookingID.TabIndex = 76;
            // 
            // lbl_bookingID
            // 
            this.lbl_bookingID.AutoSize = true;
            this.lbl_bookingID.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lbl_bookingID.Location = new System.Drawing.Point(131, 73);
            this.lbl_bookingID.Name = "lbl_bookingID";
            this.lbl_bookingID.Size = new System.Drawing.Size(76, 14);
            this.lbl_bookingID.TabIndex = 81;
            this.lbl_bookingID.Text = "Booking ID:";
            // 
            // btn_changeAddr
            // 
            this.btn_changeAddr.Location = new System.Drawing.Point(616, 246);
            this.btn_changeAddr.Name = "btn_changeAddr";
            this.btn_changeAddr.Size = new System.Drawing.Size(219, 23);
            this.btn_changeAddr.TabIndex = 74;
            this.btn_changeAddr.Text = "Change Address";
            this.btn_changeAddr.UseVisualStyleBackColor = true;
            this.btn_changeAddr.Click += new System.EventHandler(this.btn_changeAddr_Click);
            // 
            // lbl_serviceType
            // 
            this.lbl_serviceType.AutoSize = true;
            this.lbl_serviceType.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lbl_serviceType.Location = new System.Drawing.Point(124, 107);
            this.lbl_serviceType.Name = "lbl_serviceType";
            this.lbl_serviceType.Size = new System.Drawing.Size(83, 14);
            this.lbl_serviceType.TabIndex = 82;
            this.lbl_serviceType.Text = "Service Type:";
            // 
            // txt_pickupDate
            // 
            this.txt_pickupDate.Location = new System.Drawing.Point(213, 140);
            this.txt_pickupDate.Name = "txt_pickupDate";
            this.txt_pickupDate.Size = new System.Drawing.Size(219, 22);
            this.txt_pickupDate.TabIndex = 101;
            // 
            // txt_bookingCreationDate
            // 
            this.txt_bookingCreationDate.Location = new System.Drawing.Point(213, 209);
            this.txt_bookingCreationDate.Name = "txt_bookingCreationDate";
            this.txt_bookingCreationDate.Size = new System.Drawing.Size(219, 22);
            this.txt_bookingCreationDate.TabIndex = 102;
            // 
            // lbl_bookingCreationDateTime
            // 
            this.lbl_bookingCreationDateTime.AutoSize = true;
            this.lbl_bookingCreationDateTime.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lbl_bookingCreationDateTime.Location = new System.Drawing.Point(36, 212);
            this.lbl_bookingCreationDateTime.Name = "lbl_bookingCreationDateTime";
            this.lbl_bookingCreationDateTime.Size = new System.Drawing.Size(171, 14);
            this.lbl_bookingCreationDateTime.TabIndex = 103;
            this.lbl_bookingCreationDateTime.Text = "Booking Creation Date Time:";
            // 
            // txt_postcode
            // 
            this.txt_postcode.Location = new System.Drawing.Point(943, 104);
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(219, 22);
            this.txt_postcode.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.label5.Location = new System.Drawing.Point(880, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 110;
            this.label5.Text = "Postcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.label6.Location = new System.Drawing.Point(890, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 14);
            this.label6.TabIndex = 109;
            this.label6.Text = "Region";
            // 
            // txt_companyName
            // 
            this.txt_companyName.Location = new System.Drawing.Point(616, 103);
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.Size = new System.Drawing.Size(219, 22);
            this.txt_companyName.TabIndex = 105;
            // 
            // lab_CompanyName
            // 
            this.lab_CompanyName.AutoSize = true;
            this.lab_CompanyName.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lab_CompanyName.Location = new System.Drawing.Point(518, 106);
            this.lab_CompanyName.Name = "lab_CompanyName";
            this.lab_CompanyName.Size = new System.Drawing.Size(95, 14);
            this.lab_CompanyName.TabIndex = 107;
            this.lab_CompanyName.Text = "Company Name";
            // 
            // txt_contectName
            // 
            this.txt_contectName.Location = new System.Drawing.Point(616, 69);
            this.txt_contectName.Name = "txt_contectName";
            this.txt_contectName.Size = new System.Drawing.Size(219, 22);
            this.txt_contectName.TabIndex = 104;
            // 
            // lab_contectName
            // 
            this.lab_contectName.AutoSize = true;
            this.lab_contectName.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lab_contectName.Location = new System.Drawing.Point(528, 72);
            this.lab_contectName.Name = "lab_contectName";
            this.lab_contectName.Size = new System.Drawing.Size(85, 14);
            this.lab_contectName.TabIndex = 106;
            this.lab_contectName.Text = "Contect Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 112;
            this.label1.Text = "View Booking Order";
            // 
            // txt_region
            // 
            this.txt_region.Location = new System.Drawing.Point(943, 69);
            this.txt_region.Name = "txt_region";
            this.txt_region.Size = new System.Drawing.Size(219, 22);
            this.txt_region.TabIndex = 113;
            // 
            // btn_viewPackage
            // 
            this.btn_viewPackage.Location = new System.Drawing.Point(616, 278);
            this.btn_viewPackage.Name = "btn_viewPackage";
            this.btn_viewPackage.Size = new System.Drawing.Size(219, 23);
            this.btn_viewPackage.TabIndex = 114;
            this.btn_viewPackage.Text = "View Package";
            this.btn_viewPackage.UseVisualStyleBackColor = true;
            this.btn_viewPackage.Click += new System.EventHandler(this.btn_viewPackage_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1115, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 115;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // CustomerViewBookingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 595);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_viewPackage);
            this.Controls.Add(this.txt_region);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_postcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_companyName);
            this.Controls.Add(this.lab_CompanyName);
            this.Controls.Add(this.txt_contectName);
            this.Controls.Add(this.lab_contectName);
            this.Controls.Add(this.txt_bookingCreationDate);
            this.Controls.Add(this.lbl_bookingCreationDateTime);
            this.Controls.Add(this.txt_pickupDate);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_exitEdit);
            this.Controls.Add(this.btn_cancelBooking);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_telexNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_faxNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_phoneNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pickupTime);
            this.Controls.Add(this.lbl_pickupTime);
            this.Controls.Add(this.lbl_pickupDate);
            this.Controls.Add(this.txt_addr3);
            this.Controls.Add(this.lab_address3);
            this.Controls.Add(this.txt_addr2);
            this.Controls.Add(this.lab_address2);
            this.Controls.Add(this.txt_addr1);
            this.Controls.Add(this.lab_address1);
            this.Controls.Add(this.dgv_bkoList);
            this.Controls.Add(this.txt_serviceType);
            this.Controls.Add(this.txt_bookingID);
            this.Controls.Add(this.lbl_bookingID);
            this.Controls.Add(this.btn_changeAddr);
            this.Controls.Add(this.lbl_serviceType);
            this.Name = "CustomerViewBookingOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - View Booking Order";
            this.Load += new System.EventHandler(this.Customer_ViewBookingOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bkoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_exitEdit;
        private System.Windows.Forms.Button btn_cancelBooking;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_telexNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_faxNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_phoneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pickupTime;
        private System.Windows.Forms.Label lbl_pickupTime;
        private System.Windows.Forms.Label lbl_pickupDate;
        private System.Windows.Forms.TextBox txt_addr3;
        private System.Windows.Forms.Label lab_address3;
        private System.Windows.Forms.TextBox txt_addr2;
        private System.Windows.Forms.Label lab_address2;
        private System.Windows.Forms.TextBox txt_addr1;
        private System.Windows.Forms.Label lab_address1;
        private System.Windows.Forms.DataGridView dgv_bkoList;
        private System.Windows.Forms.TextBox txt_serviceType;
        private System.Windows.Forms.TextBox txt_bookingID;
        private System.Windows.Forms.Label lbl_bookingID;
        private System.Windows.Forms.Button btn_changeAddr;
        private System.Windows.Forms.Label lbl_serviceType;
        private System.Windows.Forms.TextBox txt_pickupDate;
        private System.Windows.Forms.TextBox txt_bookingCreationDate;
        private System.Windows.Forms.Label lbl_bookingCreationDateTime;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_companyName;
        private System.Windows.Forms.Label lab_CompanyName;
        private System.Windows.Forms.TextBox txt_contectName;
        private System.Windows.Forms.Label lab_contectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_region;
        private System.Windows.Forms.Button btn_viewPackage;
        private System.Windows.Forms.Button btn_back;
    }
}