
namespace EDEapp
{
    partial class ManageCentreInformation
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
            this.centreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentreAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentreRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.lab_name = new System.Windows.Forms.Label();
            this.txt_centreName = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lab_address = new System.Windows.Forms.Label();
            this.combo_region = new System.Windows.Forms.ComboBox();
            this.lab_region = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.txt_centreID = new System.Windows.Forms.TextBox();
            this.lab_centreID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.centreID,
            this.CentreName,
            this.CentreAddress,
            this.CentreRegion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // centreID
            // 
            this.centreID.HeaderText = "centreID";
            this.centreID.Name = "centreID";
            this.centreID.ReadOnly = true;
            this.centreID.Width = 50;
            // 
            // CentreName
            // 
            this.CentreName.HeaderText = "CentreName";
            this.CentreName.Name = "CentreName";
            this.CentreName.ReadOnly = true;
            this.CentreName.Width = 125;
            // 
            // CentreAddress
            // 
            this.CentreAddress.HeaderText = "CentreAddress";
            this.CentreAddress.Name = "CentreAddress";
            this.CentreAddress.ReadOnly = true;
            this.CentreAddress.Width = 272;
            // 
            // CentreRegion
            // 
            this.CentreRegion.HeaderText = "CentreRegion";
            this.CentreRegion.Name = "CentreRegion";
            this.CentreRegion.ReadOnly = true;
            this.CentreRegion.Width = 85;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(270, 178);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(31, 61);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(66, 12);
            this.lab_name.TabIndex = 2;
            this.lab_name.Text = "Centre Name";
            // 
            // txt_centreName
            // 
            this.txt_centreName.Location = new System.Drawing.Point(103, 56);
            this.txt_centreName.Name = "txt_centreName";
            this.txt_centreName.Size = new System.Drawing.Size(147, 22);
            this.txt_centreName.TabIndex = 3;
            this.txt_centreName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_centreName_KeyPress);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(103, 95);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(147, 51);
            this.txt_address.TabIndex = 5;
            this.txt_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_address_KeyPress);
            // 
            // lab_address
            // 
            this.lab_address.AutoSize = true;
            this.lab_address.Location = new System.Drawing.Point(31, 98);
            this.lab_address.Name = "lab_address";
            this.lab_address.Size = new System.Drawing.Size(42, 12);
            this.lab_address.TabIndex = 4;
            this.lab_address.Text = "Address";
            // 
            // combo_region
            // 
            this.combo_region.FormattingEnabled = true;
            this.combo_region.Location = new System.Drawing.Point(103, 172);
            this.combo_region.Name = "combo_region";
            this.combo_region.Size = new System.Drawing.Size(121, 20);
            this.combo_region.TabIndex = 6;
            this.combo_region.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // lab_region
            // 
            this.lab_region.AutoSize = true;
            this.lab_region.Location = new System.Drawing.Point(34, 175);
            this.lab_region.Name = "lab_region";
            this.lab_region.Size = new System.Drawing.Size(39, 12);
            this.lab_region.TabIndex = 7;
            this.lab_region.Text = "Region";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(432, 178);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(513, 178);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(351, 178);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(513, 12);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 41);
            this.btn_return.TabIndex = 16;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // txt_centreID
            // 
            this.txt_centreID.Location = new System.Drawing.Point(103, 12);
            this.txt_centreID.Name = "txt_centreID";
            this.txt_centreID.Size = new System.Drawing.Size(147, 22);
            this.txt_centreID.TabIndex = 18;
            this.txt_centreID.TextChanged += new System.EventHandler(this.txt_centreID_TextChanged);
            this.txt_centreID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_centreID_KeyPress);
            // 
            // lab_centreID
            // 
            this.lab_centreID.AutoSize = true;
            this.lab_centreID.Location = new System.Drawing.Point(31, 17);
            this.lab_centreID.Name = "lab_centreID";
            this.lab_centreID.Size = new System.Drawing.Size(51, 12);
            this.lab_centreID.TabIndex = 17;
            this.lab_centreID.Text = "Centre ID";
            // 
            // ManageCentreInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.txt_centreID);
            this.Controls.Add(this.lab_centreID);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lab_region);
            this.Controls.Add(this.combo_region);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lab_address);
            this.Controls.Add(this.txt_centreName);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageCentreInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Manage Centre Information";
            this.Load += new System.EventHandler(this.AddNewCentre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.TextBox txt_centreName;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lab_address;
        private System.Windows.Forms.ComboBox combo_region;
        private System.Windows.Forms.Label lab_region;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn centreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentreAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentreRegion;
        private System.Windows.Forms.TextBox txt_centreID;
        private System.Windows.Forms.Label lab_centreID;
    }
}