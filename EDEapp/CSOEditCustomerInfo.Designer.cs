
namespace EDEapp
{
    partial class CSOEditCustomerInfo
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
            this.txt_accountID = new System.Windows.Forms.TextBox();
            this.lab_accountID = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lab_phone = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lab_email = new System.Windows.Forms.Label();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.lab_Lname = new System.Windows.Forms.Label();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.lab_Fname = new System.Windows.Forms.Label();
            this.lab_credibility = new System.Windows.Forms.Label();
            this.txt_credibility = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_freezeaccount = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lab_accountStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_accountID
            // 
            this.txt_accountID.Location = new System.Drawing.Point(314, 94);
            this.txt_accountID.Name = "txt_accountID";
            this.txt_accountID.ReadOnly = true;
            this.txt_accountID.Size = new System.Drawing.Size(183, 22);
            this.txt_accountID.TabIndex = 17;
            // 
            // lab_accountID
            // 
            this.lab_accountID.AutoSize = true;
            this.lab_accountID.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_accountID.Location = new System.Drawing.Point(224, 94);
            this.lab_accountID.Name = "lab_accountID";
            this.lab_accountID.Size = new System.Drawing.Size(84, 16);
            this.lab_accountID.TabIndex = 26;
            this.lab_accountID.Text = "AcccountID";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(314, 279);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(183, 22);
            this.txt_phone.TabIndex = 22;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // lab_phone
            // 
            this.lab_phone.AutoSize = true;
            this.lab_phone.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_phone.Location = new System.Drawing.Point(225, 276);
            this.lab_phone.Name = "lab_phone";
            this.lab_phone.Size = new System.Drawing.Size(47, 16);
            this.lab_phone.TabIndex = 24;
            this.lab_phone.Text = "Phone";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(314, 226);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(183, 22);
            this.txt_email.TabIndex = 21;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_email.Location = new System.Drawing.Point(226, 226);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(44, 16);
            this.lab_email.TabIndex = 23;
            this.lab_email.Text = "Email";
            // 
            // txt_Lname
            // 
            this.txt_Lname.Location = new System.Drawing.Point(314, 180);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(183, 22);
            this.txt_Lname.TabIndex = 20;
            this.txt_Lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Lname_KeyPress);
            // 
            // lab_Lname
            // 
            this.lab_Lname.AutoSize = true;
            this.lab_Lname.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Lname.Location = new System.Drawing.Point(226, 177);
            this.lab_Lname.Name = "lab_Lname";
            this.lab_Lname.Size = new System.Drawing.Size(75, 16);
            this.lab_Lname.TabIndex = 18;
            this.lab_Lname.Text = "Last Name";
            // 
            // txt_Fname
            // 
            this.txt_Fname.Location = new System.Drawing.Point(314, 134);
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(183, 22);
            this.txt_Fname.TabIndex = 19;
            this.txt_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Fname_KeyPress);
            // 
            // lab_Fname
            // 
            this.lab_Fname.AutoSize = true;
            this.lab_Fname.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Fname.Location = new System.Drawing.Point(225, 134);
            this.lab_Fname.Name = "lab_Fname";
            this.lab_Fname.Size = new System.Drawing.Size(76, 16);
            this.lab_Fname.TabIndex = 16;
            this.lab_Fname.Text = "First Name";
            // 
            // lab_credibility
            // 
            this.lab_credibility.AutoSize = true;
            this.lab_credibility.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_credibility.Location = new System.Drawing.Point(226, 322);
            this.lab_credibility.Name = "lab_credibility";
            this.lab_credibility.Size = new System.Drawing.Size(74, 16);
            this.lab_credibility.TabIndex = 27;
            this.lab_credibility.Text = "Credibility";
            // 
            // txt_credibility
            // 
            this.txt_credibility.Location = new System.Drawing.Point(314, 322);
            this.txt_credibility.Name = "txt_credibility";
            this.txt_credibility.Size = new System.Drawing.Size(183, 22);
            this.txt_credibility.TabIndex = 28;
            this.txt_credibility.TextChanged += new System.EventHandler(this.txt_credibility_TextChanged);
            this.txt_credibility.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_credibility_KeyPress);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(704, 15);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "<<Return";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(422, 373);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 30;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_freezeaccount
            // 
            this.btn_freezeaccount.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_freezeaccount.Location = new System.Drawing.Point(641, 352);
            this.btn_freezeaccount.Name = "btn_freezeaccount";
            this.btn_freezeaccount.Size = new System.Drawing.Size(147, 36);
            this.btn_freezeaccount.TabIndex = 31;
            this.btn_freezeaccount.Text = "Freeze Account";
            this.btn_freezeaccount.UseVisualStyleBackColor = true;
            this.btn_freezeaccount.Click += new System.EventHandler(this.btn_freezeaccount_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_delete.Location = new System.Drawing.Point(641, 392);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 36);
            this.btn_delete.TabIndex = 32;
            this.btn_delete.Text = "Delete Account";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lab_accountStatus
            // 
            this.lab_accountStatus.AutoSize = true;
            this.lab_accountStatus.Location = new System.Drawing.Point(726, 32);
            this.lab_accountStatus.Name = "lab_accountStatus";
            this.lab_accountStatus.Size = new System.Drawing.Size(0, 12);
            this.lab_accountStatus.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Edit Customer Information";
            // 
            // CSOEditCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_accountStatus);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_freezeaccount);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_credibility);
            this.Controls.Add(this.lab_credibility);
            this.Controls.Add(this.txt_accountID);
            this.Controls.Add(this.lab_accountID);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lab_phone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lab_email);
            this.Controls.Add(this.txt_Lname);
            this.Controls.Add(this.lab_Lname);
            this.Controls.Add(this.txt_Fname);
            this.Controls.Add(this.lab_Fname);
            this.Name = "CSOEditCustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Edit Customer Information";
            this.Load += new System.EventHandler(this.CSOEditCustomerInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_accountID;
        private System.Windows.Forms.Label lab_accountID;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lab_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.Label lab_Lname;
        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.Label lab_Fname;
        private System.Windows.Forms.Label lab_credibility;
        private System.Windows.Forms.TextBox txt_credibility;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_freezeaccount;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lab_accountStatus;
        private System.Windows.Forms.Label label1;
    }
}