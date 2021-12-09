
namespace EDEapp
{
    partial class CommercialInvoice_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommercialInvoice_List));
            this.dgv_commercialInvoiceList = new System.Windows.Forms.DataGridView();
            this.btn_print = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_cInv = new System.Windows.Forms.ToolStripButton();
            this.tsb_mInv = new System.Windows.Forms.ToolStripButton();
            this.tsb_iInv = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commercialInvoiceList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_commercialInvoiceList
            // 
            this.dgv_commercialInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_commercialInvoiceList.Location = new System.Drawing.Point(332, 161);
            this.dgv_commercialInvoiceList.Name = "dgv_commercialInvoiceList";
            this.dgv_commercialInvoiceList.RowTemplate.Height = 24;
            this.dgv_commercialInvoiceList.Size = new System.Drawing.Size(832, 406);
            this.dgv_commercialInvoiceList.TabIndex = 2;
            this.dgv_commercialInvoiceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_commercialInvoiceList_CellClick);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_print.Location = new System.Drawing.Point(185, 510);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(141, 57);
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(748, 19);
            this.label4.TabIndex = 110;
            this.label4.Text = "You can check your Commercial invoice. Select one record then press Print button " +
    "to get more detail.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 24);
            this.label1.TabIndex = 109;
            this.label1.Text = "Commercial Invoice List";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(16, 98);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 108;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(185, 280);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 115;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(27, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 114;
            this.label3.Text = "Search ID:";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(101, 252);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(159, 22);
            this.txt_search.TabIndex = 113;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_cInv,
            this.tsb_mInv,
            this.tsb_iInv});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1202, 25);
            this.toolStrip1.TabIndex = 116;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_cInv
            // 
            this.tsb_cInv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_cInv.Image = ((System.Drawing.Image)(resources.GetObject("tsb_cInv.Image")));
            this.tsb_cInv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_cInv.Name = "tsb_cInv";
            this.tsb_cInv.Size = new System.Drawing.Size(117, 22);
            this.tsb_cInv.Text = "Commercial Invoice";
            // 
            // tsb_mInv
            // 
            this.tsb_mInv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_mInv.Image = ((System.Drawing.Image)(resources.GetObject("tsb_mInv.Image")));
            this.tsb_mInv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_mInv.Name = "tsb_mInv";
            this.tsb_mInv.Size = new System.Drawing.Size(163, 22);
            this.tsb_mInv.Text = "Consolidate Monthly Invoice";
            this.tsb_mInv.Click += new System.EventHandler(this.tsb_mInv_Click);
            // 
            // tsb_iInv
            // 
            this.tsb_iInv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_iInv.Image = ((System.Drawing.Image)(resources.GetObject("tsb_iInv.Image")));
            this.tsb_iInv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_iInv.Name = "tsb_iInv";
            this.tsb_iInv.Size = new System.Drawing.Size(88, 22);
            this.tsb_iInv.Text = "Import Invoice";
            this.tsb_iInv.Click += new System.EventHandler(this.tsb_iInv_Click);
            // 
            // CommercialInvoice_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 595);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dgv_commercialInvoiceList);
            this.Name = "CommercialInvoice_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Check Commercial Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commercialInvoiceList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_commercialInvoiceList;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_cInv;
        private System.Windows.Forms.ToolStripButton tsb_mInv;
        private System.Windows.Forms.ToolStripButton tsb_iInv;
    }
}