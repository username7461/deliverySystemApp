
namespace EDEapp
{
    partial class Logging
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
            this.accountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionPerformed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lab_search = new System.Windows.Forms.Label();
            this.date_from = new System.Windows.Forms.DateTimePicker();
            this.lab_fromdate = new System.Windows.Forms.Label();
            this.lab_to = new System.Windows.Forms.Label();
            this.date_to = new System.Windows.Forms.DateTimePicker();
            this.btn_serach = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountID,
            this.actionPerformed,
            this.times,
            this.ipAddress});
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(685, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // accountID
            // 
            this.accountID.HeaderText = "accountID";
            this.accountID.Name = "accountID";
            this.accountID.ReadOnly = true;
            this.accountID.Width = 70;
            // 
            // actionPerformed
            // 
            this.actionPerformed.HeaderText = "actionPerformed";
            this.actionPerformed.Name = "actionPerformed";
            this.actionPerformed.ReadOnly = true;
            this.actionPerformed.Width = 280;
            // 
            // times
            // 
            this.times.HeaderText = "Times";
            this.times.Name = "times";
            this.times.ReadOnly = true;
            this.times.Width = 150;
            // 
            // ipAddress
            // 
            this.ipAddress.HeaderText = "ipAddress";
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.ReadOnly = true;
            this.ipAddress.Width = 140;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(524, 15);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(71, 23);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(53, 62);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(524, 22);
            this.txt_search.TabIndex = 2;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lab_search
            // 
            this.lab_search.AutoSize = true;
            this.lab_search.Location = new System.Drawing.Point(11, 67);
            this.lab_search.Name = "lab_search";
            this.lab_search.Size = new System.Drawing.Size(36, 12);
            this.lab_search.TabIndex = 3;
            this.lab_search.Text = "Search";
            // 
            // date_from
            // 
            this.date_from.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_from.Location = new System.Drawing.Point(68, 15);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(163, 22);
            this.date_from.TabIndex = 4;
            // 
            // lab_fromdate
            // 
            this.lab_fromdate.AutoSize = true;
            this.lab_fromdate.Location = new System.Drawing.Point(8, 22);
            this.lab_fromdate.Name = "lab_fromdate";
            this.lab_fromdate.Size = new System.Drawing.Size(54, 12);
            this.lab_fromdate.TabIndex = 5;
            this.lab_fromdate.Text = "From Date";
            // 
            // lab_to
            // 
            this.lab_to.AutoSize = true;
            this.lab_to.Location = new System.Drawing.Point(241, 22);
            this.lab_to.Name = "lab_to";
            this.lab_to.Size = new System.Drawing.Size(42, 12);
            this.lab_to.TabIndex = 7;
            this.lab_to.Text = "To Date";
            // 
            // date_to
            // 
            this.date_to.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_to.Location = new System.Drawing.Point(289, 15);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(163, 22);
            this.date_to.TabIndex = 6;
            // 
            // btn_serach
            // 
            this.btn_serach.Location = new System.Drawing.Point(458, 15);
            this.btn_serach.Name = "btn_serach";
            this.btn_serach.Size = new System.Drawing.Size(60, 23);
            this.btn_serach.TabIndex = 8;
            this.btn_serach.Text = "Search";
            this.btn_serach.UseVisualStyleBackColor = true;
            this.btn_serach.Click += new System.EventHandler(this.btn_serach_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(639, 7);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(58, 38);
            this.btn_return.TabIndex = 9;
            this.btn_return.Text = "<<Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Logging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 444);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_serach);
            this.Controls.Add(this.lab_to);
            this.Controls.Add(this.date_to);
            this.Controls.Add(this.lab_fromdate);
            this.Controls.Add(this.date_from);
            this.Controls.Add(this.lab_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Logging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Log";
            this.Load += new System.EventHandler(this.Logging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lab_search;
        private System.Windows.Forms.DateTimePicker date_from;
        private System.Windows.Forms.Label lab_fromdate;
        private System.Windows.Forms.Label lab_to;
        private System.Windows.Forms.DateTimePicker date_to;
        private System.Windows.Forms.Button btn_serach;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionPerformed;
        private System.Windows.Forms.DataGridViewTextBoxColumn times;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipAddress;
        private System.Windows.Forms.Button btn_return;
    }
}