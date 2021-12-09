
namespace EDEapp { 
partial class EDEapp_MainMenu

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
            this.tLayout_main = new System.Windows.Forms.TableLayoutPanel();
            this.lab_welcome = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_viewAccount = new System.Windows.Forms.Button();
            this.lbl_alertMessage = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_btn6 = new System.Windows.Forms.Button();
            this.btn_btn5 = new System.Windows.Forms.Button();
            this.btn_btn1 = new System.Windows.Forms.Button();
            this.btn_btn2 = new System.Windows.Forms.Button();
            this.btn_btn3 = new System.Windows.Forms.Button();
            this.btn_btn4 = new System.Windows.Forms.Button();
            this.btn_btn7 = new System.Windows.Forms.Button();
            this.btn_btn8 = new System.Windows.Forms.Button();
            this.tLayout_main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLayout_main
            // 
            this.tLayout_main.ColumnCount = 4;
            this.tLayout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLayout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tLayout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tLayout_main.Controls.Add(this.lab_welcome, 0, 0);
            this.tLayout_main.Controls.Add(this.btn_logout, 3, 0);
            this.tLayout_main.Controls.Add(this.btn_viewAccount, 2, 0);
            this.tLayout_main.Controls.Add(this.lbl_alertMessage, 1, 0);
            this.tLayout_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.tLayout_main.Location = new System.Drawing.Point(0, 0);
            this.tLayout_main.Name = "tLayout_main";
            this.tLayout_main.RowCount = 1;
            this.tLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayout_main.Size = new System.Drawing.Size(800, 39);
            this.tLayout_main.TabIndex = 1;
            // 
            // lab_welcome
            // 
            this.lab_welcome.AutoSize = true;
            this.lab_welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_welcome.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.lab_welcome.Location = new System.Drawing.Point(3, 0);
            this.lab_welcome.Name = "lab_welcome";
            this.lab_welcome.Size = new System.Drawing.Size(126, 39);
            this.lab_welcome.TabIndex = 0;
            this.lab_welcome.Text = "Welcome! Mr. xxx";
            this.lab_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_logout.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_logout.Location = new System.Drawing.Point(703, 3);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(94, 33);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_viewAccount
            // 
            this.btn_viewAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_viewAccount.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_viewAccount.Location = new System.Drawing.Point(603, 3);
            this.btn_viewAccount.Name = "btn_viewAccount";
            this.btn_viewAccount.Size = new System.Drawing.Size(94, 33);
            this.btn_viewAccount.TabIndex = 2;
            this.btn_viewAccount.Text = "My Account";
            this.btn_viewAccount.UseVisualStyleBackColor = true;
            this.btn_viewAccount.Click += new System.EventHandler(this.btn_viewAccount_Click);
            // 
            // lbl_alertMessage
            // 
            this.lbl_alertMessage.AutoSize = true;
            this.lbl_alertMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_alertMessage.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.lbl_alertMessage.Location = new System.Drawing.Point(135, 0);
            this.lbl_alertMessage.Name = "lbl_alertMessage";
            this.lbl_alertMessage.Size = new System.Drawing.Size(462, 39);
            this.lbl_alertMessage.TabIndex = 3;
            this.lbl_alertMessage.TabStop = true;
            this.lbl_alertMessage.Text = "You have 3 unread notifications!";
            this.lbl_alertMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_alertMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_alertMessage_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_btn6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_btn5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_btn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_btn2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_btn3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_btn4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_btn7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_btn8, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 411);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_btn6
            // 
            this.btn_btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_btn6.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_btn6.Location = new System.Drawing.Point(203, 208);
            this.btn_btn6.Name = "btn_btn6";
            this.btn_btn6.Size = new System.Drawing.Size(194, 200);
            this.btn_btn6.TabIndex = 7;
            this.btn_btn6.Text = "Button6";
            this.btn_btn6.UseVisualStyleBackColor = true;
            this.btn_btn6.Click += new System.EventHandler(this.btn_btn6_Click);
            // 
            // btn_btn5
            // 
            this.btn_btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_btn5.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_btn5.Location = new System.Drawing.Point(3, 208);
            this.btn_btn5.Name = "btn_btn5";
            this.btn_btn5.Size = new System.Drawing.Size(194, 200);
            this.btn_btn5.TabIndex = 6;
            this.btn_btn5.Text = "Button5";
            this.btn_btn5.UseVisualStyleBackColor = true;
            this.btn_btn5.Click += new System.EventHandler(this.btn_btn5_Click);
            // 
            // btn_btn1
            // 
            this.btn_btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_btn1.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_btn1.Location = new System.Drawing.Point(3, 3);
            this.btn_btn1.Name = "btn_btn1";
            this.btn_btn1.Size = new System.Drawing.Size(194, 199);
            this.btn_btn1.TabIndex = 0;
            this.btn_btn1.Text = "Button1";
            this.btn_btn1.UseVisualStyleBackColor = true;
            this.btn_btn1.Click += new System.EventHandler(this.btn_btn1_Click);
            // 
            // btn_btn2
            // 
            this.btn_btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_btn2.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_btn2.Location = new System.Drawing.Point(203, 3);
            this.btn_btn2.Name = "btn_btn2";
            this.btn_btn2.Size = new System.Drawing.Size(194, 199);
            this.btn_btn2.TabIndex = 2;
            this.btn_btn2.Text = "Button2";
            this.btn_btn2.UseVisualStyleBackColor = true;
            this.btn_btn2.Click += new System.EventHandler(this.btn_btn2_Click);
            // 
            // btn_btn3
            // 
            this.btn_btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_btn3.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_btn3.Location = new System.Drawing.Point(403, 3);
            this.btn_btn3.Name = "btn_btn3";
            this.btn_btn3.Size = new System.Drawing.Size(194, 199);
            this.btn_btn3.TabIndex = 3;
            this.btn_btn3.Text = "Button3";
            this.btn_btn3.UseVisualStyleBackColor = true;
            this.btn_btn3.Click += new System.EventHandler(this.btn_btn3_Click);
            // 
            // btn_btn4
            // 
            this.btn_btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_btn4.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_btn4.Location = new System.Drawing.Point(603, 3);
            this.btn_btn4.Name = "btn_btn4";
            this.btn_btn4.Size = new System.Drawing.Size(194, 199);
            this.btn_btn4.TabIndex = 1;
            this.btn_btn4.Text = "Button4";
            this.btn_btn4.UseVisualStyleBackColor = true;
            this.btn_btn4.Click += new System.EventHandler(this.btn_btn4_Click);
            // 
            // btn_btn7
            // 
            this.btn_btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_btn7.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_btn7.Location = new System.Drawing.Point(403, 208);
            this.btn_btn7.Name = "btn_btn7";
            this.btn_btn7.Size = new System.Drawing.Size(194, 200);
            this.btn_btn7.TabIndex = 4;
            this.btn_btn7.Text = "Button7";
            this.btn_btn7.UseVisualStyleBackColor = true;
            this.btn_btn7.Click += new System.EventHandler(this.btn_btn7_Click);
            // 
            // btn_btn8
            // 
            this.btn_btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_btn8.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btn_btn8.Location = new System.Drawing.Point(603, 208);
            this.btn_btn8.Name = "btn_btn8";
            this.btn_btn8.Size = new System.Drawing.Size(194, 200);
            this.btn_btn8.TabIndex = 5;
            this.btn_btn8.Text = "Button8";
            this.btn_btn8.UseVisualStyleBackColor = true;
            this.btn_btn8.Click += new System.EventHandler(this.btn_btn8_Click);
            // 
            // EDEapp_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tLayout_main);
            this.Name = "EDEapp_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDEapp_MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EDEapp_MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.EDEapp_MainMenu_Load);
            this.tLayout_main.ResumeLayout(false);
            this.tLayout_main.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tLayout_main;
    private System.Windows.Forms.Label lab_welcome;
    private System.Windows.Forms.Button btn_logout;
    private System.Windows.Forms.Button btn_viewAccount;
    private System.Windows.Forms.LinkLabel lbl_alertMessage;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btn_btn1;
    private System.Windows.Forms.Button btn_btn4;
    private System.Windows.Forms.Button btn_btn2;
    private System.Windows.Forms.Button btn_btn3;
    private System.Windows.Forms.Button btn_btn7;
    private System.Windows.Forms.Button btn_btn8;
    private System.Windows.Forms.Button btn_btn6;
    private System.Windows.Forms.Button btn_btn5;
}
}