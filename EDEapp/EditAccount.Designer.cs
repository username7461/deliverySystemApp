
namespace EDEapp
{
    partial class EditAccount
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
            this.lab_accountID = new System.Windows.Forms.Label();
            this.txt_accountID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lab_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.check_confirm = new System.Windows.Forms.CheckBox();
            this.btn_backtoview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_accountID
            // 
            this.lab_accountID.AutoSize = true;
            this.lab_accountID.Location = new System.Drawing.Point(95, 68);
            this.lab_accountID.Name = "lab_accountID";
            this.lab_accountID.Size = new System.Drawing.Size(56, 12);
            this.lab_accountID.TabIndex = 0;
            this.lab_accountID.Text = "AccountID";
            // 
            // txt_accountID
            // 
            this.txt_accountID.Location = new System.Drawing.Point(178, 57);
            this.txt_accountID.Name = "txt_accountID";
            this.txt_accountID.ReadOnly = true;
            this.txt_accountID.Size = new System.Drawing.Size(232, 22);
            this.txt_accountID.TabIndex = 1;
            this.txt_accountID.TextChanged += new System.EventHandler(this.txt_accountID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phone";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(178, 116);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(232, 22);
            this.txt_phone.TabIndex = 3;
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Location = new System.Drawing.Point(95, 168);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(32, 12);
            this.lab_email.TabIndex = 4;
            this.lab_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(178, 168);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(232, 22);
            this.txt_email.TabIndex = 5;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(335, 249);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 33);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // check_confirm
            // 
            this.check_confirm.AutoSize = true;
            this.check_confirm.Location = new System.Drawing.Point(178, 217);
            this.check_confirm.Name = "check_confirm";
            this.check_confirm.Size = new System.Drawing.Size(86, 16);
            this.check_confirm.TabIndex = 6;
            this.check_confirm.Text = "Confirm Edit";
            this.check_confirm.UseVisualStyleBackColor = true;
            // 
            // btn_backtoview
            // 
            this.btn_backtoview.Location = new System.Drawing.Point(713, 12);
            this.btn_backtoview.Name = "btn_backtoview";
            this.btn_backtoview.Size = new System.Drawing.Size(75, 43);
            this.btn_backtoview.TabIndex = 8;
            this.btn_backtoview.Text = "<<Return";
            this.btn_backtoview.UseVisualStyleBackColor = true;
            this.btn_backtoview.Click += new System.EventHandler(this.btn_backtoview_Click);
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_backtoview);
            this.Controls.Add(this.check_confirm);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lab_email);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_accountID);
            this.Controls.Add(this.lab_accountID);
            this.Name = "EditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditAccount";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_accountID;
        private System.Windows.Forms.TextBox txt_accountID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.CheckBox check_confirm;
        private System.Windows.Forms.Button btn_backtoview;
    }
}