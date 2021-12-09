
namespace EDEapp
{
    partial class EditBookingStaff
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
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lab_region = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtaccID = new System.Windows.Forms.TextBox();
            this.txtbookingID = new System.Windows.Forms.TextBox();
            this.lab_CompanyName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBookingbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripPackagebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripDestinationbtn = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_region = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_companyName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_addrLn3 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_addrLn2 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_addrLn1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telexNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_faxNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_phoneNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_contectName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_pickupTime = new System.Windows.Forms.ComboBox();
            this.cb_pickupDate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbladdressID = new System.Windows.Forms.Label();
            this.txtaddrID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(822, 43);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 41);
            this.btn_return.TabIndex = 53;
            this.btn_return.Text = "<<Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(709, 267);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(132, 23);
            this.btn_cancel.TabIndex = 52;
            this.btn_cancel.Text = "Cancel Edit";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lab_region
            // 
            this.lab_region.AutoSize = true;
            this.lab_region.Location = new System.Drawing.Point(89, 72);
            this.lab_region.Name = "lab_region";
            this.lab_region.Size = new System.Drawing.Size(32, 12);
            this.lab_region.TabIndex = 62;
            this.lab_region.Text = "accID";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(628, 267);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 50;
            this.btn_edit.Text = "Update";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(550, 267);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 51;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(389, 267);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 49;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtaccID
            // 
            this.txtaccID.Location = new System.Drawing.Point(168, 69);
            this.txtaccID.Name = "txtaccID";
            this.txtaccID.Size = new System.Drawing.Size(97, 22);
            this.txtaccID.TabIndex = 42;
            // 
            // txtbookingID
            // 
            this.txtbookingID.Location = new System.Drawing.Point(389, 66);
            this.txtbookingID.Name = "txtbookingID";
            this.txtbookingID.Size = new System.Drawing.Size(97, 22);
            this.txtbookingID.TabIndex = 41;
            // 
            // lab_CompanyName
            // 
            this.lab_CompanyName.AutoSize = true;
            this.lab_CompanyName.Location = new System.Drawing.Point(302, 72);
            this.lab_CompanyName.Name = "lab_CompanyName";
            this.lab_CompanyName.Size = new System.Drawing.Size(56, 12);
            this.lab_CompanyName.TabIndex = 55;
            this.lab_CompanyName.Text = "bookingID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 343);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1320, 407);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 370;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 90;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 140;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(117, 319);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1215, 22);
            this.txtSearch.TabIndex = 70;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 72;
            this.label5.Text = "Search for record:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 764);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 12);
            this.label6.TabIndex = 77;
            this.label6.Text = "***Double click to load a row for edit. When finished, press edit to update the r" +
    "ecord.***";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(470, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 78;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBookingbtn,
            this.toolStripPackagebtn,
            this.toolStripDestinationbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1344, 25);
            this.toolStrip1.TabIndex = 81;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBookingbtn
            // 
            this.toolStripBookingbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBookingbtn.Enabled = false;
            this.toolStripBookingbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBookingbtn.Name = "toolStripBookingbtn";
            this.toolStripBookingbtn.Size = new System.Drawing.Size(78, 22);
            this.toolStripBookingbtn.Text = "&Edit Booking";
            // 
            // toolStripPackagebtn
            // 
            this.toolStripPackagebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripPackagebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPackagebtn.Name = "toolStripPackagebtn";
            this.toolStripPackagebtn.Size = new System.Drawing.Size(78, 22);
            this.toolStripPackagebtn.Text = "&Edit Package";
            this.toolStripPackagebtn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripDestinationbtn
            // 
            this.toolStripDestinationbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDestinationbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDestinationbtn.Name = "toolStripDestinationbtn";
            this.toolStripDestinationbtn.Size = new System.Drawing.Size(118, 22);
            this.toolStripDestinationbtn.Text = "&Edit Destination Info";
            this.toolStripDestinationbtn.Click += new System.EventHandler(this.toolStripDestinationbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EDEapp.Properties.Resources._1131224_200;
            this.pictureBox1.Location = new System.Drawing.Point(1131, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // txt_postcode
            // 
            this.txt_postcode.Location = new System.Drawing.Point(175, 267);
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(192, 22);
            this.txt_postcode.TabIndex = 140;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(84, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 12);
            this.label15.TabIndex = 139;
            this.label15.Text = "Postcode";
            // 
            // txt_region
            // 
            this.txt_region.Location = new System.Drawing.Point(175, 238);
            this.txt_region.Name = "txt_region";
            this.txt_region.Size = new System.Drawing.Size(192, 22);
            this.txt_region.TabIndex = 138;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(84, 242);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 12);
            this.label23.TabIndex = 137;
            this.label23.Text = "Region";
            // 
            // txt_companyName
            // 
            this.txt_companyName.Location = new System.Drawing.Point(175, 126);
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.Size = new System.Drawing.Size(192, 22);
            this.txt_companyName.TabIndex = 136;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(84, 129);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 12);
            this.label24.TabIndex = 135;
            this.label24.Text = "Company Name";
            // 
            // txt_addrLn3
            // 
            this.txt_addrLn3.Location = new System.Drawing.Point(175, 210);
            this.txt_addrLn3.Name = "txt_addrLn3";
            this.txt_addrLn3.Size = new System.Drawing.Size(192, 22);
            this.txt_addrLn3.TabIndex = 134;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(84, 213);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 12);
            this.label26.TabIndex = 133;
            this.label26.Text = "Address Line 3";
            // 
            // txt_addrLn2
            // 
            this.txt_addrLn2.Location = new System.Drawing.Point(175, 183);
            this.txt_addrLn2.Name = "txt_addrLn2";
            this.txt_addrLn2.Size = new System.Drawing.Size(192, 22);
            this.txt_addrLn2.TabIndex = 132;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(84, 186);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(75, 12);
            this.label27.TabIndex = 131;
            this.label27.Text = "Address Line 2";
            // 
            // txt_addrLn1
            // 
            this.txt_addrLn1.Location = new System.Drawing.Point(175, 154);
            this.txt_addrLn1.Name = "txt_addrLn1";
            this.txt_addrLn1.Size = new System.Drawing.Size(192, 22);
            this.txt_addrLn1.TabIndex = 130;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(84, 158);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 12);
            this.label28.TabIndex = 129;
            this.label28.Text = "Address Line 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 128;
            this.label4.Text = "Pickup Address";
            // 
            // txt_telexNo
            // 
            this.txt_telexNo.Location = new System.Drawing.Point(550, 206);
            this.txt_telexNo.Name = "txt_telexNo";
            this.txt_telexNo.Size = new System.Drawing.Size(192, 22);
            this.txt_telexNo.TabIndex = 149;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 12);
            this.label8.TabIndex = 148;
            this.label8.Text = "Telex Number";
            // 
            // txt_faxNo
            // 
            this.txt_faxNo.Location = new System.Drawing.Point(550, 178);
            this.txt_faxNo.Name = "txt_faxNo";
            this.txt_faxNo.Size = new System.Drawing.Size(192, 22);
            this.txt_faxNo.TabIndex = 147;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 12);
            this.label10.TabIndex = 146;
            this.label10.Text = "Fax Number";
            // 
            // txt_phoneNo
            // 
            this.txt_phoneNo.Location = new System.Drawing.Point(550, 150);
            this.txt_phoneNo.Name = "txt_phoneNo";
            this.txt_phoneNo.Size = new System.Drawing.Size(192, 22);
            this.txt_phoneNo.TabIndex = 145;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(459, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 12);
            this.label11.TabIndex = 144;
            this.label11.Text = "Phone Number";
            // 
            // txt_contectName
            // 
            this.txt_contectName.Location = new System.Drawing.Point(550, 122);
            this.txt_contectName.Name = "txt_contectName";
            this.txt_contectName.Size = new System.Drawing.Size(192, 22);
            this.txt_contectName.TabIndex = 143;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(459, 125);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 12);
            this.label25.TabIndex = 142;
            this.label25.Text = "Contect Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 12);
            this.label9.TabIndex = 141;
            this.label9.Text = "Contact Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1106, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 150;
            this.label1.Text = "Pickup Order (Sender)";
            // 
            // cb_pickupTime
            // 
            this.cb_pickupTime.FormattingEnabled = true;
            this.cb_pickupTime.Location = new System.Drawing.Point(720, 237);
            this.cb_pickupTime.Name = "cb_pickupTime";
            this.cb_pickupTime.Size = new System.Drawing.Size(121, 20);
            this.cb_pickupTime.TabIndex = 155;
            // 
            // cb_pickupDate
            // 
            this.cb_pickupDate.FormattingEnabled = true;
            this.cb_pickupDate.Location = new System.Drawing.Point(517, 237);
            this.cb_pickupDate.Name = "cb_pickupDate";
            this.cb_pickupDate.Size = new System.Drawing.Size(121, 20);
            this.cb_pickupDate.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(648, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 153;
            this.label2.Text = "Pickup Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(445, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 151;
            this.label12.Text = "Pickup Date";
            // 
            // lbladdressID
            // 
            this.lbladdressID.AutoSize = true;
            this.lbladdressID.Location = new System.Drawing.Point(538, 72);
            this.lbladdressID.Name = "lbladdressID";
            this.lbladdressID.Size = new System.Drawing.Size(51, 12);
            this.lbladdressID.TabIndex = 157;
            this.lbladdressID.Text = "addressID";
            // 
            // txtaddrID
            // 
            this.txtaddrID.Location = new System.Drawing.Point(617, 69);
            this.txtaddrID.Name = "txtaddrID";
            this.txtaddrID.Size = new System.Drawing.Size(97, 22);
            this.txtaddrID.TabIndex = 156;
            // 
            // EditBookingStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 785);
            this.Controls.Add(this.lbladdressID);
            this.Controls.Add(this.txtaddrID);
            this.Controls.Add(this.cb_pickupTime);
            this.Controls.Add(this.cb_pickupDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_telexNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_faxNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_phoneNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_contectName);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_postcode);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_region);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txt_companyName);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txt_addrLn3);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txt_addrLn2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txt_addrLn1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lab_region);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtaccID);
            this.Controls.Add(this.txtbookingID);
            this.Controls.Add(this.lab_CompanyName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditBookingStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Booking (Staff)";
            this.Load += new System.EventHandler(this.EditPackageStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lab_region;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtaccID;
        private System.Windows.Forms.TextBox txtbookingID;
        private System.Windows.Forms.Label lab_CompanyName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripBookingbtn;
        private System.Windows.Forms.ToolStripButton toolStripPackagebtn;
        private System.Windows.Forms.ToolStripButton toolStripDestinationbtn;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_region;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_companyName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_addrLn3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txt_addrLn2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_addrLn1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telexNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_faxNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_phoneNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_contectName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_pickupTime;
        private System.Windows.Forms.ComboBox cb_pickupDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbladdressID;
        private System.Windows.Forms.TextBox txtaddrID;
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
    }
}