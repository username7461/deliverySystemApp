
namespace EDEapp
{
    partial class EditPackageStaff
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
            this.cb_serviceType = new System.Windows.Forms.ComboBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtpkgName = new System.Windows.Forms.TextBox();
            this.lab_postcode = new System.Windows.Forms.Label();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtaccID = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.Label();
            this.txtbookingID = new System.Windows.Forms.TextBox();
            this.lab_CompanyName = new System.Windows.Forms.Label();
            this.txtpkgID = new System.Windows.Forms.TextBox();
            this.lab_contectName = new System.Windows.Forms.Label();
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
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rad_pkgTypeEnvelope = new System.Windows.Forms.RadioButton();
            this.rad_pkgTypeFreight = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitVal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDummyBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBookingbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripPackagebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripDestinationbtn = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(762, 52);
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
            this.lab_region.Location = new System.Drawing.Point(58, 58);
            this.lab_region.Name = "lab_region";
            this.lab_region.Size = new System.Drawing.Size(32, 12);
            this.lab_region.TabIndex = 62;
            this.lab_region.Text = "accID";
            // 
            // cb_serviceType
            // 
            this.cb_serviceType.FormattingEnabled = true;
            this.cb_serviceType.Location = new System.Drawing.Point(137, 159);
            this.cb_serviceType.Name = "cb_serviceType";
            this.cb_serviceType.Size = new System.Drawing.Size(203, 20);
            this.cb_serviceType.TabIndex = 45;
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
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(137, 126);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(87, 22);
            this.txtQuantity.TabIndex = 47;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(58, 128);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(45, 12);
            this.lblQuantity.TabIndex = 60;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtpkgName
            // 
            this.txtpkgName.Location = new System.Drawing.Point(137, 91);
            this.txtpkgName.Name = "txtpkgName";
            this.txtpkgName.Size = new System.Drawing.Size(237, 22);
            this.txtpkgName.TabIndex = 46;
            // 
            // lab_postcode
            // 
            this.lab_postcode.AutoSize = true;
            this.lab_postcode.Location = new System.Drawing.Point(46, 95);
            this.lab_postcode.Name = "lab_postcode";
            this.lab_postcode.Size = new System.Drawing.Size(73, 12);
            this.lab_postcode.TabIndex = 59;
            this.lab_postcode.Text = "Package Name";
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(137, 198);
            this.txt_Remark.Multiline = true;
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(237, 93);
            this.txt_Remark.TabIndex = 43;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(58, 200);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(42, 12);
            this.lblRemark.TabIndex = 57;
            this.lblRemark.Text = "Remark";
            // 
            // txtaccID
            // 
            this.txtaccID.Location = new System.Drawing.Point(137, 55);
            this.txtaccID.Name = "txtaccID";
            this.txtaccID.Size = new System.Drawing.Size(97, 22);
            this.txtaccID.TabIndex = 42;
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Location = new System.Drawing.Point(50, 162);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(66, 12);
            this.txtType.TabIndex = 56;
            this.txtType.Text = "Service Type";
            // 
            // txtbookingID
            // 
            this.txtbookingID.Location = new System.Drawing.Point(358, 52);
            this.txtbookingID.Name = "txtbookingID";
            this.txtbookingID.Size = new System.Drawing.Size(97, 22);
            this.txtbookingID.TabIndex = 41;
            // 
            // lab_CompanyName
            // 
            this.lab_CompanyName.AutoSize = true;
            this.lab_CompanyName.Location = new System.Drawing.Point(271, 58);
            this.lab_CompanyName.Name = "lab_CompanyName";
            this.lab_CompanyName.Size = new System.Drawing.Size(56, 12);
            this.lab_CompanyName.TabIndex = 55;
            this.lab_CompanyName.Text = "bookingID";
            // 
            // txtpkgID
            // 
            this.txtpkgID.Location = new System.Drawing.Point(573, 52);
            this.txtpkgID.Name = "txtpkgID";
            this.txtpkgID.Size = new System.Drawing.Size(97, 22);
            this.txtpkgID.TabIndex = 40;
            // 
            // lab_contectName
            // 
            this.lab_contectName.AutoSize = true;
            this.lab_contectName.Location = new System.Drawing.Point(482, 54);
            this.lab_contectName.Name = "lab_contectName";
            this.lab_contectName.Size = new System.Drawing.Size(55, 12);
            this.lab_contectName.TabIndex = 54;
            this.lab_contectName.Text = "packageID";
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
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(12, 343);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1170, 346);
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
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 55;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
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
            this.Column10.HeaderText = "unitValue";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 600;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(274, 126);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(87, 22);
            this.txtUnit.TabIndex = 63;
            this.txtUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnit_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 64;
            this.label1.Text = "(Unit)";
            // 
            // rad_pkgTypeEnvelope
            // 
            this.rad_pkgTypeEnvelope.AutoSize = true;
            this.rad_pkgTypeEnvelope.Location = new System.Drawing.Point(546, 91);
            this.rad_pkgTypeEnvelope.Name = "rad_pkgTypeEnvelope";
            this.rad_pkgTypeEnvelope.Size = new System.Drawing.Size(121, 16);
            this.rad_pkgTypeEnvelope.TabIndex = 65;
            this.rad_pkgTypeEnvelope.TabStop = true;
            this.rad_pkgTypeEnvelope.Text = "Document/ Envelope";
            this.rad_pkgTypeEnvelope.UseVisualStyleBackColor = true;
            this.rad_pkgTypeEnvelope.CheckedChanged += new System.EventHandler(this.rad_pkgTypeEnvelope_CheckedChanged);
            // 
            // rad_pkgTypeFreight
            // 
            this.rad_pkgTypeFreight.AutoSize = true;
            this.rad_pkgTypeFreight.Location = new System.Drawing.Point(465, 93);
            this.rad_pkgTypeFreight.Name = "rad_pkgTypeFreight";
            this.rad_pkgTypeFreight.Size = new System.Drawing.Size(56, 16);
            this.rad_pkgTypeFreight.TabIndex = 66;
            this.rad_pkgTypeFreight.TabStop = true;
            this.rad_pkgTypeFreight.Text = "Freight";
            this.rad_pkgTypeFreight.UseVisualStyleBackColor = true;
            this.rad_pkgTypeFreight.CheckedChanged += new System.EventHandler(this.rad_pkgTypeFreight_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 67;
            this.label2.Text = "Airway type";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(117, 319);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1065, 22);
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
            // txtUnitVal
            // 
            this.txtUnitVal.Location = new System.Drawing.Point(483, 127);
            this.txtUnitVal.Name = "txtUnitVal";
            this.txtUnitVal.Size = new System.Drawing.Size(87, 22);
            this.txtUnitVal.TabIndex = 73;
            this.txtUnitVal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtUnitVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 74;
            this.label3.Text = "x Unit Value $HKD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 12);
            this.label4.TabIndex = 75;
            this.label4.Text = "= Total Value";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(657, 127);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 701);
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
            // txtDummyBox
            // 
            this.txtDummyBox.Location = new System.Drawing.Point(137, 160);
            this.txtDummyBox.Name = "txtDummyBox";
            this.txtDummyBox.ReadOnly = true;
            this.txtDummyBox.Size = new System.Drawing.Size(204, 22);
            this.txtDummyBox.TabIndex = 79;
            this.txtDummyBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDummyBox_MouseClick);
            this.txtDummyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDummyBox_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBookingbtn,
            this.toolStripPackagebtn,
            this.toolStripDestinationbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1195, 25);
            this.toolStrip1.TabIndex = 81;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBookingbtn
            // 
            this.toolStripBookingbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBookingbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBookingbtn.Name = "toolStripBookingbtn";
            this.toolStripBookingbtn.Size = new System.Drawing.Size(78, 22);
            this.toolStripBookingbtn.Text = "&Edit Booking";
            this.toolStripBookingbtn.Click += new System.EventHandler(this.toolStripBookingbtn_Click);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(978, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 151;
            this.label7.Text = "Package Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EDEapp.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(965, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // EditPackageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 727);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtDummyBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUnitVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rad_pkgTypeFreight);
            this.Controls.Add(this.rad_pkgTypeEnvelope);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lab_region);
            this.Controls.Add(this.cb_serviceType);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtpkgName);
            this.Controls.Add(this.lab_postcode);
            this.Controls.Add(this.txt_Remark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtaccID);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtbookingID);
            this.Controls.Add(this.lab_CompanyName);
            this.Controls.Add(this.txtpkgID);
            this.Controls.Add(this.lab_contectName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditPackageStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Package (Staff)";
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
        private System.Windows.Forms.ComboBox cb_serviceType;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtpkgName;
        private System.Windows.Forms.Label lab_postcode;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtaccID;
        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.TextBox txtbookingID;
        private System.Windows.Forms.Label lab_CompanyName;
        private System.Windows.Forms.TextBox txtpkgID;
        private System.Windows.Forms.Label lab_contectName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_pkgTypeEnvelope;
        private System.Windows.Forms.RadioButton rad_pkgTypeFreight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnitVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDummyBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripBookingbtn;
        private System.Windows.Forms.ToolStripButton toolStripPackagebtn;
        private System.Windows.Forms.ToolStripButton toolStripDestinationbtn;
        private System.Windows.Forms.Label label7;
    }
}