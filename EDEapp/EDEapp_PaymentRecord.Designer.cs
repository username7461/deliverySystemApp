
namespace EDEapp
{
    partial class EDEapp_PaymentRecord
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
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.paymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_back = new System.Windows.Forms.Button();
            this.lab_paymentrecord = new System.Windows.Forms.Label();
            this.lab_sortPaymentID = new System.Windows.Forms.Label();
            this.combo_paymentID = new System.Windows.Forms.ComboBox();
            this.lab_Date = new System.Windows.Forms.Label();
            this.combo_value = new System.Windows.Forms.ComboBox();
            this.lab_value = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_paymentID = new System.Windows.Forms.TextBox();
            this.lab_searchpaymentid = new System.Windows.Forms.Label();
            this.date_from = new System.Windows.Forms.DateTimePicker();
            this.date_to = new System.Windows.Forms.DateTimePicker();
            this.lab_to = new System.Windows.Forms.Label();
            this.btn_showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentID,
            this.Date,
            this.Value,
            this.Detail,
            this.paymentMethod});
            this.dataGridView1.Location = new System.Drawing.Point(276, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(484, 340);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PaymentID
            // 
            this.PaymentID.HeaderText = "PaymentID";
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.ReadOnly = true;
            this.PaymentID.Width = 120;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date (yyyy-MM-dd HH:mm)";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 180;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 80;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detail.Width = 60;
            // 
            // paymentMethod
            // 
            this.paymentMethod.HeaderText = "paymentMethod";
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.ReadOnly = true;
            this.paymentMethod.Visible = false;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(694, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 42);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "<<Return Menu";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lab_paymentrecord
            // 
            this.lab_paymentrecord.AutoSize = true;
            this.lab_paymentrecord.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_paymentrecord.Location = new System.Drawing.Point(12, 22);
            this.lab_paymentrecord.Name = "lab_paymentrecord";
            this.lab_paymentrecord.Size = new System.Drawing.Size(143, 19);
            this.lab_paymentrecord.TabIndex = 24;
            this.lab_paymentrecord.Text = "Payment Record";
            // 
            // lab_sortPaymentID
            // 
            this.lab_sortPaymentID.AutoSize = true;
            this.lab_sortPaymentID.Location = new System.Drawing.Point(32, 63);
            this.lab_sortPaymentID.Name = "lab_sortPaymentID";
            this.lab_sortPaymentID.Size = new System.Drawing.Size(97, 12);
            this.lab_sortPaymentID.TabIndex = 25;
            this.lab_sortPaymentID.Text = "Sort by Payment ID";
            // 
            // combo_paymentID
            // 
            this.combo_paymentID.FormattingEnabled = true;
            this.combo_paymentID.Location = new System.Drawing.Point(25, 91);
            this.combo_paymentID.Name = "combo_paymentID";
            this.combo_paymentID.Size = new System.Drawing.Size(121, 20);
            this.combo_paymentID.TabIndex = 26;
            this.combo_paymentID.SelectedIndexChanged += new System.EventHandler(this.combo_paymentID_SelectedIndexChanged);
            this.combo_paymentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_paymentID_KeyPress);
            // 
            // lab_Date
            // 
            this.lab_Date.AutoSize = true;
            this.lab_Date.Location = new System.Drawing.Point(26, 211);
            this.lab_Date.Name = "lab_Date";
            this.lab_Date.Size = new System.Drawing.Size(75, 12);
            this.lab_Date.TabIndex = 27;
            this.lab_Date.Text = "Search by Date";
            // 
            // combo_value
            // 
            this.combo_value.FormattingEnabled = true;
            this.combo_value.Location = new System.Drawing.Point(25, 166);
            this.combo_value.Name = "combo_value";
            this.combo_value.Size = new System.Drawing.Size(121, 20);
            this.combo_value.TabIndex = 30;
            this.combo_value.SelectedIndexChanged += new System.EventHandler(this.combo_value_SelectedIndexChanged);
            this.combo_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_value_KeyPress);
            // 
            // lab_value
            // 
            this.lab_value.AutoSize = true;
            this.lab_value.Location = new System.Drawing.Point(32, 136);
            this.lab_value.Name = "lab_value";
            this.lab_value.Size = new System.Drawing.Size(69, 12);
            this.lab_value.TabIndex = 29;
            this.lab_value.Text = "Sort by Value";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(25, 360);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(89, 43);
            this.btn_search.TabIndex = 33;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_paymentID
            // 
            this.txt_paymentID.Location = new System.Drawing.Point(25, 315);
            this.txt_paymentID.Name = "txt_paymentID";
            this.txt_paymentID.Size = new System.Drawing.Size(121, 22);
            this.txt_paymentID.TabIndex = 34;
            this.txt_paymentID.TextChanged += new System.EventHandler(this.txt_paymentID_TextChanged);
            this.txt_paymentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_paymentID_KeyPress);
            // 
            // lab_searchpaymentid
            // 
            this.lab_searchpaymentid.AutoSize = true;
            this.lab_searchpaymentid.Location = new System.Drawing.Point(23, 287);
            this.lab_searchpaymentid.Name = "lab_searchpaymentid";
            this.lab_searchpaymentid.Size = new System.Drawing.Size(91, 12);
            this.lab_searchpaymentid.TabIndex = 35;
            this.lab_searchpaymentid.Text = "Search PaymentID";
            // 
            // date_from
            // 
            this.date_from.CustomFormat = "yyyy-MM-dd HH:mm";
            this.date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_from.Location = new System.Drawing.Point(25, 244);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(104, 22);
            this.date_from.TabIndex = 36;
            // 
            // date_to
            // 
            this.date_to.CustomFormat = "yyyy-MM-dd HH:mm";
            this.date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_to.Location = new System.Drawing.Point(166, 244);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(104, 22);
            this.date_to.TabIndex = 37;
            // 
            // lab_to
            // 
            this.lab_to.AutoSize = true;
            this.lab_to.Location = new System.Drawing.Point(137, 251);
            this.lab_to.Name = "lab_to";
            this.lab_to.Size = new System.Drawing.Size(18, 12);
            this.lab_to.TabIndex = 38;
            this.lab_to.Text = "To";
            // 
            // btn_showAll
            // 
            this.btn_showAll.Location = new System.Drawing.Point(120, 360);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(138, 43);
            this.btn_showAll.TabIndex = 39;
            this.btn_showAll.Text = "Show All Payment Record";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // EDEapp_PaymentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.lab_to);
            this.Controls.Add(this.date_to);
            this.Controls.Add(this.date_from);
            this.Controls.Add(this.lab_searchpaymentid);
            this.Controls.Add(this.txt_paymentID);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.combo_value);
            this.Controls.Add(this.lab_value);
            this.Controls.Add(this.lab_Date);
            this.Controls.Add(this.combo_paymentID);
            this.Controls.Add(this.lab_sortPaymentID);
            this.Controls.Add(this.lab_paymentrecord);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EDEapp_PaymentRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp_PaymentRecord";
            this.Load += new System.EventHandler(this.EDEapp_PaymentRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lab_paymentrecord;
        private System.Windows.Forms.Label lab_sortPaymentID;
        private System.Windows.Forms.ComboBox combo_paymentID;
        private System.Windows.Forms.Label lab_Date;
        private System.Windows.Forms.ComboBox combo_value;
        private System.Windows.Forms.Label lab_value;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_paymentID;
        private System.Windows.Forms.Label lab_searchpaymentid;
        private System.Windows.Forms.DateTimePicker date_from;
        private System.Windows.Forms.DateTimePicker date_to;
        private System.Windows.Forms.Label lab_to;
        private System.Windows.Forms.Button btn_showAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethod;
    }
}