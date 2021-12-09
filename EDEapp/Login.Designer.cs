
namespace EDEapp
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.lab_accountID = new System.Windows.Forms.Label();
            this.txt_accountID = new System.Windows.Forms.TextBox();
            this.lab_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.check_robot = new System.Windows.Forms.CheckBox();
            this.lab_forgotpassword = new System.Windows.Forms.Label();
            this.btn_ShippingExpensesCalculator = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.lab_times = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_contactus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_accountID
            // 
            this.lab_accountID.AutoSize = true;
            this.lab_accountID.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_accountID.Location = new System.Drawing.Point(191, 161);
            this.lab_accountID.Name = "lab_accountID";
            this.lab_accountID.Size = new System.Drawing.Size(45, 15);
            this.lab_accountID.TabIndex = 0;
            this.lab_accountID.Text = "Email:";
            // 
            // txt_accountID
            // 
            this.txt_accountID.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_accountID.Location = new System.Drawing.Point(242, 160);
            this.txt_accountID.Name = "txt_accountID";
            this.txt_accountID.Size = new System.Drawing.Size(164, 23);
            this.txt_accountID.TabIndex = 1;
            this.txt_accountID.TextChanged += new System.EventHandler(this.txt_accountID_TextChanged);
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_password.Location = new System.Drawing.Point(172, 205);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(64, 15);
            this.lab_password.TabIndex = 2;
            this.lab_password.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_password.Location = new System.Drawing.Point(242, 204);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(164, 23);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_login.Location = new System.Drawing.Point(242, 257);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 32);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // check_robot
            // 
            this.check_robot.AutoSize = true;
            this.check_robot.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.check_robot.Location = new System.Drawing.Point(242, 232);
            this.check_robot.Name = "check_robot";
            this.check_robot.Size = new System.Drawing.Size(108, 19);
            this.check_robot.TabIndex = 6;
            this.check_robot.Text = "I am not robot";
            this.check_robot.UseVisualStyleBackColor = true;
            // 
            // lab_forgotpassword
            // 
            this.lab_forgotpassword.AutoSize = true;
            this.lab_forgotpassword.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_forgotpassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lab_forgotpassword.Location = new System.Drawing.Point(412, 274);
            this.lab_forgotpassword.Name = "lab_forgotpassword";
            this.lab_forgotpassword.Size = new System.Drawing.Size(102, 15);
            this.lab_forgotpassword.TabIndex = 7;
            this.lab_forgotpassword.Text = "Forgot Password";
            this.lab_forgotpassword.Click += new System.EventHandler(this.lab_forgotpassword_Click);
            // 
            // btn_ShippingExpensesCalculator
            // 
            this.btn_ShippingExpensesCalculator.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ShippingExpensesCalculator.Location = new System.Drawing.Point(129, 318);
            this.btn_ShippingExpensesCalculator.Name = "btn_ShippingExpensesCalculator";
            this.btn_ShippingExpensesCalculator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ShippingExpensesCalculator.Size = new System.Drawing.Size(157, 47);
            this.btn_ShippingExpensesCalculator.TabIndex = 8;
            this.btn_ShippingExpensesCalculator.Text = "Shipping Expenses Calculator";
            this.btn_ShippingExpensesCalculator.UseVisualStyleBackColor = true;
            this.btn_ShippingExpensesCalculator.Click += new System.EventHandler(this.btn_ShippingExpensesCalculator_Click);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_register.Location = new System.Drawing.Point(331, 257);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 32);
            this.btn_register.TabIndex = 9;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lab_times
            // 
            this.lab_times.AutoSize = true;
            this.lab_times.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_times.Location = new System.Drawing.Point(12, 380);
            this.lab_times.Name = "lab_times";
            this.lab_times.Size = new System.Drawing.Size(57, 13);
            this.lab_times.TabIndex = 15;
            this.lab_times.Text = "Date Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_contactus
            // 
            this.btn_contactus.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_contactus.Location = new System.Drawing.Point(366, 318);
            this.btn_contactus.Name = "btn_contactus";
            this.btn_contactus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_contactus.Size = new System.Drawing.Size(157, 47);
            this.btn_contactus.TabIndex = 16;
            this.btn_contactus.Text = "Contact us";
            this.btn_contactus.UseVisualStyleBackColor = true;
            this.btn_contactus.Click += new System.EventHandler(this.btn_contactus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EDEapp.Properties.Resources.ede_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_hide
            // 
            this.btn_hide.Image = global::EDEapp.Properties.Resources.icons8_hide_24;
            this.btn_hide.Location = new System.Drawing.Point(407, 204);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(28, 22);
            this.btn_hide.TabIndex = 18;
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_show
            // 
            this.btn_show.Image = global::EDEapp.Properties.Resources.icons8_preview_pane_32;
            this.btn_show.Location = new System.Drawing.Point(407, 204);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(28, 22);
            this.btn_show.TabIndex = 17;
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_contactus);
            this.Controls.Add(this.lab_times);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_ShippingExpensesCalculator);
            this.Controls.Add(this.lab_forgotpassword);
            this.Controls.Add(this.check_robot);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lab_password);
            this.Controls.Add(this.txt_accountID);
            this.Controls.Add(this.lab_accountID);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_accountID;
        private System.Windows.Forms.TextBox txt_accountID;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox check_robot;
        private System.Windows.Forms.Label lab_forgotpassword;
        private System.Windows.Forms.Button btn_ShippingExpensesCalculator;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lab_times;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_contactus;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}