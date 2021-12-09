
namespace EDEapp
{
    partial class EditDeliveryStatus
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
            this.lbl_accID = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txtpkgName = new System.Windows.Forms.TextBox();
            this.lab_postcode = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkIsImport = new System.Windows.Forms.CheckBox();
            this.chkConfirmDelivered = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_pkgStatus = new System.Windows.Forms.ToolStripButton();
            this.tsb_airwaybill = new System.Windows.Forms.ToolStripButton();
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
            this.btn_cancel.Location = new System.Drawing.Point(513, 243);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(118, 23);
            this.btn_cancel.TabIndex = 52;
            this.btn_cancel.Text = "Cancel Edit";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_accID
            // 
            this.lbl_accID.AutoSize = true;
            this.lbl_accID.Location = new System.Drawing.Point(250, 57);
            this.lbl_accID.Name = "lbl_accID";
            this.lbl_accID.Size = new System.Drawing.Size(62, 12);
            this.lbl_accID.TabIndex = 62;
            this.lbl_accID.Text = "Account ID:";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(137, 134);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(362, 20);
            this.cbStatus.TabIndex = 45;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(432, 243);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(67, 23);
            this.btn_edit.TabIndex = 50;
            this.btn_edit.Text = "Update";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txtpkgName
            // 
            this.txtpkgName.Location = new System.Drawing.Point(137, 91);
            this.txtpkgName.Name = "txtpkgName";
            this.txtpkgName.Size = new System.Drawing.Size(253, 22);
            this.txtpkgName.TabIndex = 46;
            // 
            // lab_postcode
            // 
            this.lab_postcode.AutoSize = true;
            this.lab_postcode.Location = new System.Drawing.Point(58, 95);
            this.lab_postcode.Name = "lab_postcode";
            this.lab_postcode.Size = new System.Drawing.Size(73, 12);
            this.lab_postcode.TabIndex = 59;
            this.lab_postcode.Text = "Package Name";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(137, 173);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(253, 93);
            this.txtLocation.TabIndex = 43;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(85, 173);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(46, 12);
            this.lblRemark.TabIndex = 57;
            this.lblRemark.Text = "Location";
            // 
            // txtaccID
            // 
            this.txtaccID.Location = new System.Drawing.Point(318, 52);
            this.txtaccID.Name = "txtaccID";
            this.txtaccID.Size = new System.Drawing.Size(97, 22);
            this.txtaccID.TabIndex = 42;
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Location = new System.Drawing.Point(99, 137);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(32, 12);
            this.txtType.TabIndex = 56;
            this.txtType.Text = "Status";
            // 
            // txtbookingID
            // 
            this.txtbookingID.Location = new System.Drawing.Point(502, 52);
            this.txtbookingID.Name = "txtbookingID";
            this.txtbookingID.Size = new System.Drawing.Size(97, 22);
            this.txtbookingID.TabIndex = 41;
            // 
            // lab_CompanyName
            // 
            this.lab_CompanyName.AutoSize = true;
            this.lab_CompanyName.Location = new System.Drawing.Point(435, 57);
            this.lab_CompanyName.Name = "lab_CompanyName";
            this.lab_CompanyName.Size = new System.Drawing.Size(64, 12);
            this.lab_CompanyName.TabIndex = 55;
            this.lab_CompanyName.Text = "Booking ID:";
            // 
            // txtpkgID
            // 
            this.txtpkgID.Location = new System.Drawing.Point(137, 52);
            this.txtpkgID.Name = "txtpkgID";
            this.txtpkgID.Size = new System.Drawing.Size(97, 22);
            this.txtpkgID.TabIndex = 40;
            // 
            // lab_contectName
            // 
            this.lab_contectName.AutoSize = true;
            this.lab_contectName.Location = new System.Drawing.Point(73, 57);
            this.lab_contectName.Name = "lab_contectName";
            this.lab_contectName.Size = new System.Drawing.Size(58, 12);
            this.lab_contectName.TabIndex = 54;
            this.lab_contectName.Text = "Package ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(117, 319);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1065, 22);
            this.txtSearch.TabIndex = 70;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 72;
            this.label5.Text = "Search for record:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(952, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 23);
            this.label7.TabIndex = 151;
            this.label7.Text = "Edit Package Status";
            // 
            // chkIsImport
            // 
            this.chkIsImport.AutoSize = true;
            this.chkIsImport.Location = new System.Drawing.Point(404, 91);
            this.chkIsImport.Name = "chkIsImport";
            this.chkIsImport.Size = new System.Drawing.Size(93, 16);
            this.chkIsImport.TabIndex = 152;
            this.chkIsImport.Text = "Import Service";
            this.chkIsImport.UseVisualStyleBackColor = true;
            // 
            // chkConfirmDelivered
            // 
            this.chkConfirmDelivered.AutoSize = true;
            this.chkConfirmDelivered.Location = new System.Drawing.Point(513, 91);
            this.chkConfirmDelivered.Name = "chkConfirmDelivered";
            this.chkConfirmDelivered.Size = new System.Drawing.Size(118, 16);
            this.chkConfirmDelivered.TabIndex = 154;
            this.chkConfirmDelivered.Text = "Confirmed Delivery";
            this.chkConfirmDelivered.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_pkgStatus,
            this.tsb_airwaybill});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1195, 25);
            this.toolStrip1.TabIndex = 155;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_pkgStatus
            // 
            this.tsb_pkgStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_pkgStatus.Enabled = false;
            this.tsb_pkgStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_pkgStatus.Name = "tsb_pkgStatus";
            this.tsb_pkgStatus.Size = new System.Drawing.Size(113, 22);
            this.tsb_pkgStatus.Text = "Edit Package Status";
            // 
            // tsb_airwaybill
            // 
            this.tsb_airwaybill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_airwaybill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_airwaybill.Name = "tsb_airwaybill";
            this.tsb_airwaybill.Size = new System.Drawing.Size(89, 22);
            this.tsb_airwaybill.Text = "Edit Airway Bill";
            this.tsb_airwaybill.Click += new System.EventHandler(this.tsb_airwaybill_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EDEapp.Properties.Resources.package_location_1810913_1537551;
            this.pictureBox1.Location = new System.Drawing.Point(967, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // EditDeliveryStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 727);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.chkConfirmDelivered);
            this.Controls.Add(this.chkIsImport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_accID);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txtpkgName);
            this.Controls.Add(this.lab_postcode);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtaccID);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtbookingID);
            this.Controls.Add(this.lab_CompanyName);
            this.Controls.Add(this.txtpkgID);
            this.Controls.Add(this.lab_contectName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditDeliveryStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Delivery Status (Staff)";
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
        private System.Windows.Forms.Label lbl_accID;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txtpkgName;
        private System.Windows.Forms.Label lab_postcode;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtaccID;
        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.TextBox txtbookingID;
        private System.Windows.Forms.Label lab_CompanyName;
        private System.Windows.Forms.TextBox txtpkgID;
        private System.Windows.Forms.Label lab_contectName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.CheckBox chkIsImport;
        private System.Windows.Forms.CheckBox chkConfirmDelivered;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_airwaybill;
        private System.Windows.Forms.ToolStripButton tsb_pkgStatus;
    }
}