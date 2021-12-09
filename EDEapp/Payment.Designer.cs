
namespace EDEapp
{
    partial class Payment
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
            this.btn_return = new System.Windows.Forms.Button();
            this.lab_payment = new System.Windows.Forms.Label();
            this.lab_word = new System.Windows.Forms.Label();
            this.lab_invoiceID = new System.Windows.Forms.Label();
            this.lab_paymentmethod = new System.Windows.Forms.Label();
            this.combo_paymentMethod = new System.Windows.Forms.ComboBox();
            this.combo_invoiceID = new System.Windows.Forms.ComboBox();
            this.group_creditCard = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.txt_holderName = new System.Windows.Forms.TextBox();
            this.lab_holderName = new System.Windows.Forms.Label();
            this.txt_expiryDate = new System.Windows.Forms.TextBox();
            this.lab_expiryDate = new System.Windows.Forms.Label();
            this.txt_cvv = new System.Windows.Forms.TextBox();
            this.lab_cvv = new System.Windows.Forms.Label();
            this.txt_cardNo = new System.Windows.Forms.TextBox();
            this.lab_cardNo = new System.Windows.Forms.Label();
            this.lab_cardType = new System.Windows.Forms.Label();
            this.combo_cardtype = new System.Windows.Forms.ComboBox();
            this.lab_credcardinfor = new System.Windows.Forms.Label();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.lab_value = new System.Windows.Forms.Label();
            this.group_Cash = new System.Windows.Forms.GroupBox();
            this.btn_lwlgooglemap = new System.Windows.Forms.Button();
            this.btn_stgooglemap = new System.Windows.Forms.Button();
            this.lab_address3 = new System.Windows.Forms.Label();
            this.lab_shatin = new System.Windows.Forms.Label();
            this.lab_address2 = new System.Windows.Forms.Label();
            this.lab_address1 = new System.Windows.Forms.Label();
            this.group_cheque = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.group_creditCard.SuspendLayout();
            this.group_Cash.SuspendLayout();
            this.group_cheque.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(688, 17);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(90, 41);
            this.btn_return.TabIndex = 0;
            this.btn_return.Text = "<<Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // lab_payment
            // 
            this.lab_payment.AutoSize = true;
            this.lab_payment.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_payment.Location = new System.Drawing.Point(21, 24);
            this.lab_payment.Name = "lab_payment";
            this.lab_payment.Size = new System.Drawing.Size(86, 21);
            this.lab_payment.TabIndex = 1;
            this.lab_payment.Text = "Payment";
            // 
            // lab_word
            // 
            this.lab_word.AutoSize = true;
            this.lab_word.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.lab_word.Location = new System.Drawing.Point(12, 88);
            this.lab_word.Name = "lab_word";
            this.lab_word.Size = new System.Drawing.Size(343, 20);
            this.lab_word.TabIndex = 2;
            this.lab_word.Text = "Select the Payment Method to make payment";
            // 
            // lab_invoiceID
            // 
            this.lab_invoiceID.AutoSize = true;
            this.lab_invoiceID.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_invoiceID.Location = new System.Drawing.Point(21, 132);
            this.lab_invoiceID.Name = "lab_invoiceID";
            this.lab_invoiceID.Size = new System.Drawing.Size(155, 16);
            this.lab_invoiceID.TabIndex = 3;
            this.lab_invoiceID.Text = "Monthly Invoice ID:";
            // 
            // lab_paymentmethod
            // 
            this.lab_paymentmethod.AutoSize = true;
            this.lab_paymentmethod.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_paymentmethod.Location = new System.Drawing.Point(43, 300);
            this.lab_paymentmethod.Name = "lab_paymentmethod";
            this.lab_paymentmethod.Size = new System.Drawing.Size(133, 16);
            this.lab_paymentmethod.TabIndex = 4;
            this.lab_paymentmethod.Text = "Payment Method:";
            // 
            // combo_paymentMethod
            // 
            this.combo_paymentMethod.FormattingEnabled = true;
            this.combo_paymentMethod.Location = new System.Drawing.Point(182, 300);
            this.combo_paymentMethod.Name = "combo_paymentMethod";
            this.combo_paymentMethod.Size = new System.Drawing.Size(158, 20);
            this.combo_paymentMethod.TabIndex = 6;
            this.combo_paymentMethod.SelectedIndexChanged += new System.EventHandler(this.combo_paymentMethod_SelectedIndexChanged);
            this.combo_paymentMethod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // combo_invoiceID
            // 
            this.combo_invoiceID.FormattingEnabled = true;
            this.combo_invoiceID.Location = new System.Drawing.Point(183, 132);
            this.combo_invoiceID.Name = "combo_invoiceID";
            this.combo_invoiceID.Size = new System.Drawing.Size(157, 20);
            this.combo_invoiceID.TabIndex = 7;
            this.combo_invoiceID.SelectedIndexChanged += new System.EventHandler(this.combo_invoiceID_SelectedIndexChanged);
            this.combo_invoiceID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_invoiceID_KeyPress);
            // 
            // group_creditCard
            // 
            this.group_creditCard.Controls.Add(this.btn_cancel);
            this.group_creditCard.Controls.Add(this.btn_pay);
            this.group_creditCard.Controls.Add(this.txt_holderName);
            this.group_creditCard.Controls.Add(this.lab_holderName);
            this.group_creditCard.Controls.Add(this.txt_expiryDate);
            this.group_creditCard.Controls.Add(this.lab_expiryDate);
            this.group_creditCard.Controls.Add(this.txt_cvv);
            this.group_creditCard.Controls.Add(this.lab_cvv);
            this.group_creditCard.Controls.Add(this.txt_cardNo);
            this.group_creditCard.Controls.Add(this.lab_cardNo);
            this.group_creditCard.Controls.Add(this.lab_cardType);
            this.group_creditCard.Controls.Add(this.combo_cardtype);
            this.group_creditCard.Controls.Add(this.lab_credcardinfor);
            this.group_creditCard.Location = new System.Drawing.Point(361, 82);
            this.group_creditCard.Name = "group_creditCard";
            this.group_creditCard.Size = new System.Drawing.Size(416, 336);
            this.group_creditCard.TabIndex = 8;
            this.group_creditCard.TabStop = false;
            this.group_creditCard.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(264, 289);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(79, 41);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(112, 289);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(79, 41);
            this.btn_pay.TabIndex = 11;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // txt_holderName
            // 
            this.txt_holderName.Location = new System.Drawing.Point(284, 225);
            this.txt_holderName.Name = "txt_holderName";
            this.txt_holderName.Size = new System.Drawing.Size(110, 22);
            this.txt_holderName.TabIndex = 10;
            this.txt_holderName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_holderName_KeyPress);
            // 
            // lab_holderName
            // 
            this.lab_holderName.AutoSize = true;
            this.lab_holderName.Location = new System.Drawing.Point(208, 228);
            this.lab_holderName.Name = "lab_holderName";
            this.lab_holderName.Size = new System.Drawing.Size(70, 12);
            this.lab_holderName.TabIndex = 9;
            this.lab_holderName.Text = "Holder Name:";
            // 
            // txt_expiryDate
            // 
            this.txt_expiryDate.Location = new System.Drawing.Point(82, 225);
            this.txt_expiryDate.Name = "txt_expiryDate";
            this.txt_expiryDate.Size = new System.Drawing.Size(110, 22);
            this.txt_expiryDate.TabIndex = 8;
            this.txt_expiryDate.TextChanged += new System.EventHandler(this.txt_expiryDate_TextChanged);
            this.txt_expiryDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_expiryDate_KeyPress);
            // 
            // lab_expiryDate
            // 
            this.lab_expiryDate.AutoSize = true;
            this.lab_expiryDate.Location = new System.Drawing.Point(12, 228);
            this.lab_expiryDate.Name = "lab_expiryDate";
            this.lab_expiryDate.Size = new System.Drawing.Size(64, 12);
            this.lab_expiryDate.TabIndex = 7;
            this.lab_expiryDate.Text = "Expiry Date:";
            // 
            // txt_cvv
            // 
            this.txt_cvv.Location = new System.Drawing.Point(284, 131);
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.Size = new System.Drawing.Size(110, 22);
            this.txt_cvv.TabIndex = 6;
            this.txt_cvv.TextChanged += new System.EventHandler(this.txt_cvv_TextChanged);
            this.txt_cvv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cvv_KeyPress);
            // 
            // lab_cvv
            // 
            this.lab_cvv.AutoSize = true;
            this.lab_cvv.Location = new System.Drawing.Point(208, 137);
            this.lab_cvv.Name = "lab_cvv";
            this.lab_cvv.Size = new System.Drawing.Size(32, 12);
            this.lab_cvv.TabIndex = 5;
            this.lab_cvv.Text = "CVV:";
            // 
            // txt_cardNo
            // 
            this.txt_cardNo.Location = new System.Drawing.Point(82, 131);
            this.txt_cardNo.Name = "txt_cardNo";
            this.txt_cardNo.Size = new System.Drawing.Size(110, 22);
            this.txt_cardNo.TabIndex = 4;
            this.txt_cardNo.TextChanged += new System.EventHandler(this.txt_cardNo_TextChanged);
            this.txt_cardNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cardNo_KeyPress);
            // 
            // lab_cardNo
            // 
            this.lab_cardNo.AutoSize = true;
            this.lab_cardNo.Location = new System.Drawing.Point(12, 134);
            this.lab_cardNo.Name = "lab_cardNo";
            this.lab_cardNo.Size = new System.Drawing.Size(48, 12);
            this.lab_cardNo.TabIndex = 3;
            this.lab_cardNo.Text = "Card No:";
            // 
            // lab_cardType
            // 
            this.lab_cardType.AutoSize = true;
            this.lab_cardType.Location = new System.Drawing.Point(104, 58);
            this.lab_cardType.Name = "lab_cardType";
            this.lab_cardType.Size = new System.Drawing.Size(55, 12);
            this.lab_cardType.TabIndex = 2;
            this.lab_cardType.Text = "Card Type";
            // 
            // combo_cardtype
            // 
            this.combo_cardtype.FormattingEnabled = true;
            this.combo_cardtype.Location = new System.Drawing.Point(177, 54);
            this.combo_cardtype.Name = "combo_cardtype";
            this.combo_cardtype.Size = new System.Drawing.Size(121, 20);
            this.combo_cardtype.TabIndex = 1;
            this.combo_cardtype.SelectedIndexChanged += new System.EventHandler(this.combo_cardtype_SelectedIndexChanged);
            this.combo_cardtype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_cardtype_KeyPress);
            // 
            // lab_credcardinfor
            // 
            this.lab_credcardinfor.AutoSize = true;
            this.lab_credcardinfor.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_credcardinfor.Location = new System.Drawing.Point(117, 18);
            this.lab_credcardinfor.Name = "lab_credcardinfor";
            this.lab_credcardinfor.Size = new System.Drawing.Size(181, 16);
            this.lab_credcardinfor.TabIndex = 0;
            this.lab_credcardinfor.Text = "Credit Card Information";
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(258, 202);
            this.txt_value.Name = "txt_value";
            this.txt_value.ReadOnly = true;
            this.txt_value.Size = new System.Drawing.Size(82, 22);
            this.txt_value.TabIndex = 12;
            // 
            // lab_value
            // 
            this.lab_value.AutoSize = true;
            this.lab_value.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_value.Location = new System.Drawing.Point(197, 202);
            this.lab_value.Name = "lab_value";
            this.lab_value.Size = new System.Drawing.Size(55, 16);
            this.lab_value.TabIndex = 13;
            this.lab_value.Text = "Value:";
            // 
            // group_Cash
            // 
            this.group_Cash.Controls.Add(this.btn_lwlgooglemap);
            this.group_Cash.Controls.Add(this.btn_stgooglemap);
            this.group_Cash.Controls.Add(this.lab_address3);
            this.group_Cash.Controls.Add(this.lab_shatin);
            this.group_Cash.Controls.Add(this.lab_address2);
            this.group_Cash.Controls.Add(this.lab_address1);
            this.group_Cash.Location = new System.Drawing.Point(361, 82);
            this.group_Cash.Name = "group_Cash";
            this.group_Cash.Size = new System.Drawing.Size(432, 330);
            this.group_Cash.TabIndex = 14;
            this.group_Cash.TabStop = false;
            this.group_Cash.Text = "You Can Do the Payment In";
            // 
            // btn_lwlgooglemap
            // 
            this.btn_lwlgooglemap.Location = new System.Drawing.Point(9, 243);
            this.btn_lwlgooglemap.Name = "btn_lwlgooglemap";
            this.btn_lwlgooglemap.Size = new System.Drawing.Size(83, 37);
            this.btn_lwlgooglemap.TabIndex = 31;
            this.btn_lwlgooglemap.Text = "Google Map Location";
            this.btn_lwlgooglemap.UseVisualStyleBackColor = true;
            this.btn_lwlgooglemap.Click += new System.EventHandler(this.btn_lwlgooglemap_Click);
            // 
            // btn_stgooglemap
            // 
            this.btn_stgooglemap.Location = new System.Drawing.Point(6, 94);
            this.btn_stgooglemap.Name = "btn_stgooglemap";
            this.btn_stgooglemap.Size = new System.Drawing.Size(83, 37);
            this.btn_stgooglemap.TabIndex = 30;
            this.btn_stgooglemap.Text = "Google Map Location";
            this.btn_stgooglemap.UseVisualStyleBackColor = true;
            this.btn_stgooglemap.Click += new System.EventHandler(this.btn_stgooglemap_Click);
            // 
            // lab_address3
            // 
            this.lab_address3.AutoSize = true;
            this.lab_address3.Location = new System.Drawing.Point(6, 193);
            this.lab_address3.Name = "lab_address3";
            this.lab_address3.Size = new System.Drawing.Size(80, 12);
            this.lab_address3.TabIndex = 29;
            this.lab_address3.Text = "Tseung Kwan O";
            // 
            // lab_shatin
            // 
            this.lab_shatin.AutoSize = true;
            this.lab_shatin.Location = new System.Drawing.Point(6, 54);
            this.lab_shatin.Name = "lab_shatin";
            this.lab_shatin.Size = new System.Drawing.Size(75, 12);
            this.lab_shatin.TabIndex = 28;
            this.lab_shatin.Text = "Sha Tin Centre";
            // 
            // lab_address2
            // 
            this.lab_address2.AutoSize = true;
            this.lab_address2.Location = new System.Drawing.Point(6, 216);
            this.lab_address2.Name = "lab_address2";
            this.lab_address2.Size = new System.Drawing.Size(353, 12);
            this.lab_address2.TabIndex = 27;
            this.lab_address2.Text = "Address: 3 King Ling Road Tseung Kwan O, New Territories , Hong Kong";
            // 
            // lab_address1
            // 
            this.lab_address1.AutoSize = true;
            this.lab_address1.Location = new System.Drawing.Point(6, 76);
            this.lab_address1.Name = "lab_address1";
            this.lab_address1.Size = new System.Drawing.Size(320, 12);
            this.lab_address1.TabIndex = 24;
            this.lab_address1.Text = "Address:  21 Yuen Wo Road Sha Tin, New Territories , Hong Kong";
            // 
            // group_cheque
            // 
            this.group_cheque.Controls.Add(this.label3);
            this.group_cheque.Controls.Add(this.label2);
            this.group_cheque.Controls.Add(this.label1);
            this.group_cheque.Location = new System.Drawing.Point(361, 82);
            this.group_cheque.Name = "group_cheque";
            this.group_cheque.Size = new System.Drawing.Size(432, 330);
            this.group_cheque.TabIndex = 15;
            this.group_cheque.TabStop = false;
            this.group_cheque.Text = "Cheque Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pay: Eastern Delivery Express Limited";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(21, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail to: Sha Tin Centre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Address:  21 Yuen Wo Road Sha Tin, New Territories , Hong Kong";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.group_cheque);
            this.Controls.Add(this.group_Cash);
            this.Controls.Add(this.lab_value);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.group_creditCard);
            this.Controls.Add(this.combo_invoiceID);
            this.Controls.Add(this.combo_paymentMethod);
            this.Controls.Add(this.lab_paymentmethod);
            this.Controls.Add(this.lab_invoiceID);
            this.Controls.Add(this.lab_word);
            this.Controls.Add(this.lab_payment);
            this.Controls.Add(this.btn_return);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.group_creditCard.ResumeLayout(false);
            this.group_creditCard.PerformLayout();
            this.group_Cash.ResumeLayout(false);
            this.group_Cash.PerformLayout();
            this.group_cheque.ResumeLayout(false);
            this.group_cheque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label lab_payment;
        private System.Windows.Forms.Label lab_word;
        private System.Windows.Forms.Label lab_invoiceID;
        private System.Windows.Forms.Label lab_paymentmethod;
        private System.Windows.Forms.ComboBox combo_paymentMethod;
        private System.Windows.Forms.ComboBox combo_invoiceID;
        private System.Windows.Forms.GroupBox group_creditCard;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Label lab_holderName;
        private System.Windows.Forms.Label lab_expiryDate;
        private System.Windows.Forms.TextBox txt_cvv;
        private System.Windows.Forms.Label lab_cvv;
        private System.Windows.Forms.Label lab_cardNo;
        private System.Windows.Forms.Label lab_cardType;
        private System.Windows.Forms.ComboBox combo_cardtype;
        private System.Windows.Forms.Label lab_credcardinfor;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label lab_value;
        private System.Windows.Forms.GroupBox group_Cash;
        private System.Windows.Forms.Label lab_address1;
        private System.Windows.Forms.Label lab_address2;
        private System.Windows.Forms.Label lab_address3;
        private System.Windows.Forms.Label lab_shatin;
        private System.Windows.Forms.Button btn_stgooglemap;
        private System.Windows.Forms.Button btn_lwlgooglemap;
        public System.Windows.Forms.TextBox txt_holderName;
        public System.Windows.Forms.TextBox txt_expiryDate;
        public System.Windows.Forms.TextBox txt_cardNo;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox group_cheque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}