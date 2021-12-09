
namespace EDEapp
{
    partial class CreateStaffAcccount
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.check_robot = new System.Windows.Forms.CheckBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lab_emailmessage = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lab_Repassword = new System.Windows.Forms.Label();
            this.txt_Repassword = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lab_password = new System.Windows.Forms.Label();
            this.lab_phone = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lab_email = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.lab_Lname = new System.Windows.Forms.Label();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.lab_Fname = new System.Windows.Forms.Label();
            this.lab_centreID = new System.Windows.Forms.Label();
            this.lab_jobID = new System.Windows.Forms.Label();
            this.combo_job = new System.Windows.Forms.ComboBox();
            this.combo_centre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(442, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(704, 7);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 43);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back To Menu";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // check_robot
            // 
            this.check_robot.AutoSize = true;
            this.check_robot.Location = new System.Drawing.Point(509, 282);
            this.check_robot.Name = "check_robot";
            this.check_robot.Size = new System.Drawing.Size(91, 16);
            this.check_robot.TabIndex = 10;
            this.check_robot.Text = "I am not robot";
            this.check_robot.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.Location = new System.Drawing.Point(354, 304);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(128, 54);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lab_emailmessage
            // 
            this.lab_emailmessage.AutoSize = true;
            this.lab_emailmessage.Location = new System.Drawing.Point(343, 197);
            this.lab_emailmessage.Name = "lab_emailmessage";
            this.lab_emailmessage.Size = new System.Drawing.Size(0, 12);
            this.lab_emailmessage.TabIndex = 32;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(494, 155);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(183, 20);
            this.txt_phone.TabIndex = 5;
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // lab_Repassword
            // 
            this.lab_Repassword.AutoSize = true;
            this.lab_Repassword.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Repassword.Location = new System.Drawing.Point(366, 200);
            this.lab_Repassword.Name = "lab_Repassword";
            this.lab_Repassword.Size = new System.Drawing.Size(112, 15);
            this.lab_Repassword.TabIndex = 31;
            this.lab_Repassword.Text = "Confirm Password";
            // 
            // txt_Repassword
            // 
            this.txt_Repassword.Location = new System.Drawing.Point(494, 197);
            this.txt_Repassword.Name = "txt_Repassword";
            this.txt_Repassword.Size = new System.Drawing.Size(183, 22);
            this.txt_Repassword.TabIndex = 7;
            this.txt_Repassword.TextChanged += new System.EventHandler(this.txt_Repassword_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(169, 197);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(183, 22);
            this.txt_password.TabIndex = 6;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_password.Location = new System.Drawing.Point(92, 200);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(60, 15);
            this.lab_password.TabIndex = 27;
            this.lab_password.Text = "Password";
            // 
            // lab_phone
            // 
            this.lab_phone.AutoSize = true;
            this.lab_phone.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_phone.Location = new System.Drawing.Point(366, 158);
            this.lab_phone.Name = "lab_phone";
            this.lab_phone.Size = new System.Drawing.Size(42, 15);
            this.lab_phone.TabIndex = 25;
            this.lab_phone.Text = "Phone";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(169, 155);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(183, 22);
            this.txt_email.TabIndex = 3;
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_email.Location = new System.Drawing.Point(92, 156);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(41, 15);
            this.lab_email.TabIndex = 22;
            this.lab_email.Text = "Email";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_add.Location = new System.Drawing.Point(509, 304);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(168, 54);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "CreateAccount";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_Lname
            // 
            this.txt_Lname.Location = new System.Drawing.Point(494, 110);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(183, 22);
            this.txt_Lname.TabIndex = 2;
            this.txt_Lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Lname_KeyPress);
            // 
            // lab_Lname
            // 
            this.lab_Lname.AutoSize = true;
            this.lab_Lname.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Lname.Location = new System.Drawing.Point(366, 113);
            this.lab_Lname.Name = "lab_Lname";
            this.lab_Lname.Size = new System.Drawing.Size(68, 15);
            this.lab_Lname.TabIndex = 18;
            this.lab_Lname.Text = "Last Name";
            // 
            // txt_Fname
            // 
            this.txt_Fname.Location = new System.Drawing.Point(169, 110);
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(183, 22);
            this.txt_Fname.TabIndex = 1;
            this.txt_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Fname_KeyPress);
            // 
            // lab_Fname
            // 
            this.lab_Fname.AutoSize = true;
            this.lab_Fname.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Fname.Location = new System.Drawing.Point(92, 113);
            this.lab_Fname.Name = "lab_Fname";
            this.lab_Fname.Size = new System.Drawing.Size(70, 15);
            this.lab_Fname.TabIndex = 17;
            this.lab_Fname.Text = "First Name";
            // 
            // lab_centreID
            // 
            this.lab_centreID.AutoSize = true;
            this.lab_centreID.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_centreID.Location = new System.Drawing.Point(366, 248);
            this.lab_centreID.Name = "lab_centreID";
            this.lab_centreID.Size = new System.Drawing.Size(59, 15);
            this.lab_centreID.TabIndex = 37;
            this.lab_centreID.Text = "CentreID";
            // 
            // lab_jobID
            // 
            this.lab_jobID.AutoSize = true;
            this.lab_jobID.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_jobID.Location = new System.Drawing.Point(92, 248);
            this.lab_jobID.Name = "lab_jobID";
            this.lab_jobID.Size = new System.Drawing.Size(41, 15);
            this.lab_jobID.TabIndex = 38;
            this.lab_jobID.Text = "JobID";
            // 
            // combo_job
            // 
            this.combo_job.FormattingEnabled = true;
            this.combo_job.ItemHeight = 12;
            this.combo_job.Location = new System.Drawing.Point(169, 245);
            this.combo_job.Name = "combo_job";
            this.combo_job.Size = new System.Drawing.Size(50, 20);
            this.combo_job.TabIndex = 39;
            this.combo_job.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_job_KeyPress);
            // 
            // combo_centre
            // 
            this.combo_centre.FormattingEnabled = true;
            this.combo_centre.ItemHeight = 12;
            this.combo_centre.Location = new System.Drawing.Point(494, 245);
            this.combo_centre.Name = "combo_centre";
            this.combo_centre.Size = new System.Drawing.Size(50, 20);
            this.combo_centre.TabIndex = 40;
            this.combo_centre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_centre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Create Staff Account";
            // 
            // CreateStaffAcccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_centre);
            this.Controls.Add(this.combo_job);
            this.Controls.Add(this.lab_jobID);
            this.Controls.Add(this.lab_centreID);
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
            this.Name = "CreateStaffAcccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp - Create Staff Account";
            this.Load += new System.EventHandler(this.CreateStaffAcccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.CheckBox check_robot;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lab_emailmessage;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lab_Repassword;
        private System.Windows.Forms.TextBox txt_Repassword;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.Label lab_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.Label lab_Lname;
        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.Label lab_Fname;
        private System.Windows.Forms.Label lab_centreID;
        private System.Windows.Forms.Label lab_jobID;
        private System.Windows.Forms.ComboBox combo_job;
        private System.Windows.Forms.ComboBox combo_centre;
        private System.Windows.Forms.Label label1;
    }
}