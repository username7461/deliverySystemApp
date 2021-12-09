
namespace EDEapp
{
    partial class ViewStaffAccount
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
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_accountID = new System.Windows.Forms.TextBox();
            this.lab_accountID = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lab_email = new System.Windows.Forms.Label();
            this.lab_centreName = new System.Windows.Forms.Label();
            this.txt_centreName = new System.Windows.Forms.TextBox();
            this.lab_jobName = new System.Windows.Forms.Label();
            this.txt_jobName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.lab_firstName = new System.Windows.Forms.Label();
            this.lab_lastName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lab_status = new System.Windows.Forms.Label();
            this.lab_phoneNo = new System.Windows.Forms.Label();
            this.txt_phoneNo = new System.Windows.Forms.TextBox();
            this.btn_ViewALL = new System.Windows.Forms.Button();
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
            this.firstName,
            this.lastName,
            this.email,
            this.phoneNo,
            this.jobName,
            this.centreName,
            this.status,
            this.Edit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(792, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // accountID
            // 
            this.accountID.HeaderText = "accountID";
            this.accountID.Name = "accountID";
            this.accountID.ReadOnly = true;
            this.accountID.Width = 80;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "firstName";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Width = 60;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "lastName";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Width = 70;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phoneNo
            // 
            this.phoneNo.HeaderText = "phoneNO";
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.ReadOnly = true;
            // 
            // jobName
            // 
            this.jobName.HeaderText = "jobName";
            this.jobName.Name = "jobName";
            this.jobName.ReadOnly = true;
            // 
            // centreName
            // 
            this.centreName.HeaderText = "centreName";
            this.centreName.Name = "centreName";
            this.centreName.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 40;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(439, 119);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_accountID
            // 
            this.txt_accountID.Location = new System.Drawing.Point(86, 10);
            this.txt_accountID.Name = "txt_accountID";
            this.txt_accountID.Size = new System.Drawing.Size(120, 22);
            this.txt_accountID.TabIndex = 2;
            // 
            // lab_accountID
            // 
            this.lab_accountID.AutoSize = true;
            this.lab_accountID.Location = new System.Drawing.Point(24, 13);
            this.lab_accountID.Name = "lab_accountID";
            this.lab_accountID.Size = new System.Drawing.Size(56, 12);
            this.lab_accountID.TabIndex = 3;
            this.lab_accountID.Text = "AccountID";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(300, 10);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(120, 22);
            this.txt_email.TabIndex = 4;
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Location = new System.Drawing.Point(231, 13);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(32, 12);
            this.lab_email.TabIndex = 5;
            this.lab_email.Text = "Email";
            // 
            // lab_centreName
            // 
            this.lab_centreName.AutoSize = true;
            this.lab_centreName.Location = new System.Drawing.Point(229, 89);
            this.lab_centreName.Name = "lab_centreName";
            this.lab_centreName.Size = new System.Drawing.Size(63, 12);
            this.lab_centreName.TabIndex = 9;
            this.lab_centreName.Text = "CentreName";
            // 
            // txt_centreName
            // 
            this.txt_centreName.Location = new System.Drawing.Point(300, 89);
            this.txt_centreName.Name = "txt_centreName";
            this.txt_centreName.Size = new System.Drawing.Size(120, 22);
            this.txt_centreName.TabIndex = 8;
            // 
            // lab_jobName
            // 
            this.lab_jobName.AutoSize = true;
            this.lab_jobName.Location = new System.Drawing.Point(24, 89);
            this.lab_jobName.Name = "lab_jobName";
            this.lab_jobName.Size = new System.Drawing.Size(51, 12);
            this.lab_jobName.TabIndex = 7;
            this.lab_jobName.Text = "Job Name";
            // 
            // txt_jobName
            // 
            this.txt_jobName.Location = new System.Drawing.Point(86, 86);
            this.txt_jobName.Name = "txt_jobName";
            this.txt_jobName.Size = new System.Drawing.Size(120, 22);
            this.txt_jobName.TabIndex = 6;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(86, 52);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(120, 22);
            this.txt_FirstName.TabIndex = 10;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(300, 52);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(120, 22);
            this.txt_lastName.TabIndex = 11;
            // 
            // lab_firstName
            // 
            this.lab_firstName.AutoSize = true;
            this.lab_firstName.Location = new System.Drawing.Point(24, 55);
            this.lab_firstName.Name = "lab_firstName";
            this.lab_firstName.Size = new System.Drawing.Size(55, 12);
            this.lab_firstName.TabIndex = 12;
            this.lab_firstName.Text = "First Name";
            // 
            // lab_lastName
            // 
            this.lab_lastName.AutoSize = true;
            this.lab_lastName.Location = new System.Drawing.Point(231, 55);
            this.lab_lastName.Name = "lab_lastName";
            this.lab_lastName.Size = new System.Drawing.Size(54, 12);
            this.lab_lastName.TabIndex = 13;
            this.lab_lastName.Text = "Last Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(300, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(33, 20);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.Location = new System.Drawing.Point(229, 126);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(32, 12);
            this.lab_status.TabIndex = 15;
            this.lab_status.Text = "Status";
            // 
            // lab_phoneNo
            // 
            this.lab_phoneNo.AutoSize = true;
            this.lab_phoneNo.Location = new System.Drawing.Point(24, 127);
            this.lab_phoneNo.Name = "lab_phoneNo";
            this.lab_phoneNo.Size = new System.Drawing.Size(48, 12);
            this.lab_phoneNo.TabIndex = 17;
            this.lab_phoneNo.Text = "PhoneNo";
            // 
            // txt_phoneNo
            // 
            this.txt_phoneNo.Location = new System.Drawing.Point(86, 121);
            this.txt_phoneNo.Name = "txt_phoneNo";
            this.txt_phoneNo.Size = new System.Drawing.Size(120, 22);
            this.txt_phoneNo.TabIndex = 16;
            // 
            // btn_ViewALL
            // 
            this.btn_ViewALL.Location = new System.Drawing.Point(529, 119);
            this.btn_ViewALL.Name = "btn_ViewALL";
            this.btn_ViewALL.Size = new System.Drawing.Size(75, 23);
            this.btn_ViewALL.TabIndex = 18;
            this.btn_ViewALL.Text = "View All ";
            this.btn_ViewALL.UseVisualStyleBackColor = true;
            this.btn_ViewALL.Click += new System.EventHandler(this.btn_ViewALL_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(729, 8);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 35);
            this.btn_return.TabIndex = 19;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // ViewStaffAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_ViewALL);
            this.Controls.Add(this.lab_phoneNo);
            this.Controls.Add(this.txt_phoneNo);
            this.Controls.Add(this.lab_status);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lab_lastName);
            this.Controls.Add(this.lab_firstName);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.lab_centreName);
            this.Controls.Add(this.txt_centreName);
            this.Controls.Add(this.lab_jobName);
            this.Controls.Add(this.txt_jobName);
            this.Controls.Add(this.lab_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lab_accountID);
            this.Controls.Add(this.txt_accountID);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewStaffAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - View Staff Account";
            this.Load += new System.EventHandler(this.CreateAndManageStaffAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn centreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.TextBox txt_accountID;
        private System.Windows.Forms.Label lab_accountID;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.Label lab_centreName;
        private System.Windows.Forms.TextBox txt_centreName;
        private System.Windows.Forms.Label lab_jobName;
        private System.Windows.Forms.TextBox txt_jobName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label lab_firstName;
        private System.Windows.Forms.Label lab_lastName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lab_status;
        private System.Windows.Forms.Label lab_phoneNo;
        private System.Windows.Forms.TextBox txt_phoneNo;
        private System.Windows.Forms.Button btn_ViewALL;
        private System.Windows.Forms.Button btn_return;
    }
}