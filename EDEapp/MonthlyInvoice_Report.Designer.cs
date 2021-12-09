
namespace EDEapp
{
    partial class MonthlyInvoice_Report
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
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.txt_monthlyInvoiceID = new System.Windows.Forms.TextBox();
            this.txt_totalValue = new System.Windows.Forms.TextBox();
            this.txt_endDate = new System.Windows.Forms.TextBox();
            this.txt_startDate = new System.Windows.Forms.TextBox();
            this.btn_paymentStatus = new System.Windows.Forms.Button();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.txt_accountID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.dgv_printList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_printList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_close.Location = new System.Drawing.Point(1086, 34);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(115, 55);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(77, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(45, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monthly Invoice ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(113, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(569, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(569, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "End Date:";
            // 
            // txt_customerName
            // 
            this.txt_customerName.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_customerName.Location = new System.Drawing.Point(234, 52);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(268, 23);
            this.txt_customerName.TabIndex = 6;
            // 
            // txt_monthlyInvoiceID
            // 
            this.txt_monthlyInvoiceID.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_monthlyInvoiceID.Location = new System.Drawing.Point(234, 120);
            this.txt_monthlyInvoiceID.Name = "txt_monthlyInvoiceID";
            this.txt_monthlyInvoiceID.Size = new System.Drawing.Size(268, 23);
            this.txt_monthlyInvoiceID.TabIndex = 7;
            // 
            // txt_totalValue
            // 
            this.txt_totalValue.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_totalValue.Location = new System.Drawing.Point(234, 154);
            this.txt_totalValue.Name = "txt_totalValue";
            this.txt_totalValue.Size = new System.Drawing.Size(268, 23);
            this.txt_totalValue.TabIndex = 8;
            // 
            // txt_endDate
            // 
            this.txt_endDate.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_endDate.Location = new System.Drawing.Point(674, 87);
            this.txt_endDate.Name = "txt_endDate";
            this.txt_endDate.Size = new System.Drawing.Size(268, 23);
            this.txt_endDate.TabIndex = 10;
            // 
            // txt_startDate
            // 
            this.txt_startDate.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_startDate.Location = new System.Drawing.Point(674, 52);
            this.txt_startDate.Name = "txt_startDate";
            this.txt_startDate.Size = new System.Drawing.Size(268, 23);
            this.txt_startDate.TabIndex = 9;
            // 
            // btn_paymentStatus
            // 
            this.btn_paymentStatus.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_paymentStatus.Location = new System.Drawing.Point(1072, 180);
            this.btn_paymentStatus.Name = "btn_paymentStatus";
            this.btn_paymentStatus.Size = new System.Drawing.Size(143, 114);
            this.btn_paymentStatus.TabIndex = 11;
            this.btn_paymentStatus.Text = "Payment Status";
            this.btn_paymentStatus.UseVisualStyleBackColor = true;
            // 
            // dgv_list
            // 
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(49, 300);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowTemplate.Height = 24;
            this.dgv_list.Size = new System.Drawing.Size(1167, 451);
            this.dgv_list.TabIndex = 12;
            // 
            // txt_accountID
            // 
            this.txt_accountID.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_accountID.Location = new System.Drawing.Point(234, 86);
            this.txt_accountID.Name = "txt_accountID";
            this.txt_accountID.Size = new System.Drawing.Size(268, 23);
            this.txt_accountID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(113, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Account ID:";
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_print.Location = new System.Drawing.Point(1086, 115);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(115, 55);
            this.btn_print.TabIndex = 15;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // dgv_printList
            // 
            this.dgv_printList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_printList.Location = new System.Drawing.Point(48, 300);
            this.dgv_printList.Name = "dgv_printList";
            this.dgv_printList.RowTemplate.Height = 24;
            this.dgv_printList.Size = new System.Drawing.Size(287, 451);
            this.dgv_printList.TabIndex = 16;
            // 
            // MonthlyInvoice_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 780);
            this.Controls.Add(this.dgv_printList);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.txt_accountID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.btn_paymentStatus);
            this.Controls.Add(this.txt_endDate);
            this.Controls.Add(this.txt_startDate);
            this.Controls.Add(this.txt_totalValue);
            this.Controls.Add(this.txt_monthlyInvoiceID);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "MonthlyInvoice_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Monthly Report";
            this.Load += new System.EventHandler(this.MonthlyInvoice_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_printList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.TextBox txt_monthlyInvoiceID;
        private System.Windows.Forms.TextBox txt_totalValue;
        private System.Windows.Forms.TextBox txt_endDate;
        private System.Windows.Forms.TextBox txt_startDate;
        private System.Windows.Forms.Button btn_paymentStatus;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.TextBox txt_accountID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DataGridView dgv_printList;
    }
}