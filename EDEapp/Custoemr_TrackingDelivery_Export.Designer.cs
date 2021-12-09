
namespace EDEapp
{
    partial class Customer_TrackDelivery_Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_TrackDelivery_Export));
            this.dgv_pkgList = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cb_searchType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_export = new System.Windows.Forms.ToolStripButton();
            this.tsb_import = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pkgList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_pkgList
            // 
            this.dgv_pkgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pkgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pkgList.Location = new System.Drawing.Point(342, 173);
            this.dgv_pkgList.Name = "dgv_pkgList";
            this.dgv_pkgList.ReadOnly = true;
            this.dgv_pkgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pkgList.Size = new System.Drawing.Size(848, 370);
            this.dgv_pkgList.TabIndex = 94;
            this.dgv_pkgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pkgList_CellClick);
            this.dgv_pkgList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pkgList_CellDoubleClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(116, 267);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(159, 22);
            this.txt_search.TabIndex = 96;
            // 
            // cb_searchType
            // 
            this.cb_searchType.FormattingEnabled = true;
            this.cb_searchType.Location = new System.Drawing.Point(116, 241);
            this.cb_searchType.Name = "cb_searchType";
            this.cb_searchType.Size = new System.Drawing.Size(121, 20);
            this.cb_searchType.TabIndex = 97;
            this.cb_searchType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_searchType_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 98;
            this.label1.Text = "Track Delivery (Export)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 11.25F);
            this.label2.Location = new System.Drawing.Point(69, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 99;
            this.label2.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(116, 173);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 20);
            this.cb_status.TabIndex = 100;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            this.cb_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_status_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 11.25F);
            this.label3.Location = new System.Drawing.Point(46, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 101;
            this.label3.Text = "Search ID";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(200, 295);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 102;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_message.Location = new System.Drawing.Point(339, 136);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(52, 16);
            this.lbl_message.TabIndex = 103;
            this.lbl_message.Text = "label4";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(16, 100);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 104;
            this.btn_back.Text = "Back Menu";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_export,
            this.tsb_import});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1202, 25);
            this.toolStrip1.TabIndex = 117;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_export
            // 
            this.tsb_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_export.Image = ((System.Drawing.Image)(resources.GetObject("tsb_export.Image")));
            this.tsb_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_export.Name = "tsb_export";
            this.tsb_export.Size = new System.Drawing.Size(45, 22);
            this.tsb_export.Text = "Export";
            // 
            // tsb_import
            // 
            this.tsb_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_import.Image = ((System.Drawing.Image)(resources.GetObject("tsb_import.Image")));
            this.tsb_import.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_import.Name = "tsb_import";
            this.tsb_import.Size = new System.Drawing.Size(47, 22);
            this.tsb_import.Text = "Import";
            this.tsb_import.Click += new System.EventHandler(this.tsb_import_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(621, 19);
            this.label4.TabIndex = 118;
            this.label4.Text = "You can track your export package here. Double click one record to get more detai" +
    "l.";
            // 
            // Customer_TrackDelivery_Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 595);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_searchType);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_pkgList);
            this.Name = "Customer_TrackDelivery_Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custoemr_TrackingDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pkgList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pkgList;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cb_searchType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_export;
        private System.Windows.Forms.ToolStripButton tsb_import;
        private System.Windows.Forms.Label label4;
    }
}