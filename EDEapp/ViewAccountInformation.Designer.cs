
namespace EDEapp
{
    partial class ViewAccountInformation
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lab_viewaccount = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lab_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_accountID = new System.Windows.Forms.TextBox();
            this.lab_accountID = new System.Windows.Forms.Label();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.lab_FName = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lab_LName = new System.Windows.Forms.Label();
            this.txt_credibility = new System.Windows.Forms.TextBox();
            this.lab_credbility = new System.Windows.Forms.Label();
            this.btn_creditcardinformation = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(695, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(93, 46);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "<<Return Menu";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lab_viewaccount
            // 
            this.lab_viewaccount.AutoSize = true;
            this.lab_viewaccount.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.lab_viewaccount.Location = new System.Drawing.Point(12, 23);
            this.lab_viewaccount.Name = "lab_viewaccount";
            this.lab_viewaccount.Size = new System.Drawing.Size(163, 20);
            this.lab_viewaccount.TabIndex = 1;
            this.lab_viewaccount.Text = "Account Information";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(695, 390);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(93, 48);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "Edit Information";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(313, 266);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.ReadOnly = true;
            this.txt_phone.Size = new System.Drawing.Size(232, 22);
            this.txt_phone.TabIndex = 13;
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_email.Location = new System.Drawing.Point(230, 217);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(44, 16);
            this.lab_email.TabIndex = 12;
            this.lab_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(313, 214);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(232, 22);
            this.txt_email.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(230, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Phone";
            // 
            // txt_accountID
            // 
            this.txt_accountID.Location = new System.Drawing.Point(313, 68);
            this.txt_accountID.Name = "txt_accountID";
            this.txt_accountID.ReadOnly = true;
            this.txt_accountID.Size = new System.Drawing.Size(232, 22);
            this.txt_accountID.TabIndex = 9;
            // 
            // lab_accountID
            // 
            this.lab_accountID.AutoSize = true;
            this.lab_accountID.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_accountID.Location = new System.Drawing.Point(230, 71);
            this.lab_accountID.Name = "lab_accountID";
            this.lab_accountID.Size = new System.Drawing.Size(77, 16);
            this.lab_accountID.TabIndex = 8;
            this.lab_accountID.Text = "AccountID";
            // 
            // txt_FName
            // 
            this.txt_FName.Location = new System.Drawing.Point(313, 114);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.ReadOnly = true;
            this.txt_FName.Size = new System.Drawing.Size(232, 22);
            this.txt_FName.TabIndex = 17;
            // 
            // lab_FName
            // 
            this.lab_FName.AutoSize = true;
            this.lab_FName.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_FName.Location = new System.Drawing.Point(230, 117);
            this.lab_FName.Name = "lab_FName";
            this.lab_FName.Size = new System.Drawing.Size(76, 16);
            this.lab_FName.TabIndex = 16;
            this.lab_FName.Text = "First Name";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(313, 160);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.ReadOnly = true;
            this.txt_LastName.Size = new System.Drawing.Size(232, 22);
            this.txt_LastName.TabIndex = 19;
            // 
            // lab_LName
            // 
            this.lab_LName.AutoSize = true;
            this.lab_LName.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_LName.Location = new System.Drawing.Point(230, 163);
            this.lab_LName.Name = "lab_LName";
            this.lab_LName.Size = new System.Drawing.Size(75, 16);
            this.lab_LName.TabIndex = 18;
            this.lab_LName.Text = "Last Name";
            // 
            // txt_credibility
            // 
            this.txt_credibility.Location = new System.Drawing.Point(313, 327);
            this.txt_credibility.Name = "txt_credibility";
            this.txt_credibility.ReadOnly = true;
            this.txt_credibility.Size = new System.Drawing.Size(232, 22);
            this.txt_credibility.TabIndex = 21;
            // 
            // lab_credbility
            // 
            this.lab_credbility.AutoSize = true;
            this.lab_credbility.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_credbility.Location = new System.Drawing.Point(229, 327);
            this.lab_credbility.Name = "lab_credbility";
            this.lab_credbility.Size = new System.Drawing.Size(74, 16);
            this.lab_credbility.TabIndex = 20;
            this.lab_credbility.Text = "Credibility";
            // 
            // btn_creditcardinformation
            // 
            this.btn_creditcardinformation.Location = new System.Drawing.Point(16, 78);
            this.btn_creditcardinformation.Name = "btn_creditcardinformation";
            this.btn_creditcardinformation.Size = new System.Drawing.Size(78, 51);
            this.btn_creditcardinformation.TabIndex = 22;
            this.btn_creditcardinformation.Text = "Check Card";
            this.btn_creditcardinformation.UseVisualStyleBackColor = true;
            this.btn_creditcardinformation.Click += new System.EventHandler(this.btn_creditcardinformation_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(16, 160);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(78, 51);
            this.btn_reset.TabIndex = 23;
            this.btn_reset.Text = "Reset Password";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // ViewAccountInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_creditcardinformation);
            this.Controls.Add(this.txt_credibility);
            this.Controls.Add(this.lab_credbility);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.lab_LName);
            this.Controls.Add(this.txt_FName);
            this.Controls.Add(this.lab_FName);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lab_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_accountID);
            this.Controls.Add(this.lab_accountID);
            this.Controls.Add(this.lab_viewaccount);
            this.Controls.Add(this.btn_back);
            this.Name = "ViewAccountInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAccountInformation";
            this.Load += new System.EventHandler(this.ViewAccountInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lab_viewaccount;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_accountID;
        private System.Windows.Forms.Label lab_accountID;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.Label lab_FName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lab_LName;
        private System.Windows.Forms.TextBox txt_credibility;
        private System.Windows.Forms.Label lab_credbility;
        private System.Windows.Forms.Button btn_creditcardinformation;
        private System.Windows.Forms.Button btn_reset;
    }
}