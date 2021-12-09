
namespace EDEapp
{
    partial class CustomerAddressBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telexNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.lab_faxNo = new System.Windows.Forms.Label();
            this.txt_faxNo = new System.Windows.Forms.TextBox();
            this.txt_phoneNo = new System.Windows.Forms.TextBox();
            this.lab_phoneNo = new System.Windows.Forms.Label();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.lab_postcode = new System.Windows.Forms.Label();
            this.txt_Address3 = new System.Windows.Forms.TextBox();
            this.lab_address3 = new System.Windows.Forms.Label();
            this.txt_Address2 = new System.Windows.Forms.TextBox();
            this.lab_address2 = new System.Windows.Forms.Label();
            this.txt_Address1 = new System.Windows.Forms.TextBox();
            this.lab_address1 = new System.Windows.Forms.Label();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.lab_CompanyName = new System.Windows.Forms.Label();
            this.txt_ContentName = new System.Windows.Forms.TextBox();
            this.lab_contectName = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.comboBox_region = new System.Windows.Forms.ComboBox();
            this.lab_region = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.lab_telephone = new System.Windows.Forms.Label();
            this.txt_telexNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressId,
            this.contectName,
            this.companyName,
            this.addressLn1,
            this.addressLn2,
            this.addressLn3,
            this.region,
            this.postcode,
            this.phoneNo,
            this.faxNo,
            this.telexNo});
            this.dataGridView1.Location = new System.Drawing.Point(9, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(890, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // addressId
            // 
            this.addressId.DataPropertyName = "addressId";
            this.addressId.HeaderText = "addressId";
            this.addressId.Name = "addressId";
            this.addressId.ReadOnly = true;
            this.addressId.Visible = false;
            this.addressId.Width = 80;
            // 
            // contectName
            // 
            this.contectName.HeaderText = "contectName";
            this.contectName.Name = "contectName";
            this.contectName.ReadOnly = true;
            this.contectName.Width = 80;
            // 
            // companyName
            // 
            this.companyName.HeaderText = "companyName";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            this.companyName.Width = 90;
            // 
            // addressLn1
            // 
            this.addressLn1.HeaderText = "addressLn1";
            this.addressLn1.Name = "addressLn1";
            this.addressLn1.ReadOnly = true;
            this.addressLn1.Width = 90;
            // 
            // addressLn2
            // 
            this.addressLn2.HeaderText = "addressLn2";
            this.addressLn2.Name = "addressLn2";
            this.addressLn2.ReadOnly = true;
            this.addressLn2.Width = 90;
            // 
            // addressLn3
            // 
            this.addressLn3.HeaderText = "addressLn3";
            this.addressLn3.Name = "addressLn3";
            this.addressLn3.ReadOnly = true;
            this.addressLn3.Width = 90;
            // 
            // region
            // 
            this.region.HeaderText = "region";
            this.region.Name = "region";
            this.region.ReadOnly = true;
            this.region.Width = 90;
            // 
            // postcode
            // 
            this.postcode.HeaderText = "postcode";
            this.postcode.Name = "postcode";
            this.postcode.ReadOnly = true;
            this.postcode.Width = 80;
            // 
            // phoneNo
            // 
            this.phoneNo.HeaderText = "phoneNo";
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.ReadOnly = true;
            this.phoneNo.Width = 80;
            // 
            // faxNo
            // 
            this.faxNo.HeaderText = "faxNo";
            this.faxNo.Name = "faxNo";
            this.faxNo.ReadOnly = true;
            this.faxNo.Width = 80;
            // 
            // telexNo
            // 
            this.telexNo.HeaderText = "telexNo";
            this.telexNo.Name = "telexNo";
            this.telexNo.ReadOnly = true;
            this.telexNo.Width = 80;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(579, 193);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lab_faxNo
            // 
            this.lab_faxNo.AutoSize = true;
            this.lab_faxNo.Location = new System.Drawing.Point(373, 132);
            this.lab_faxNo.Name = "lab_faxNo";
            this.lab_faxNo.Size = new System.Drawing.Size(36, 12);
            this.lab_faxNo.TabIndex = 32;
            this.lab_faxNo.Text = "FaxNo";
            // 
            // txt_faxNo
            // 
            this.txt_faxNo.Location = new System.Drawing.Point(452, 129);
            this.txt_faxNo.Name = "txt_faxNo";
            this.txt_faxNo.Size = new System.Drawing.Size(219, 22);
            this.txt_faxNo.TabIndex = 9;
            this.txt_faxNo.TextChanged += new System.EventHandler(this.txt_faxNo_TextChanged);
            this.txt_faxNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_faxNo_KeyPress);
            // 
            // txt_phoneNo
            // 
            this.txt_phoneNo.Location = new System.Drawing.Point(452, 89);
            this.txt_phoneNo.Name = "txt_phoneNo";
            this.txt_phoneNo.Size = new System.Drawing.Size(219, 22);
            this.txt_phoneNo.TabIndex = 8;
            this.txt_phoneNo.TextChanged += new System.EventHandler(this.txt_phoneNo_TextChanged);
            this.txt_phoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phoneNo_KeyPress);
            // 
            // lab_phoneNo
            // 
            this.lab_phoneNo.AutoSize = true;
            this.lab_phoneNo.Location = new System.Drawing.Point(373, 96);
            this.lab_phoneNo.Name = "lab_phoneNo";
            this.lab_phoneNo.Size = new System.Drawing.Size(48, 12);
            this.lab_phoneNo.TabIndex = 29;
            this.lab_phoneNo.Text = "PhoneNo";
            // 
            // txt_postcode
            // 
            this.txt_postcode.Location = new System.Drawing.Point(452, 53);
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(219, 22);
            this.txt_postcode.TabIndex = 7;
            this.txt_postcode.TextChanged += new System.EventHandler(this.txt_postcode_TextChanged);
            this.txt_postcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_postcode_KeyPress);
            // 
            // lab_postcode
            // 
            this.lab_postcode.AutoSize = true;
            this.lab_postcode.Location = new System.Drawing.Point(373, 59);
            this.lab_postcode.Name = "lab_postcode";
            this.lab_postcode.Size = new System.Drawing.Size(46, 12);
            this.lab_postcode.TabIndex = 27;
            this.lab_postcode.Text = "Postcode";
            // 
            // txt_Address3
            // 
            this.txt_Address3.Location = new System.Drawing.Point(131, 175);
            this.txt_Address3.Name = "txt_Address3";
            this.txt_Address3.Size = new System.Drawing.Size(219, 22);
            this.txt_Address3.TabIndex = 5;
            this.txt_Address3.TextChanged += new System.EventHandler(this.txt_Address3_TextChanged);
            // 
            // lab_address3
            // 
            this.lab_address3.AutoSize = true;
            this.lab_address3.Location = new System.Drawing.Point(40, 180);
            this.lab_address3.Name = "lab_address3";
            this.lab_address3.Size = new System.Drawing.Size(61, 12);
            this.lab_address3.TabIndex = 25;
            this.lab_address3.Text = "AddressLn3";
            // 
            // txt_Address2
            // 
            this.txt_Address2.Location = new System.Drawing.Point(131, 129);
            this.txt_Address2.Name = "txt_Address2";
            this.txt_Address2.Size = new System.Drawing.Size(219, 22);
            this.txt_Address2.TabIndex = 4;
            // 
            // lab_address2
            // 
            this.lab_address2.AutoSize = true;
            this.lab_address2.Location = new System.Drawing.Point(40, 132);
            this.lab_address2.Name = "lab_address2";
            this.lab_address2.Size = new System.Drawing.Size(61, 12);
            this.lab_address2.TabIndex = 23;
            this.lab_address2.Text = "AddressLn2";
            // 
            // txt_Address1
            // 
            this.txt_Address1.Location = new System.Drawing.Point(131, 89);
            this.txt_Address1.Name = "txt_Address1";
            this.txt_Address1.Size = new System.Drawing.Size(219, 22);
            this.txt_Address1.TabIndex = 3;
            this.txt_Address1.TextChanged += new System.EventHandler(this.txt_Address1_TextChanged);
            // 
            // lab_address1
            // 
            this.lab_address1.AutoSize = true;
            this.lab_address1.Location = new System.Drawing.Point(40, 92);
            this.lab_address1.Name = "lab_address1";
            this.lab_address1.Size = new System.Drawing.Size(61, 12);
            this.lab_address1.TabIndex = 21;
            this.lab_address1.Text = "AddressLn1";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Location = new System.Drawing.Point(131, 53);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(219, 22);
            this.txt_CompanyName.TabIndex = 2;
            // 
            // lab_CompanyName
            // 
            this.lab_CompanyName.AutoSize = true;
            this.lab_CompanyName.Location = new System.Drawing.Point(40, 53);
            this.lab_CompanyName.Name = "lab_CompanyName";
            this.lab_CompanyName.Size = new System.Drawing.Size(81, 12);
            this.lab_CompanyName.TabIndex = 19;
            this.lab_CompanyName.Text = "Company Name";
            // 
            // txt_ContentName
            // 
            this.txt_ContentName.Location = new System.Drawing.Point(131, 16);
            this.txt_ContentName.Name = "txt_ContentName";
            this.txt_ContentName.Size = new System.Drawing.Size(219, 22);
            this.txt_ContentName.TabIndex = 1;
            // 
            // lab_contectName
            // 
            this.lab_contectName.AutoSize = true;
            this.lab_contectName.Location = new System.Drawing.Point(40, 19);
            this.lab_contectName.Name = "lab_contectName";
            this.lab_contectName.Size = new System.Drawing.Size(71, 12);
            this.lab_contectName.TabIndex = 18;
            this.lab_contectName.Text = "Contect Name";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(741, 193);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(660, 193);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // comboBox_region
            // 
            this.comboBox_region.FormattingEnabled = true;
            this.comboBox_region.Location = new System.Drawing.Point(452, 16);
            this.comboBox_region.Name = "comboBox_region";
            this.comboBox_region.Size = new System.Drawing.Size(219, 20);
            this.comboBox_region.TabIndex = 6;
            this.comboBox_region.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_region_KeyPress);
            // 
            // lab_region
            // 
            this.lab_region.AutoSize = true;
            this.lab_region.Location = new System.Drawing.Point(373, 20);
            this.lab_region.Name = "lab_region";
            this.lab_region.Size = new System.Drawing.Size(39, 12);
            this.lab_region.TabIndex = 38;
            this.lab_region.Text = "Region";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(819, 193);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(819, 5);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 41);
            this.btn_return.TabIndex = 15;
            this.btn_return.Text = "<<Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // lab_telephone
            // 
            this.lab_telephone.AutoSize = true;
            this.lab_telephone.Location = new System.Drawing.Point(373, 168);
            this.lab_telephone.Name = "lab_telephone";
            this.lab_telephone.Size = new System.Drawing.Size(41, 12);
            this.lab_telephone.TabIndex = 40;
            this.lab_telephone.Text = "telexNo";
            // 
            // txt_telexNo
            // 
            this.txt_telexNo.Location = new System.Drawing.Point(452, 165);
            this.txt_telexNo.Name = "txt_telexNo";
            this.txt_telexNo.Size = new System.Drawing.Size(219, 22);
            this.txt_telexNo.TabIndex = 10;
            this.txt_telexNo.TextChanged += new System.EventHandler(this.txt_telexNo_TextChanged);
            this.txt_telexNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telexNo_KeyPress);
            // 
            // CustomerAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 483);
            this.Controls.Add(this.lab_telephone);
            this.Controls.Add(this.txt_telexNo);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lab_region);
            this.Controls.Add(this.comboBox_region);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lab_faxNo);
            this.Controls.Add(this.txt_faxNo);
            this.Controls.Add(this.txt_phoneNo);
            this.Controls.Add(this.lab_phoneNo);
            this.Controls.Add(this.txt_postcode);
            this.Controls.Add(this.lab_postcode);
            this.Controls.Add(this.txt_Address3);
            this.Controls.Add(this.lab_address3);
            this.Controls.Add(this.txt_Address2);
            this.Controls.Add(this.lab_address2);
            this.Controls.Add(this.txt_Address1);
            this.Controls.Add(this.lab_address1);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.lab_CompanyName);
            this.Controls.Add(this.txt_ContentName);
            this.Controls.Add(this.lab_contectName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerAddressBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerAddressBook";
            this.Load += new System.EventHandler(this.CustomerAddressBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lab_faxNo;
        private System.Windows.Forms.TextBox txt_faxNo;
        private System.Windows.Forms.TextBox txt_phoneNo;
        private System.Windows.Forms.Label lab_phoneNo;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.Label lab_postcode;
        private System.Windows.Forms.TextBox txt_Address3;
        private System.Windows.Forms.Label lab_address3;
        private System.Windows.Forms.TextBox txt_Address2;
        private System.Windows.Forms.Label lab_address2;
        private System.Windows.Forms.TextBox txt_Address1;
        private System.Windows.Forms.Label lab_address1;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.Label lab_CompanyName;
        private System.Windows.Forms.TextBox txt_ContentName;
        private System.Windows.Forms.Label lab_contectName;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox comboBox_region;
        private System.Windows.Forms.Label lab_region;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label lab_telephone;
        private System.Windows.Forms.TextBox txt_telexNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressId;
        private System.Windows.Forms.DataGridViewTextBoxColumn contectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telexNo;
    }
}