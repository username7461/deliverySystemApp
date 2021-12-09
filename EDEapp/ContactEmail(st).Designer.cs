
namespace EDEapp
{
    partial class ContactEmailShaTin
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
            this.lab_contactUs = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_contactUs
            // 
            this.lab_contactUs.AutoSize = true;
            this.lab_contactUs.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.lab_contactUs.Location = new System.Drawing.Point(102, 9);
            this.lab_contactUs.Name = "lab_contactUs";
            this.lab_contactUs.Size = new System.Drawing.Size(77, 16);
            this.lab_contactUs.TabIndex = 0;
            this.lab_contactUs.Text = "Contact Us";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(18, 43);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(41, 12);
            this.lab_name.TabIndex = 1;
            this.lab_name.Text = "Name *";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(20, 58);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(264, 22);
            this.txt_name.TabIndex = 2;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(20, 116);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(264, 22);
            this.txt_email.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone *";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(20, 171);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(264, 22);
            this.txt_phone.TabIndex = 5;
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Subject * ";
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(20, 229);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(264, 22);
            this.txt_subject.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Message *";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(20, 280);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(264, 98);
            this.txt_message.TabIndex = 9;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(20, 403);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(264, 23);
            this.btn_send.TabIndex = 11;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // ContactEmailShaTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 447);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.lab_contactUs);
            this.Name = "ContactEmailShaTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Email";
            this.Load += new System.EventHandler(this.ContactEmailShaTin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_contactUs;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button btn_send;
    }
}