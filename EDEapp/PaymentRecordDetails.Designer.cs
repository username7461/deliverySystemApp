
namespace EDEapp
{
    partial class PaymentRecordDetailsCreditCard
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
            this.paymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HandleBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentMethod,
            this.cardType,
            this.cardNo,
            this.CentreName,
            this.HandleBy});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(358, 122);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // paymentMethod
            // 
            this.paymentMethod.HeaderText = "paymentMethod";
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.ReadOnly = true;
            this.paymentMethod.Width = 80;
            // 
            // cardType
            // 
            this.cardType.HeaderText = "cardType";
            this.cardType.Name = "cardType";
            this.cardType.ReadOnly = true;
            // 
            // cardNo
            // 
            this.cardNo.HeaderText = "cardNo";
            this.cardNo.Name = "cardNo";
            this.cardNo.ReadOnly = true;
            this.cardNo.Width = 120;
            // 
            // CentreName
            // 
            this.CentreName.HeaderText = "CentreName";
            this.CentreName.Name = "CentreName";
            this.CentreName.ReadOnly = true;
            this.CentreName.Width = 120;
            // 
            // HandleBy
            // 
            this.HandleBy.HeaderText = "Handle By";
            this.HandleBy.Name = "HandleBy";
            this.HandleBy.ReadOnly = true;
            this.HandleBy.Width = 120;
            // 
            // PaymentRecordDetailsCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 146);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PaymentRecordDetailsCreditCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentRecordDetails";
            this.Load += new System.EventHandler(this.PaymentRecordDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HandleBy;
    }
}