
namespace EDEapp
{
    partial class AddressBook_Pickup
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
            this.dgv_addrBook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_selectAddr = new System.Windows.Forms.Button();
            this.lbl_announcement = new System.Windows.Forms.Label();
            this.lab_contectName = new System.Windows.Forms.Label();
            this.txt_contectName = new System.Windows.Forms.TextBox();
            this.lab_CompanyName = new System.Windows.Forms.Label();
            this.txt_companyName = new System.Windows.Forms.TextBox();
            this.lab_address1 = new System.Windows.Forms.Label();
            this.txt_addr1 = new System.Windows.Forms.TextBox();
            this.lab_address2 = new System.Windows.Forms.Label();
            this.txt_addr2 = new System.Windows.Forms.TextBox();
            this.lab_address3 = new System.Windows.Forms.Label();
            this.txt_addr3 = new System.Windows.Forms.TextBox();
            this.txt_telexNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_faxNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_phoneNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_region = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addrBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_addrBook
            // 
            this.dgv_addrBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addrBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgv_addrBook.Location = new System.Drawing.Point(21, 284);
            this.dgv_addrBook.Name = "dgv_addrBook";
            this.dgv_addrBook.RowTemplate.Height = 24;
            this.dgv_addrBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_addrBook.Size = new System.Drawing.Size(1044, 198);
            this.dgv_addrBook.TabIndex = 4;
            this.dgv_addrBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_addrBook_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(21, 43);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(105, 23);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_selectAddr
            // 
            this.btn_selectAddr.Location = new System.Drawing.Point(960, 255);
            this.btn_selectAddr.Name = "btn_selectAddr";
            this.btn_selectAddr.Size = new System.Drawing.Size(105, 23);
            this.btn_selectAddr.TabIndex = 6;
            this.btn_selectAddr.Text = "Select Address";
            this.btn_selectAddr.UseVisualStyleBackColor = true;
            this.btn_selectAddr.Click += new System.EventHandler(this.btn_selectAddr_Click);
            // 
            // lbl_announcement
            // 
            this.lbl_announcement.AutoSize = true;
            this.lbl_announcement.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_announcement.Location = new System.Drawing.Point(19, 14);
            this.lbl_announcement.Name = "lbl_announcement";
            this.lbl_announcement.Size = new System.Drawing.Size(322, 16);
            this.lbl_announcement.TabIndex = 5;
            this.lbl_announcement.Text = "Please select one address for your package.";
            // 
            // lab_contectName
            // 
            this.lab_contectName.AutoSize = true;
            this.lab_contectName.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lab_contectName.Location = new System.Drawing.Point(182, 79);
            this.lab_contectName.Name = "lab_contectName";
            this.lab_contectName.Size = new System.Drawing.Size(85, 14);
            this.lab_contectName.TabIndex = 51;
            this.lab_contectName.Text = "Contect Name";
            // 
            // txt_contectName
            // 
            this.txt_contectName.Location = new System.Drawing.Point(270, 76);
            this.txt_contectName.Name = "txt_contectName";
            this.txt_contectName.Size = new System.Drawing.Size(219, 22);
            this.txt_contectName.TabIndex = 41;
            // 
            // lab_CompanyName
            // 
            this.lab_CompanyName.AutoSize = true;
            this.lab_CompanyName.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lab_CompanyName.Location = new System.Drawing.Point(172, 113);
            this.lab_CompanyName.Name = "lab_CompanyName";
            this.lab_CompanyName.Size = new System.Drawing.Size(95, 14);
            this.lab_CompanyName.TabIndex = 52;
            this.lab_CompanyName.Text = "Company Name";
            // 
            // txt_companyName
            // 
            this.txt_companyName.Location = new System.Drawing.Point(270, 110);
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.Size = new System.Drawing.Size(219, 22);
            this.txt_companyName.TabIndex = 42;
            // 
            // lab_address1
            // 
            this.lab_address1.AutoSize = true;
            this.lab_address1.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lab_address1.Location = new System.Drawing.Point(178, 147);
            this.lab_address1.Name = "lab_address1";
            this.lab_address1.Size = new System.Drawing.Size(90, 14);
            this.lab_address1.TabIndex = 53;
            this.lab_address1.Text = "Address Line 1";
            // 
            // txt_addr1
            // 
            this.txt_addr1.Location = new System.Drawing.Point(270, 144);
            this.txt_addr1.Name = "txt_addr1";
            this.txt_addr1.Size = new System.Drawing.Size(219, 22);
            this.txt_addr1.TabIndex = 43;
            // 
            // lab_address2
            // 
            this.lab_address2.AutoSize = true;
            this.lab_address2.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lab_address2.Location = new System.Drawing.Point(178, 183);
            this.lab_address2.Name = "lab_address2";
            this.lab_address2.Size = new System.Drawing.Size(90, 14);
            this.lab_address2.TabIndex = 54;
            this.lab_address2.Text = "Address Line 2";
            // 
            // txt_addr2
            // 
            this.txt_addr2.Location = new System.Drawing.Point(270, 180);
            this.txt_addr2.Name = "txt_addr2";
            this.txt_addr2.Size = new System.Drawing.Size(219, 22);
            this.txt_addr2.TabIndex = 44;
            // 
            // lab_address3
            // 
            this.lab_address3.AutoSize = true;
            this.lab_address3.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.lab_address3.Location = new System.Drawing.Point(178, 220);
            this.lab_address3.Name = "lab_address3";
            this.lab_address3.Size = new System.Drawing.Size(90, 14);
            this.lab_address3.TabIndex = 55;
            this.lab_address3.Text = "Address Line 3";
            // 
            // txt_addr3
            // 
            this.txt_addr3.Location = new System.Drawing.Point(270, 217);
            this.txt_addr3.Name = "txt_addr3";
            this.txt_addr3.Size = new System.Drawing.Size(219, 22);
            this.txt_addr3.TabIndex = 45;
            // 
            // txt_telexNo
            // 
            this.txt_telexNo.Location = new System.Drawing.Point(628, 217);
            this.txt_telexNo.Name = "txt_telexNo";
            this.txt_telexNo.Size = new System.Drawing.Size(219, 22);
            this.txt_telexNo.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.label2.Location = new System.Drawing.Point(537, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 14);
            this.label2.TabIndex = 65;
            this.label2.Text = "Telex Number";
            // 
            // txt_faxNo
            // 
            this.txt_faxNo.Location = new System.Drawing.Point(628, 180);
            this.txt_faxNo.Name = "txt_faxNo";
            this.txt_faxNo.Size = new System.Drawing.Size(219, 22);
            this.txt_faxNo.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.label3.Location = new System.Drawing.Point(547, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 64;
            this.label3.Text = "Fax Number";
            // 
            // txt_phoneNo
            // 
            this.txt_phoneNo.Location = new System.Drawing.Point(628, 144);
            this.txt_phoneNo.Name = "txt_phoneNo";
            this.txt_phoneNo.Size = new System.Drawing.Size(219, 22);
            this.txt_phoneNo.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.label4.Location = new System.Drawing.Point(534, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 14);
            this.label4.TabIndex = 63;
            this.label4.Text = "Phone Number";
            // 
            // txt_postcode
            // 
            this.txt_postcode.Location = new System.Drawing.Point(628, 110);
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(219, 22);
            this.txt_postcode.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.label5.Location = new System.Drawing.Point(565, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 62;
            this.label5.Text = "Postcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.label6.Location = new System.Drawing.Point(575, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 14);
            this.label6.TabIndex = 61;
            this.label6.Text = "Region";
            // 
            // cb_region
            // 
            this.cb_region.FormattingEnabled = true;
            this.cb_region.Location = new System.Drawing.Point(628, 76);
            this.cb_region.Name = "cb_region";
            this.cb_region.Size = new System.Drawing.Size(219, 20);
            this.cb_region.TabIndex = 66;
            this.cb_region.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_region_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(270, 255);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 23);
            this.btn_add.TabIndex = 67;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(540, 255);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 23);
            this.btn_update.TabIndex = 68;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(651, 255);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 23);
            this.btn_delete.TabIndex = 69;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(799, 255);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 23);
            this.btn_cancel.TabIndex = 70;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(429, 255);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(105, 23);
            this.btn_edit.TabIndex = 71;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // AddressBook_Pickup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 494);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_region);
            this.Controls.Add(this.txt_telexNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_faxNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_phoneNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_postcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_addr3);
            this.Controls.Add(this.lab_address3);
            this.Controls.Add(this.txt_addr2);
            this.Controls.Add(this.lab_address2);
            this.Controls.Add(this.txt_addr1);
            this.Controls.Add(this.lab_address1);
            this.Controls.Add(this.txt_companyName);
            this.Controls.Add(this.lab_CompanyName);
            this.Controls.Add(this.txt_contectName);
            this.Controls.Add(this.lab_contectName);
            this.Controls.Add(this.dgv_addrBook);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_selectAddr);
            this.Controls.Add(this.lbl_announcement);
            this.Name = "AddressBook_Pickup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDE - Create Booking - Pickup Information - Select Address";
            this.Load += new System.EventHandler(this.AddressBook_Pickup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addrBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_addrBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_selectAddr;
        private System.Windows.Forms.Label lbl_announcement;
        private System.Windows.Forms.Label lab_contectName;
        private System.Windows.Forms.TextBox txt_contectName;
        private System.Windows.Forms.Label lab_CompanyName;
        private System.Windows.Forms.TextBox txt_companyName;
        private System.Windows.Forms.Label lab_address1;
        private System.Windows.Forms.TextBox txt_addr1;
        private System.Windows.Forms.Label lab_address2;
        private System.Windows.Forms.TextBox txt_addr2;
        private System.Windows.Forms.Label lab_address3;
        private System.Windows.Forms.TextBox txt_addr3;
        private System.Windows.Forms.TextBox txt_telexNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_faxNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_phoneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_region;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_edit;
    }
}