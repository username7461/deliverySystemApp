
namespace EDEapp
{
    partial class EditStaffAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_centreName = new System.Windows.Forms.TextBox();
            this.txt_jobname = new System.Windows.Forms.TextBox();
            this.lab_jobname = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lab_LName = new System.Windows.Forms.Label();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.lab_FName = new System.Windows.Forms.Label();
            this.lab_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_accountID = new System.Windows.Forms.TextBox();
            this.lab_accountID = new System.Windows.Forms.Label();
            this.lab_viewaccount = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.combo_status = new System.Windows.Forms.ComboBox();
            this.lab_status = new System.Windows.Forms.Label();
            this.combo_centreID = new System.Windows.Forms.ComboBox();
            this.combo_jobID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 54;
            this.label2.Text = "CentreID";
            // 
            // txt_centreName
            // 
            this.txt_centreName.Location = new System.Drawing.Point(516, 173);
            this.txt_centreName.Name = "txt_centreName";
            this.txt_centreName.ReadOnly = true;
            this.txt_centreName.Size = new System.Drawing.Size(232, 22);
            this.txt_centreName.TabIndex = 53;
            // 
            // txt_jobname
            // 
            this.txt_jobname.Location = new System.Drawing.Point(516, 124);
            this.txt_jobname.Name = "txt_jobname";
            this.txt_jobname.ReadOnly = true;
            this.txt_jobname.Size = new System.Drawing.Size(232, 22);
            this.txt_jobname.TabIndex = 52;
            // 
            // lab_jobname
            // 
            this.lab_jobname.AutoSize = true;
            this.lab_jobname.Location = new System.Drawing.Point(359, 127);
            this.lab_jobname.Name = "lab_jobname";
            this.lab_jobname.Size = new System.Drawing.Size(36, 12);
            this.lab_jobname.TabIndex = 51;
            this.lab_jobname.Text = "Job ID";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(101, 219);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(232, 22);
            this.txt_LastName.TabIndex = 50;
            this.txt_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LastName_KeyPress);
            // 
            // lab_LName
            // 
            this.lab_LName.AutoSize = true;
            this.lab_LName.Location = new System.Drawing.Point(18, 222);
            this.lab_LName.Name = "lab_LName";
            this.lab_LName.Size = new System.Drawing.Size(54, 12);
            this.lab_LName.TabIndex = 49;
            this.lab_LName.Text = "Last Name";
            // 
            // txt_FName
            // 
            this.txt_FName.Location = new System.Drawing.Point(101, 173);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(232, 22);
            this.txt_FName.TabIndex = 48;
            this.txt_FName.TextChanged += new System.EventHandler(this.txt_FName_TextChanged);
            this.txt_FName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FName_KeyPress);
            // 
            // lab_FName
            // 
            this.lab_FName.AutoSize = true;
            this.lab_FName.Location = new System.Drawing.Point(18, 176);
            this.lab_FName.Name = "lab_FName";
            this.lab_FName.Size = new System.Drawing.Size(55, 12);
            this.lab_FName.TabIndex = 47;
            this.lab_FName.Text = "First Name";
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Location = new System.Drawing.Point(18, 276);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(32, 12);
            this.lab_email.TabIndex = 45;
            this.lab_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(101, 273);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(232, 22);
            this.txt_email.TabIndex = 44;
            // 
            // txt_accountID
            // 
            this.txt_accountID.Location = new System.Drawing.Point(101, 127);
            this.txt_accountID.Name = "txt_accountID";
            this.txt_accountID.ReadOnly = true;
            this.txt_accountID.Size = new System.Drawing.Size(232, 22);
            this.txt_accountID.TabIndex = 42;
            // 
            // lab_accountID
            // 
            this.lab_accountID.AutoSize = true;
            this.lab_accountID.Location = new System.Drawing.Point(18, 130);
            this.lab_accountID.Name = "lab_accountID";
            this.lab_accountID.Size = new System.Drawing.Size(56, 12);
            this.lab_accountID.TabIndex = 41;
            this.lab_accountID.Text = "AccountID";
            // 
            // lab_viewaccount
            // 
            this.lab_viewaccount.AutoSize = true;
            this.lab_viewaccount.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_viewaccount.Location = new System.Drawing.Point(13, 52);
            this.lab_viewaccount.Name = "lab_viewaccount";
            this.lab_viewaccount.Size = new System.Drawing.Size(182, 20);
            this.lab_viewaccount.TabIndex = 40;
            this.lab_viewaccount.Text = "Account Information";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(679, 52);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(91, 45);
            this.btn_back.TabIndex = 39;
            this.btn_back.Text = "<<Return Menu";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(679, 379);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(69, 34);
            this.btn_edit.TabIndex = 55;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // combo_status
            // 
            this.combo_status.FormattingEnabled = true;
            this.combo_status.Location = new System.Drawing.Point(444, 222);
            this.combo_status.Name = "combo_status";
            this.combo_status.Size = new System.Drawing.Size(50, 20);
            this.combo_status.TabIndex = 56;
            this.combo_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_status_KeyPress);
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.Location = new System.Drawing.Point(359, 225);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(32, 12);
            this.lab_status.TabIndex = 57;
            this.lab_status.Text = "Status";
            // 
            // combo_centreID
            // 
            this.combo_centreID.FormattingEnabled = true;
            this.combo_centreID.Location = new System.Drawing.Point(444, 175);
            this.combo_centreID.Name = "combo_centreID";
            this.combo_centreID.Size = new System.Drawing.Size(50, 20);
            this.combo_centreID.TabIndex = 58;
            // 
            // combo_jobID
            // 
            this.combo_jobID.FormattingEnabled = true;
            this.combo_jobID.Location = new System.Drawing.Point(444, 124);
            this.combo_jobID.Name = "combo_jobID";
            this.combo_jobID.Size = new System.Drawing.Size(50, 20);
            this.combo_jobID.TabIndex = 59;
            // 
            // EditStaffAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combo_jobID);
            this.Controls.Add(this.combo_centreID);
            this.Controls.Add(this.lab_status);
            this.Controls.Add(this.combo_status);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_centreName);
            this.Controls.Add(this.txt_jobname);
            this.Controls.Add(this.lab_jobname);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.lab_LName);
            this.Controls.Add(this.txt_FName);
            this.Controls.Add(this.lab_FName);
            this.Controls.Add(this.lab_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_accountID);
            this.Controls.Add(this.lab_accountID);
            this.Controls.Add(this.lab_viewaccount);
            this.Controls.Add(this.btn_back);
            this.Name = "EditStaffAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Edit Staff Account";
            this.Load += new System.EventHandler(this.EditStaffAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_centreName;
        private System.Windows.Forms.TextBox txt_jobname;
        private System.Windows.Forms.Label lab_jobname;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lab_LName;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.Label lab_FName;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_accountID;
        private System.Windows.Forms.Label lab_accountID;
        private System.Windows.Forms.Label lab_viewaccount;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox combo_status;
        private System.Windows.Forms.Label lab_status;
        private System.Windows.Forms.ComboBox combo_centreID;
        private System.Windows.Forms.ComboBox combo_jobID;
    }
}