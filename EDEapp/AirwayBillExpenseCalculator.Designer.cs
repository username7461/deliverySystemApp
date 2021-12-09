
namespace EDEapp
{
    partial class AirwayBillExpenseCalculator
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
            this.lab_sec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_length = new System.Windows.Forms.Label();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.lab_width = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.lab_height = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_type = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lab_destinatedcountry = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_sec
            // 
            this.lab_sec.AutoSize = true;
            this.lab_sec.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.lab_sec.Location = new System.Drawing.Point(37, 36);
            this.lab_sec.Name = "lab_sec";
            this.lab_sec.Size = new System.Drawing.Size(189, 16);
            this.lab_sec.TabIndex = 0;
            this.lab_sec.Text = "Shipping Expense Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.label1.Location = new System.Drawing.Point(38, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter all the details of your package to the system.The system will calculate the" +
    " cost for you";
            // 
            // lab_length
            // 
            this.lab_length.AutoSize = true;
            this.lab_length.Location = new System.Drawing.Point(40, 146);
            this.lab_length.Name = "lab_length";
            this.lab_length.Size = new System.Drawing.Size(38, 12);
            this.lab_length.TabIndex = 2;
            this.lab_length.Text = "Length";
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(84, 143);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(86, 22);
            this.txt_length.TabIndex = 3;
            this.txt_length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_length_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "cm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "cm";
            // 
            // txt_width
            // 
            this.txt_width.Location = new System.Drawing.Point(251, 143);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(86, 22);
            this.txt_width.TabIndex = 6;
            this.txt_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_width_KeyPress);
            // 
            // lab_width
            // 
            this.lab_width.AutoSize = true;
            this.lab_width.Location = new System.Drawing.Point(207, 146);
            this.lab_width.Name = "lab_width";
            this.lab_width.Size = new System.Drawing.Size(34, 12);
            this.lab_width.TabIndex = 5;
            this.lab_width.Text = "Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "cm";
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(417, 143);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(86, 22);
            this.txt_height.TabIndex = 9;
            this.txt_height.TextChanged += new System.EventHandler(this.txt_height_TextChanged);
            this.txt_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_height_KeyPress);
            // 
            // lab_height
            // 
            this.lab_height.AutoSize = true;
            this.lab_height.Location = new System.Drawing.Point(373, 146);
            this.lab_height.Name = "lab_height";
            this.lab_height.Size = new System.Drawing.Size(36, 12);
            this.lab_height.TabIndex = 8;
            this.lab_height.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(677, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "kg";
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(585, 143);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(86, 22);
            this.txt_weight.TabIndex = 12;
            this.txt_weight.TextChanged += new System.EventHandler(this.txt_weight_TextChanged);
            this.txt_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_weight_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "Weight";
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Location = new System.Drawing.Point(122, 200);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(73, 12);
            this.lab_type.TabIndex = 14;
            this.lab_type.Text = "Type of goods";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Envelope/Freight";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(483, 197);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "Country";
            this.comboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox2_KeyDown);
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // lab_destinatedcountry
            // 
            this.lab_destinatedcountry.AutoSize = true;
            this.lab_destinatedcountry.Location = new System.Drawing.Point(382, 200);
            this.lab_destinatedcountry.Name = "lab_destinatedcountry";
            this.lab_destinatedcountry.Size = new System.Drawing.Size(95, 12);
            this.lab_destinatedcountry.TabIndex = 16;
            this.lab_destinatedcountry.Text = "Destinated Country";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(327, 314);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(101, 23);
            this.btn_calculate.TabIndex = 18;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // AirwayBillExpenseCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lab_destinatedcountry);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lab_type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.lab_height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_width);
            this.Controls.Add(this.lab_width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_length);
            this.Controls.Add(this.lab_length);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_sec);
            this.Name = "AirwayBillExpenseCalculator";
            this.Text = "ShippingExpenseCalculator";
            this.Load += new System.EventHandler(this.ShippingExpenseCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_length;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.Label lab_width;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Label lab_height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lab_destinatedcountry;
        private System.Windows.Forms.Button btn_calculate;
    }
}