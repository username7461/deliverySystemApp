
namespace EDEapp
{
    partial class CSOViewCustomerInfo
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
            this.cusFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.access = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lab_search = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.cusFName,
            this.cusLName,
            this.email,
            this.phone,
            this.access,
            this.credibility,
            this.Edit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // accountID
            // 
            this.accountID.HeaderText = "accountID";
            this.accountID.Name = "accountID";
            this.accountID.ReadOnly = true;
            this.accountID.Width = 90;
            // 
            // cusFName
            // 
            this.cusFName.HeaderText = "cusFName";
            this.cusFName.Name = "cusFName";
            this.cusFName.ReadOnly = true;
            this.cusFName.Width = 90;
            // 
            // cusLName
            // 
            this.cusLName.HeaderText = "cusLName";
            this.cusLName.Name = "cusLName";
            this.cusLName.ReadOnly = true;
            this.cusLName.Width = 90;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // phone
            // 
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 80;
            // 
            // access
            // 
            this.access.HeaderText = "access";
            this.access.Name = "access";
            this.access.ReadOnly = true;
            this.access.Width = 80;
            // 
            // credibility
            // 
            this.credibility.HeaderText = "credibility";
            this.credibility.Name = "credibility";
            this.credibility.ReadOnly = true;
            this.credibility.Width = 80;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.Width = 85;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(54, 58);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(637, 22);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // lab_search
            // 
            this.lab_search.AutoSize = true;
            this.lab_search.Location = new System.Drawing.Point(12, 61);
            this.lab_search.Name = "lab_search";
            this.lab_search.Size = new System.Drawing.Size(36, 12);
            this.lab_search.TabIndex = 2;
            this.lab_search.Text = "Search";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(713, 12);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 40);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Account List";
            // 
            // CSOViewCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lab_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CSOViewCustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Customer Account List";
            this.Load += new System.EventHandler(this.CSOEditCustomerInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn access;
        private System.Windows.Forms.DataGridViewTextBoxColumn credibility;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lab_search;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label label1;
    }
}