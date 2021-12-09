
namespace EDEapp
{
    partial class CheckSavedCreditCard
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_holderName = new System.Windows.Forms.TextBox();
            this.lab_holderName = new System.Windows.Forms.Label();
            this.txt_expiryDate = new System.Windows.Forms.TextBox();
            this.lab_expiryDate = new System.Windows.Forms.Label();
            this.txt_cardNo = new System.Windows.Forms.TextBox();
            this.lab_cardNo = new System.Windows.Forms.Label();
            this.lab_cardType = new System.Windows.Forms.Label();
            this.combo_cardtype = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(500, 12);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 45);
            this.btn_return.TabIndex = 1;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardID,
            this.cardNo,
            this.expiryDate,
            this.cardType,
            this.holderName});
            this.dataGridView2.Location = new System.Drawing.Point(12, 184);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(546, 224);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // cardID
            // 
            this.cardID.HeaderText = "cardID";
            this.cardID.Name = "cardID";
            this.cardID.ReadOnly = true;
            this.cardID.Visible = false;
            // 
            // cardNo
            // 
            this.cardNo.HeaderText = "cardNo";
            this.cardNo.Name = "cardNo";
            this.cardNo.ReadOnly = true;
            this.cardNo.Width = 140;
            // 
            // expiryDate
            // 
            this.expiryDate.HeaderText = "expiryDate";
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.ReadOnly = true;
            this.expiryDate.Width = 120;
            // 
            // cardType
            // 
            this.cardType.HeaderText = "cardType";
            this.cardType.Name = "cardType";
            this.cardType.ReadOnly = true;
            this.cardType.Width = 120;
            // 
            // holderName
            // 
            this.holderName.HeaderText = "holderName";
            this.holderName.Name = "holderName";
            this.holderName.ReadOnly = true;
            this.holderName.Width = 123;
            // 
            // txt_holderName
            // 
            this.txt_holderName.Location = new System.Drawing.Point(320, 98);
            this.txt_holderName.Name = "txt_holderName";
            this.txt_holderName.Size = new System.Drawing.Size(110, 22);
            this.txt_holderName.TabIndex = 14;
            this.txt_holderName.TextChanged += new System.EventHandler(this.txt_holderName_TextChanged);
            this.txt_holderName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_holderName_KeyPress);
            // 
            // lab_holderName
            // 
            this.lab_holderName.AutoSize = true;
            this.lab_holderName.Location = new System.Drawing.Point(244, 101);
            this.lab_holderName.Name = "lab_holderName";
            this.lab_holderName.Size = new System.Drawing.Size(70, 12);
            this.lab_holderName.TabIndex = 13;
            this.lab_holderName.Text = "Holder Name:";
            // 
            // txt_expiryDate
            // 
            this.txt_expiryDate.Location = new System.Drawing.Point(118, 98);
            this.txt_expiryDate.Name = "txt_expiryDate";
            this.txt_expiryDate.Size = new System.Drawing.Size(110, 22);
            this.txt_expiryDate.TabIndex = 12;
            this.txt_expiryDate.TextChanged += new System.EventHandler(this.txt_expiryDate_TextChanged);
            this.txt_expiryDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_expiryDate_KeyPress);
            // 
            // lab_expiryDate
            // 
            this.lab_expiryDate.AutoSize = true;
            this.lab_expiryDate.Location = new System.Drawing.Point(48, 101);
            this.lab_expiryDate.Name = "lab_expiryDate";
            this.lab_expiryDate.Size = new System.Drawing.Size(64, 12);
            this.lab_expiryDate.TabIndex = 11;
            this.lab_expiryDate.Text = "Expiry Date:";
            // 
            // txt_cardNo
            // 
            this.txt_cardNo.Location = new System.Drawing.Point(118, 33);
            this.txt_cardNo.Name = "txt_cardNo";
            this.txt_cardNo.Size = new System.Drawing.Size(110, 22);
            this.txt_cardNo.TabIndex = 16;
            this.txt_cardNo.TextChanged += new System.EventHandler(this.txt_cardNo_TextChanged);
            this.txt_cardNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cardNo_KeyPress);
            // 
            // lab_cardNo
            // 
            this.lab_cardNo.AutoSize = true;
            this.lab_cardNo.Location = new System.Drawing.Point(48, 35);
            this.lab_cardNo.Name = "lab_cardNo";
            this.lab_cardNo.Size = new System.Drawing.Size(48, 12);
            this.lab_cardNo.TabIndex = 15;
            this.lab_cardNo.Text = "Card No:";
            // 
            // lab_cardType
            // 
            this.lab_cardType.AutoSize = true;
            this.lab_cardType.Location = new System.Drawing.Point(247, 36);
            this.lab_cardType.Name = "lab_cardType";
            this.lab_cardType.Size = new System.Drawing.Size(55, 12);
            this.lab_cardType.TabIndex = 18;
            this.lab_cardType.Text = "Card Type";
            // 
            // combo_cardtype
            // 
            this.combo_cardtype.FormattingEnabled = true;
            this.combo_cardtype.Location = new System.Drawing.Point(320, 32);
            this.combo_cardtype.Name = "combo_cardtype";
            this.combo_cardtype.Size = new System.Drawing.Size(110, 20);
            this.combo_cardtype.TabIndex = 17;
            this.combo_cardtype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_cardtype_KeyPress);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(483, 155);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 43;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(324, 155);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 42;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(405, 155);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 41;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(243, 155);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 40;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // CheckSavedCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 420);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lab_cardType);
            this.Controls.Add(this.combo_cardtype);
            this.Controls.Add(this.txt_cardNo);
            this.Controls.Add(this.lab_cardNo);
            this.Controls.Add(this.txt_holderName);
            this.Controls.Add(this.lab_holderName);
            this.Controls.Add(this.txt_expiryDate);
            this.Controls.Add(this.lab_expiryDate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_return);
            this.Name = "CheckSavedCreditCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckSavedCreditCard";
            this.Load += new System.EventHandler(this.CheckSavedCreditCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.TextBox txt_holderName;
        private System.Windows.Forms.Label lab_holderName;
        public System.Windows.Forms.TextBox txt_expiryDate;
        private System.Windows.Forms.Label lab_expiryDate;
        public System.Windows.Forms.TextBox txt_cardNo;
        private System.Windows.Forms.Label lab_cardNo;
        private System.Windows.Forms.Label lab_cardType;
        private System.Windows.Forms.ComboBox combo_cardtype;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardType;
        private System.Windows.Forms.DataGridViewTextBoxColumn holderName;
    }
}