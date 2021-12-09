
namespace EDEapp
{
    partial class ReSetPassWord
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
            this.lab_password = new System.Windows.Forms.Label();
            this.lab_confirmpassword = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_confirmpassword = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lab_oldpassword = new System.Windows.Forms.Label();
            this.txt_oldpassword = new System.Windows.Forms.TextBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_password.Location = new System.Drawing.Point(21, 150);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(90, 15);
            this.lab_password.TabIndex = 0;
            this.lab_password.Text = "New Password";
            // 
            // lab_confirmpassword
            // 
            this.lab_confirmpassword.AutoSize = true;
            this.lab_confirmpassword.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_confirmpassword.Location = new System.Drawing.Point(21, 203);
            this.lab_confirmpassword.Name = "lab_confirmpassword";
            this.lab_confirmpassword.Size = new System.Drawing.Size(142, 15);
            this.lab_confirmpassword.TabIndex = 1;
            this.lab_confirmpassword.Text = "New Confirm Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(167, 145);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(199, 22);
            this.txt_password.TabIndex = 2;
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.Location = new System.Drawing.Point(167, 198);
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.Size = new System.Drawing.Size(199, 22);
            this.txt_confirmpassword.TabIndex = 3;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(291, 252);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lab_oldpassword
            // 
            this.lab_oldpassword.AutoSize = true;
            this.lab_oldpassword.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_oldpassword.Location = new System.Drawing.Point(21, 100);
            this.lab_oldpassword.Name = "lab_oldpassword";
            this.lab_oldpassword.Size = new System.Drawing.Size(85, 15);
            this.lab_oldpassword.TabIndex = 5;
            this.lab_oldpassword.Text = "Old Password";
            // 
            // txt_oldpassword
            // 
            this.txt_oldpassword.Location = new System.Drawing.Point(167, 95);
            this.txt_oldpassword.Name = "txt_oldpassword";
            this.txt_oldpassword.Size = new System.Drawing.Size(199, 22);
            this.txt_oldpassword.TabIndex = 1;
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_return.Location = new System.Drawing.Point(283, 12);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(83, 42);
            this.btn_return.TabIndex = 5;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reset Password";
            // 
            // ReSetPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.txt_oldpassword);
            this.Controls.Add(this.lab_oldpassword);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_confirmpassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lab_confirmpassword);
            this.Controls.Add(this.lab_password);
            this.Name = "ReSetPassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Reset Password";
            this.Load += new System.EventHandler(this.ReSetPassWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.Label lab_confirmpassword;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_confirmpassword;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lab_oldpassword;
        private System.Windows.Forms.TextBox txt_oldpassword;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label label1;
    }
}