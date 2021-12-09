
namespace EDEapp
{
    partial class ImportInvoice_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportInvoice_List));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_cInv = new System.Windows.Forms.ToolStripButton();
            this.tsb_mInv = new System.Windows.Forms.ToolStripButton();
            this.tsb_iInv = new System.Windows.Forms.ToolStripButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.cb_searchType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.TabIndex = 125;
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
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(222, 280);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 124;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(64, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 123;
            this.label3.Text = "Search ID:";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(138, 252);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(159, 22);
            this.txt_search.TabIndex = 122;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(556, 19);
            this.label4.TabIndex = 121;
            this.label4.Text = "You can check your Import Invoice. Double click the row can view details.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 120;
            this.label1.Text = "Import Invoice List";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(16, 98);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 119;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgv_list
            // 
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(332, 161);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowTemplate.Height = 24;
            this.dgv_list.Size = new System.Drawing.Size(832, 406);
            this.dgv_list.TabIndex = 117;
            this.dgv_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellDoubleClick);
            // 
            // cb_searchType
            // 
            this.cb_searchType.FormattingEnabled = true;
            this.cb_searchType.Location = new System.Drawing.Point(138, 215);
            this.cb_searchType.Name = "cb_searchType";
            this.cb_searchType.Size = new System.Drawing.Size(159, 20);
            this.cb_searchType.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(50, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 127;
            this.label2.Text = "Search Type:";
            // 
            // ImportInvoice_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_searchType);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_list);
            this.Name = "ImportInvoice_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Check Import Invoice";
            this.Load += new System.EventHandler(this.ImportInvoice_List_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_cInv;
        private System.Windows.Forms.ToolStripButton tsb_mInv;
        private System.Windows.Forms.ToolStripButton tsb_iInv;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.ComboBox cb_searchType;
        private System.Windows.Forms.Label label2;
    }
}