
namespace EDEapp
{
    partial class Register
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

        #region 

        private void InitializeComponent()
        {
            this.lab_Fname = new System.Windows.Forms.Label();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.lab_Lname = new System.Windows.Forms.Label();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lab_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lab_phone = new System.Windows.Forms.Label();
            this.lab_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_Repassword = new System.Windows.Forms.TextBox();
            this.lab_Repassword = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lab_emailmessage = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.check_robot = new System.Windows.Forms.CheckBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lab_Fname
            // 
            this.lab_Fname.AutoSize = true;
            this.lab_Fname.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Fname.Location = new System.Drawing.Point(39, 81);
            this.lab_Fname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Fname.Name = "lab_Fname";
            this.lab_Fname.Size = new System.Drawing.Size(70, 15);
            this.lab_Fname.TabIndex = 0;
            this.lab_Fname.Text = "First Name";
            // 
            // txt_Fname
            // 
            this.txt_Fname.Location = new System.Drawing.Point(121, 78);
            this.txt_Fname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(243, 25);
            this.txt_Fname.TabIndex = 2;
            this.txt_Fname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Fname_KeyPress);
            // 
            // lab_Lname
            // 
            this.lab_Lname.AutoSize = true;
            this.lab_Lname.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Lname.Location = new System.Drawing.Point(478, 81);
            this.lab_Lname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Lname.Name = "lab_Lname";
            this.lab_Lname.Size = new System.Drawing.Size(68, 15);
            this.lab_Lname.TabIndex = 2;
            this.lab_Lname.Text = "Last Name";
            // 
            // txt_Lname
            // 
            this.txt_Lname.Location = new System.Drawing.Point(554, 78);
            this.txt_Lname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(243, 25);
            this.txt_Lname.TabIndex = 3;
            this.txt_Lname.TextChanged += new System.EventHandler(this.txt_Lname_TextChanged);
            this.txt_Lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Lname_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_add.Location = new System.Drawing.Point(593, 259);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(224, 68);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "CreateAccount";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_email.Location = new System.Drawing.Point(70, 138);
            this.lab_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(41, 15);
            this.lab_email.TabIndex = 5;
            this.lab_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(121, 134);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(243, 25);
            this.txt_email.TabIndex = 4;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // lab_phone
            // 
            this.lab_phone.AutoSize = true;
            this.lab_phone.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_phone.Location = new System.Drawing.Point(435, 138);
            this.lab_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_phone.Name = "lab_phone";
            this.lab_phone.Size = new System.Drawing.Size(42, 15);
            this.lab_phone.TabIndex = 7;
            this.lab_phone.Text = "Phone";
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_password.Location = new System.Drawing.Point(49, 190);
            this.lab_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(60, 15);
            this.lab_password.TabIndex = 9;
            this.lab_password.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(121, 186);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(243, 25);
            this.txt_password.TabIndex = 6;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_Repassword
            // 
            this.txt_Repassword.Location = new System.Drawing.Point(554, 186);
            this.txt_Repassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Repassword.Name = "txt_Repassword";
            this.txt_Repassword.Size = new System.Drawing.Size(243, 25);
            this.txt_Repassword.TabIndex = 7;
            this.txt_Repassword.TextChanged += new System.EventHandler(this.txt_Repassword_TextChanged);
            // 
            // lab_Repassword
            // 
            this.lab_Repassword.AutoSize = true;
            this.lab_Repassword.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Repassword.Location = new System.Drawing.Point(434, 190);
            this.lab_Repassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Repassword.Name = "lab_Repassword";
            this.lab_Repassword.Size = new System.Drawing.Size(112, 15);
            this.lab_Repassword.TabIndex = 12;
            this.lab_Repassword.Text = "Confirm Password";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(554, 134);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(243, 24);
            this.txt_phone.TabIndex = 5;
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // lab_emailmessage
            // 
            this.lab_emailmessage.AutoSize = true;
            this.lab_emailmessage.Location = new System.Drawing.Point(353, 186);
            this.lab_emailmessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_emailmessage.Name = "lab_emailmessage";
            this.lab_emailmessage.Size = new System.Drawing.Size(0, 15);
            this.lab_emailmessage.TabIndex = 14;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.Location = new System.Drawing.Point(386, 259);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(171, 68);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // check_robot
            // 
            this.check_robot.AutoSize = true;
            this.check_robot.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.check_robot.Location = new System.Drawing.Point(697, 231);
            this.check_robot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_robot.Name = "check_robot";
            this.check_robot.Size = new System.Drawing.Size(108, 19);
            this.check_robot.TabIndex = 9;
            this.check_robot.Text = "I am not robot";
            this.check_robot.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_back.Location = new System.Drawing.Point(841, 15);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 54);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Back To Login";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(485, 134);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 23);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 444);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.check_robot);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lab_emailmessage);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lab_Repassword);
            this.Controls.Add(this.txt_Repassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lab_password);
            this.Controls.Add(this.lab_phone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lab_email);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_Lname);
            this.Controls.Add(this.lab_Lname);
            this.Controls.Add(this.txt_Fname);
            this.Controls.Add(this.lab_Fname);
            this.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Fname;
        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.Label lab_Lname;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lab_phone;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_Repassword;
        private System.Windows.Forms.Label lab_Repassword;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lab_emailmessage;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.CheckBox check_robot;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

