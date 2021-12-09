
namespace EDEapp
{
    partial class CodeConfirm
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
            this.lab_code = new System.Windows.Forms.Label();
            this.txt_confirmcode = new System.Windows.Forms.TextBox();
            this.lab_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_verifycode = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_code
            // 
            this.lab_code.AutoSize = true;
            this.lab_code.Location = new System.Drawing.Point(28, 163);
            this.lab_code.Name = "lab_code";
            this.lab_code.Size = new System.Drawing.Size(73, 12);
            this.lab_code.TabIndex = 0;
            this.lab_code.Text = "Confirm Code";
            // 
            // txt_confirmcode
            // 
            this.txt_confirmcode.Location = new System.Drawing.Point(107, 160);
            this.txt_confirmcode.Name = "txt_confirmcode";
            this.txt_confirmcode.Size = new System.Drawing.Size(191, 22);
            this.txt_confirmcode.TabIndex = 1;
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Location = new System.Drawing.Point(30, 65);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(32, 12);
            this.lab_email.TabIndex = 2;
            this.lab_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(107, 62);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(191, 22);
            this.txt_email.TabIndex = 3;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(223, 102);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_verifycode
            // 
            this.btn_verifycode.Location = new System.Drawing.Point(223, 211);
            this.btn_verifycode.Name = "btn_verifycode";
            this.btn_verifycode.Size = new System.Drawing.Size(75, 23);
            this.btn_verifycode.TabIndex = 5;
            this.btn_verifycode.Text = "Verify code";
            this.btn_verifycode.UseVisualStyleBackColor = true;
            this.btn_verifycode.Click += new System.EventHandler(this.btn_verifycode_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(712, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(76, 54);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "<<Return";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // CodeConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_verifycode);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lab_email);
            this.Controls.Add(this.txt_confirmcode);
            this.Controls.Add(this.lab_code);
            this.Name = "CodeConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "code confirm";
            this.Load += new System.EventHandler(this.CodeConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_code;
        private System.Windows.Forms.TextBox txt_confirmcode;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_verifycode;
        private System.Windows.Forms.Button btn_back;
    }
}