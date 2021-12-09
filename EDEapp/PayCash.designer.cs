
namespace EDEapp
{
    partial class PayCash
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
            this.dgv_invoiceList = new System.Windows.Forms.DataGridView();
            this.invoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_back = new System.Windows.Forms.Button();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_invoiceList
            // 
            this.dgv_invoiceList.AllowUserToAddRows = false;
            this.dgv_invoiceList.AllowUserToDeleteRows = false;
            this.dgv_invoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceID,
            this.accountID,
            this.value,
            this.startDate,
            this.endDate,
            this.Pay});
            this.dgv_invoiceList.Location = new System.Drawing.Point(12, 226);
            this.dgv_invoiceList.Name = "dgv_invoiceList";
            this.dgv_invoiceList.ReadOnly = true;
            this.dgv_invoiceList.RowTemplate.Height = 24;
            this.dgv_invoiceList.Size = new System.Drawing.Size(908, 542);
            this.dgv_invoiceList.TabIndex = 0;
            this.dgv_invoiceList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // invoiceID
            // 
            this.invoiceID.HeaderText = "invoiceID";
            this.invoiceID.Name = "invoiceID";
            this.invoiceID.ReadOnly = true;
            // 
            // accountID
            // 
            this.accountID.HeaderText = "accountID";
            this.accountID.Name = "accountID";
            this.accountID.ReadOnly = true;
            // 
            // value
            // 
            this.value.HeaderText = "value";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "startDate";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 140;
            // 
            // endDate
            // 
            this.endDate.HeaderText = "endDate";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 140;
            // 
            // Pay
            // 
            this.Pay.HeaderText = "Pay";
            this.Pay.Name = "Pay";
            this.Pay.ReadOnly = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(845, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 40);
            this.btn_back.TabIndex = 30;
            this.btn_back.Text = "<<Return";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Pay";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(153, 198);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(238, 22);
            this.txt_search.TabIndex = 31;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Search Account ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Consolidate Monthly Invoice Cash Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "For customer need to pay monthly invoice by cash.";
            // 
            // PayCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 780);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_invoiceList);
            this.Name = "PayCash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Cash Payment";
            this.Load += new System.EventHandler(this.PayCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoiceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_invoiceList;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewButtonColumn Pay;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}