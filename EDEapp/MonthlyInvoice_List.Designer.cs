
namespace EDEapp
{
    partial class MonthlyInvoice_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyInvoice_List));
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_cInv = new System.Windows.Forms.ToolStripButton();
            this.tsb_mInv = new System.Windows.Forms.ToolStripButton();
            this.tsb_iInv = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_list
            // 
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(332, 161);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowTemplate.Height = 24;
            this.dgv_list.Size = new System.Drawing.Size(832, 406);
            this.dgv_list.TabIndex = 0;
            this.dgv_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellDoubleClick);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(16, 98);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(118, 211);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(159, 20);
            this.cb_status.TabIndex = 102;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            this.cb_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_status_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 11.25F);
            this.label2.Location = new System.Drawing.Point(14, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 101;
            this.label2.Text = "Payment Status:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(202, 280);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 105;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 11.25F);
            this.label3.Location = new System.Drawing.Point(44, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 104;
            this.label3.Text = "Search ID:";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(118, 252);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(159, 22);
            this.txt_search.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 24);
            this.label1.TabIndex = 106;
            this.label1.Text = "Consolidate Monthly Invoice List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(566, 19);
            this.label4.TabIndex = 107;
            this.label4.Text = "You can check your monthly invoice. Double click the row can view details.";
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
            this.toolStrip1.TabIndex = 117;
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
            this.tsb_cInv.Click += new System.EventHandler(this.tsb_cInv_Click);
            // 
            // tsb_mInv
            // 
            this.tsb_mInv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_mInv.Image = ((System.Drawing.Image)(resources.GetObject("tsb_mInv.Image")));
            this.tsb_mInv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_mInv.Name = "tsb_mInv";
            this.tsb_mInv.Size = new System.Drawing.Size(163, 22);
            this.tsb_mInv.Text = "Consolidate Monthly Invoice";
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
            // MonthlyInvoice_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 595);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_list);
            this.Name = "MonthlyInvoice_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Check Monthly Invoice";
            this.Load += new System.EventHandler(this.MonthlyInvoice_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_cInv;
        private System.Windows.Forms.ToolStripButton tsb_mInv;
        private System.Windows.Forms.ToolStripButton tsb_iInv;
    }
}