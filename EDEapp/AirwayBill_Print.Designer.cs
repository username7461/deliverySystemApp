
namespace EDEapp
{
    partial class AirwayBill_Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirwayBill_Print));
            this.printAirwayBill = new System.Drawing.Printing.PrintDocument();
            this.lbl_accountID = new System.Windows.Forms.Label();
            this.lbl_senderName = new System.Windows.Forms.Label();
            this.lbl_senderReference = new System.Windows.Forms.Label();
            this.lbl_senderCompanyName = new System.Windows.Forms.Label();
            this.lbl_senderAddress = new System.Windows.Forms.Label();
            this.lbl_senderPostcode = new System.Windows.Forms.Label();
            this.lbl_receiverCompanyName = new System.Windows.Forms.Label();
            this.lbl_receiverAddress = new System.Windows.Forms.Label();
            this.lbl_receiverPostcode = new System.Windows.Forms.Label();
            this.lbl_receiverCountry = new System.Windows.Forms.Label();
            this.lbl_senderPhoneNo = new System.Windows.Forms.Label();
            this.lbl_receiverPhoneNo = new System.Windows.Forms.Label();
            this.lbl_receiverContectName = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_pkgDesc = new System.Windows.Forms.Label();
            this.lbl_pkgValue = new System.Windows.Forms.Label();
            this.ckb_serviceDocument = new System.Windows.Forms.CheckBox();
            this.ckb_servicePackageExpress = new System.Windows.Forms.CheckBox();
            this.ckb_serviceExpressDocument = new System.Windows.Forms.CheckBox();
            this.ckb_serviceDomestic = new System.Windows.Forms.CheckBox();
            this.ckb_serviceWorldmail = new System.Windows.Forms.CheckBox();
            this.ckb_transportSender = new System.Windows.Forms.CheckBox();
            this.ckb_transportCashChequeCreditCard = new System.Windows.Forms.CheckBox();
            this.ckb_transportExternalBillingAgreement = new System.Windows.Forms.CheckBox();
            this.ckb_transportCollect = new System.Windows.Forms.CheckBox();
            this.ckb_shipmentInsurance = new System.Windows.Forms.CheckBox();
            this.ckb_exportPermanent = new System.Windows.Forms.CheckBox();
            this.ckb_exportRepair = new System.Windows.Forms.CheckBox();
            this.ckb_exportTemporary = new System.Windows.Forms.CheckBox();
            this.ckb_taxesReceiver = new System.Windows.Forms.CheckBox();
            this.ckb_taxesSender = new System.Windows.Forms.CheckBox();
            this.ckb_taxesOther = new System.Windows.Forms.CheckBox();
            this.lbl_pkgQty = new System.Windows.Forms.Label();
            this.lbl_pkgWeight = new System.Windows.Forms.Label();
            this.lbl_pkgDimensions = new System.Windows.Forms.Label();
            this.lbl_senderDeletePhone = new System.Windows.Forms.Label();
            this.lbl_senderDeleteFax = new System.Windows.Forms.Label();
            this.lbl_senderDeleteTelex = new System.Windows.Forms.Label();
            this.lbl_receiverDeleteTelex = new System.Windows.Forms.Label();
            this.lbl_receiverDeleteFax = new System.Windows.Forms.Label();
            this.lbl_receiverDeletePhone = new System.Windows.Forms.Label();
            this.lbl_serviceDeleteAirmail = new System.Windows.Forms.Label();
            this.lbl_serviceDeletePrintedMaster = new System.Windows.Forms.Label();
            this.lbl_shipmentNo = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printAirwayBill
            // 
            this.printAirwayBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printAirwayBill_PrintPage);
            // 
            // lbl_accountID
            // 
            this.lbl_accountID.AutoSize = true;
            this.lbl_accountID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_accountID.Location = new System.Drawing.Point(9, 102);
            this.lbl_accountID.Name = "lbl_accountID";
            this.lbl_accountID.Size = new System.Drawing.Size(94, 20);
            this.lbl_accountID.TabIndex = 1;
            this.lbl_accountID.Text = "lbl_accountID";
            // 
            // lbl_senderName
            // 
            this.lbl_senderName.AutoSize = true;
            this.lbl_senderName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_senderName.Location = new System.Drawing.Point(253, 102);
            this.lbl_senderName.Name = "lbl_senderName";
            this.lbl_senderName.Size = new System.Drawing.Size(109, 20);
            this.lbl_senderName.TabIndex = 2;
            this.lbl_senderName.Text = "lbl_senderName";
            // 
            // lbl_senderReference
            // 
            this.lbl_senderReference.AutoSize = true;
            this.lbl_senderReference.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_senderReference.Location = new System.Drawing.Point(9, 152);
            this.lbl_senderReference.Name = "lbl_senderReference";
            this.lbl_senderReference.Size = new System.Drawing.Size(135, 20);
            this.lbl_senderReference.TabIndex = 3;
            this.lbl_senderReference.Text = "lbl_senderReference";
            // 
            // lbl_senderCompanyName
            // 
            this.lbl_senderCompanyName.AutoSize = true;
            this.lbl_senderCompanyName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_senderCompanyName.Location = new System.Drawing.Point(9, 200);
            this.lbl_senderCompanyName.Name = "lbl_senderCompanyName";
            this.lbl_senderCompanyName.Size = new System.Drawing.Size(168, 20);
            this.lbl_senderCompanyName.TabIndex = 4;
            this.lbl_senderCompanyName.Text = "lbl_senderCompanyName";
            // 
            // lbl_senderAddress
            // 
            this.lbl_senderAddress.AutoSize = true;
            this.lbl_senderAddress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_senderAddress.Location = new System.Drawing.Point(66, 230);
            this.lbl_senderAddress.Name = "lbl_senderAddress";
            this.lbl_senderAddress.Size = new System.Drawing.Size(125, 20);
            this.lbl_senderAddress.TabIndex = 5;
            this.lbl_senderAddress.Text = "lbl_senderAddress";
            // 
            // lbl_senderPostcode
            // 
            this.lbl_senderPostcode.AutoSize = true;
            this.lbl_senderPostcode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_senderPostcode.Location = new System.Drawing.Point(12, 320);
            this.lbl_senderPostcode.Name = "lbl_senderPostcode";
            this.lbl_senderPostcode.Size = new System.Drawing.Size(132, 20);
            this.lbl_senderPostcode.TabIndex = 6;
            this.lbl_senderPostcode.Text = "lbl_senderPostcode";
            // 
            // lbl_receiverCompanyName
            // 
            this.lbl_receiverCompanyName.AutoSize = true;
            this.lbl_receiverCompanyName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_receiverCompanyName.Location = new System.Drawing.Point(9, 412);
            this.lbl_receiverCompanyName.Name = "lbl_receiverCompanyName";
            this.lbl_receiverCompanyName.Size = new System.Drawing.Size(175, 20);
            this.lbl_receiverCompanyName.TabIndex = 7;
            this.lbl_receiverCompanyName.Text = "lbl_receiverCompanyName";
            // 
            // lbl_receiverAddress
            // 
            this.lbl_receiverAddress.AutoSize = true;
            this.lbl_receiverAddress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_receiverAddress.Location = new System.Drawing.Point(12, 484);
            this.lbl_receiverAddress.Name = "lbl_receiverAddress";
            this.lbl_receiverAddress.Size = new System.Drawing.Size(132, 20);
            this.lbl_receiverAddress.TabIndex = 8;
            this.lbl_receiverAddress.Text = "lbl_receiverAddress";
            // 
            // lbl_receiverPostcode
            // 
            this.lbl_receiverPostcode.AutoSize = true;
            this.lbl_receiverPostcode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_receiverPostcode.Location = new System.Drawing.Point(9, 570);
            this.lbl_receiverPostcode.Name = "lbl_receiverPostcode";
            this.lbl_receiverPostcode.Size = new System.Drawing.Size(139, 20);
            this.lbl_receiverPostcode.TabIndex = 9;
            this.lbl_receiverPostcode.Text = "lbl_receiverPostcode";
            // 
            // lbl_receiverCountry
            // 
            this.lbl_receiverCountry.AutoSize = true;
            this.lbl_receiverCountry.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_receiverCountry.Location = new System.Drawing.Point(253, 570);
            this.lbl_receiverCountry.Name = "lbl_receiverCountry";
            this.lbl_receiverCountry.Size = new System.Drawing.Size(130, 20);
            this.lbl_receiverCountry.TabIndex = 10;
            this.lbl_receiverCountry.Text = "lbl_receiverCountry";
            // 
            // lbl_senderPhoneNo
            // 
            this.lbl_senderPhoneNo.AutoSize = true;
            this.lbl_senderPhoneNo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_senderPhoneNo.Location = new System.Drawing.Point(253, 321);
            this.lbl_senderPhoneNo.Name = "lbl_senderPhoneNo";
            this.lbl_senderPhoneNo.Size = new System.Drawing.Size(131, 20);
            this.lbl_senderPhoneNo.TabIndex = 11;
            this.lbl_senderPhoneNo.Text = "lbl_senderPhoneNo";
            // 
            // lbl_receiverPhoneNo
            // 
            this.lbl_receiverPhoneNo.AutoSize = true;
            this.lbl_receiverPhoneNo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_receiverPhoneNo.Location = new System.Drawing.Point(253, 619);
            this.lbl_receiverPhoneNo.Name = "lbl_receiverPhoneNo";
            this.lbl_receiverPhoneNo.Size = new System.Drawing.Size(138, 20);
            this.lbl_receiverPhoneNo.TabIndex = 12;
            this.lbl_receiverPhoneNo.Text = "lbl_receiverPhoneNo";
            // 
            // lbl_receiverContectName
            // 
            this.lbl_receiverContectName.AutoSize = true;
            this.lbl_receiverContectName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_receiverContectName.Location = new System.Drawing.Point(9, 619);
            this.lbl_receiverContectName.Name = "lbl_receiverContectName";
            this.lbl_receiverContectName.Size = new System.Drawing.Size(163, 20);
            this.lbl_receiverContectName.TabIndex = 13;
            this.lbl_receiverContectName.Text = "lbl_receiverContectName";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_date.Location = new System.Drawing.Point(346, 777);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(36, 20);
            this.lbl_date.TabIndex = 14;
            this.lbl_date.Text = "Date";
            // 
            // lbl_pkgDesc
            // 
            this.lbl_pkgDesc.AutoSize = true;
            this.lbl_pkgDesc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_pkgDesc.Location = new System.Drawing.Point(592, 442);
            this.lbl_pkgDesc.Name = "lbl_pkgDesc";
            this.lbl_pkgDesc.Size = new System.Drawing.Size(85, 20);
            this.lbl_pkgDesc.TabIndex = 15;
            this.lbl_pkgDesc.Text = "lbl_pkgDesc";
            // 
            // lbl_pkgValue
            // 
            this.lbl_pkgValue.AutoSize = true;
            this.lbl_pkgValue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_pkgValue.Location = new System.Drawing.Point(439, 570);
            this.lbl_pkgValue.Name = "lbl_pkgValue";
            this.lbl_pkgValue.Size = new System.Drawing.Size(90, 20);
            this.lbl_pkgValue.TabIndex = 16;
            this.lbl_pkgValue.Text = "lbl_pkgValue";
            // 
            // ckb_serviceDocument
            // 
            this.ckb_serviceDocument.AutoSize = true;
            this.ckb_serviceDocument.Location = new System.Drawing.Point(430, 207);
            this.ckb_serviceDocument.Name = "ckb_serviceDocument";
            this.ckb_serviceDocument.Size = new System.Drawing.Size(15, 14);
            this.ckb_serviceDocument.TabIndex = 18;
            this.ckb_serviceDocument.UseVisualStyleBackColor = true;
            // 
            // ckb_servicePackageExpress
            // 
            this.ckb_servicePackageExpress.AutoSize = true;
            this.ckb_servicePackageExpress.Location = new System.Drawing.Point(430, 235);
            this.ckb_servicePackageExpress.Name = "ckb_servicePackageExpress";
            this.ckb_servicePackageExpress.Size = new System.Drawing.Size(15, 14);
            this.ckb_servicePackageExpress.TabIndex = 19;
            this.ckb_servicePackageExpress.UseVisualStyleBackColor = true;
            // 
            // ckb_serviceExpressDocument
            // 
            this.ckb_serviceExpressDocument.AutoSize = true;
            this.ckb_serviceExpressDocument.Location = new System.Drawing.Point(430, 263);
            this.ckb_serviceExpressDocument.Name = "ckb_serviceExpressDocument";
            this.ckb_serviceExpressDocument.Size = new System.Drawing.Size(15, 14);
            this.ckb_serviceExpressDocument.TabIndex = 20;
            this.ckb_serviceExpressDocument.UseVisualStyleBackColor = true;
            // 
            // ckb_serviceDomestic
            // 
            this.ckb_serviceDomestic.AutoSize = true;
            this.ckb_serviceDomestic.Location = new System.Drawing.Point(430, 292);
            this.ckb_serviceDomestic.Name = "ckb_serviceDomestic";
            this.ckb_serviceDomestic.Size = new System.Drawing.Size(15, 14);
            this.ckb_serviceDomestic.TabIndex = 21;
            this.ckb_serviceDomestic.UseVisualStyleBackColor = true;
            // 
            // ckb_serviceWorldmail
            // 
            this.ckb_serviceWorldmail.AutoSize = true;
            this.ckb_serviceWorldmail.Location = new System.Drawing.Point(430, 321);
            this.ckb_serviceWorldmail.Name = "ckb_serviceWorldmail";
            this.ckb_serviceWorldmail.Size = new System.Drawing.Size(15, 14);
            this.ckb_serviceWorldmail.TabIndex = 22;
            this.ckb_serviceWorldmail.UseVisualStyleBackColor = true;
            // 
            // ckb_transportSender
            // 
            this.ckb_transportSender.AutoSize = true;
            this.ckb_transportSender.Location = new System.Drawing.Point(717, 224);
            this.ckb_transportSender.Name = "ckb_transportSender";
            this.ckb_transportSender.Size = new System.Drawing.Size(15, 14);
            this.ckb_transportSender.TabIndex = 23;
            this.ckb_transportSender.UseVisualStyleBackColor = true;
            // 
            // ckb_transportCashChequeCreditCard
            // 
            this.ckb_transportCashChequeCreditCard.AutoSize = true;
            this.ckb_transportCashChequeCreditCard.Location = new System.Drawing.Point(717, 254);
            this.ckb_transportCashChequeCreditCard.Name = "ckb_transportCashChequeCreditCard";
            this.ckb_transportCashChequeCreditCard.Size = new System.Drawing.Size(15, 14);
            this.ckb_transportCashChequeCreditCard.TabIndex = 24;
            this.ckb_transportCashChequeCreditCard.UseVisualStyleBackColor = true;
            // 
            // ckb_transportExternalBillingAgreement
            // 
            this.ckb_transportExternalBillingAgreement.AutoSize = true;
            this.ckb_transportExternalBillingAgreement.Location = new System.Drawing.Point(717, 306);
            this.ckb_transportExternalBillingAgreement.Name = "ckb_transportExternalBillingAgreement";
            this.ckb_transportExternalBillingAgreement.Size = new System.Drawing.Size(15, 14);
            this.ckb_transportExternalBillingAgreement.TabIndex = 25;
            this.ckb_transportExternalBillingAgreement.UseVisualStyleBackColor = true;
            // 
            // ckb_transportCollect
            // 
            this.ckb_transportCollect.AutoSize = true;
            this.ckb_transportCollect.Location = new System.Drawing.Point(717, 336);
            this.ckb_transportCollect.Name = "ckb_transportCollect";
            this.ckb_transportCollect.Size = new System.Drawing.Size(15, 14);
            this.ckb_transportCollect.TabIndex = 26;
            this.ckb_transportCollect.UseVisualStyleBackColor = true;
            // 
            // ckb_shipmentInsurance
            // 
            this.ckb_shipmentInsurance.AutoSize = true;
            this.ckb_shipmentInsurance.Location = new System.Drawing.Point(719, 398);
            this.ckb_shipmentInsurance.Name = "ckb_shipmentInsurance";
            this.ckb_shipmentInsurance.Size = new System.Drawing.Size(15, 14);
            this.ckb_shipmentInsurance.TabIndex = 27;
            this.ckb_shipmentInsurance.UseVisualStyleBackColor = true;
            // 
            // ckb_exportPermanent
            // 
            this.ckb_exportPermanent.AutoSize = true;
            this.ckb_exportPermanent.Location = new System.Drawing.Point(517, 673);
            this.ckb_exportPermanent.Name = "ckb_exportPermanent";
            this.ckb_exportPermanent.Size = new System.Drawing.Size(15, 14);
            this.ckb_exportPermanent.TabIndex = 28;
            this.ckb_exportPermanent.UseVisualStyleBackColor = true;
            // 
            // ckb_exportRepair
            // 
            this.ckb_exportRepair.AutoSize = true;
            this.ckb_exportRepair.Location = new System.Drawing.Point(621, 673);
            this.ckb_exportRepair.Name = "ckb_exportRepair";
            this.ckb_exportRepair.Size = new System.Drawing.Size(15, 14);
            this.ckb_exportRepair.TabIndex = 29;
            this.ckb_exportRepair.UseVisualStyleBackColor = true;
            // 
            // ckb_exportTemporary
            // 
            this.ckb_exportTemporary.AutoSize = true;
            this.ckb_exportTemporary.Location = new System.Drawing.Point(751, 673);
            this.ckb_exportTemporary.Name = "ckb_exportTemporary";
            this.ckb_exportTemporary.Size = new System.Drawing.Size(15, 14);
            this.ckb_exportTemporary.TabIndex = 30;
            this.ckb_exportTemporary.UseVisualStyleBackColor = true;
            // 
            // ckb_taxesReceiver
            // 
            this.ckb_taxesReceiver.AutoSize = true;
            this.ckb_taxesReceiver.Location = new System.Drawing.Point(430, 741);
            this.ckb_taxesReceiver.Name = "ckb_taxesReceiver";
            this.ckb_taxesReceiver.Size = new System.Drawing.Size(15, 14);
            this.ckb_taxesReceiver.TabIndex = 31;
            this.ckb_taxesReceiver.UseVisualStyleBackColor = true;
            // 
            // ckb_taxesSender
            // 
            this.ckb_taxesSender.AutoSize = true;
            this.ckb_taxesSender.Location = new System.Drawing.Point(517, 741);
            this.ckb_taxesSender.Name = "ckb_taxesSender";
            this.ckb_taxesSender.Size = new System.Drawing.Size(15, 14);
            this.ckb_taxesSender.TabIndex = 32;
            this.ckb_taxesSender.UseVisualStyleBackColor = true;
            // 
            // ckb_taxesOther
            // 
            this.ckb_taxesOther.AutoSize = true;
            this.ckb_taxesOther.Location = new System.Drawing.Point(587, 742);
            this.ckb_taxesOther.Name = "ckb_taxesOther";
            this.ckb_taxesOther.Size = new System.Drawing.Size(15, 14);
            this.ckb_taxesOther.TabIndex = 33;
            this.ckb_taxesOther.UseVisualStyleBackColor = true;
            // 
            // lbl_pkgQty
            // 
            this.lbl_pkgQty.AutoSize = true;
            this.lbl_pkgQty.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_pkgQty.Location = new System.Drawing.Point(933, 100);
            this.lbl_pkgQty.Name = "lbl_pkgQty";
            this.lbl_pkgQty.Size = new System.Drawing.Size(76, 20);
            this.lbl_pkgQty.TabIndex = 34;
            this.lbl_pkgQty.Text = "lbl_pkgQty";
            // 
            // lbl_pkgWeight
            // 
            this.lbl_pkgWeight.AutoSize = true;
            this.lbl_pkgWeight.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_pkgWeight.Location = new System.Drawing.Point(1062, 100);
            this.lbl_pkgWeight.Name = "lbl_pkgWeight";
            this.lbl_pkgWeight.Size = new System.Drawing.Size(51, 20);
            this.lbl_pkgWeight.TabIndex = 35;
            this.lbl_pkgWeight.Text = "Weight";
            // 
            // lbl_pkgDimensions
            // 
            this.lbl_pkgDimensions.AutoSize = true;
            this.lbl_pkgDimensions.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_pkgDimensions.Location = new System.Drawing.Point(933, 152);
            this.lbl_pkgDimensions.Name = "lbl_pkgDimensions";
            this.lbl_pkgDimensions.Size = new System.Drawing.Size(129, 20);
            this.lbl_pkgDimensions.TabIndex = 36;
            this.lbl_pkgDimensions.Text = "lbl_pkgDimensions";
            // 
            // lbl_senderDeletePhone
            // 
            this.lbl_senderDeletePhone.AutoSize = true;
            this.lbl_senderDeletePhone.Font = new System.Drawing.Font("PMingLiU", 6F);
            this.lbl_senderDeletePhone.Location = new System.Drawing.Point(254, 307);
            this.lbl_senderDeletePhone.Name = "lbl_senderDeletePhone";
            this.lbl_senderDeletePhone.Size = new System.Drawing.Size(22, 8);
            this.lbl_senderDeletePhone.TabIndex = 37;
            this.lbl_senderDeletePhone.Text = "delete";
            // 
            // lbl_senderDeleteFax
            // 
            this.lbl_senderDeleteFax.AutoSize = true;
            this.lbl_senderDeleteFax.Font = new System.Drawing.Font("PMingLiU", 6F);
            this.lbl_senderDeleteFax.Location = new System.Drawing.Point(290, 307);
            this.lbl_senderDeleteFax.Name = "lbl_senderDeleteFax";
            this.lbl_senderDeleteFax.Size = new System.Drawing.Size(22, 8);
            this.lbl_senderDeleteFax.TabIndex = 38;
            this.lbl_senderDeleteFax.Text = "delete";
            // 
            // lbl_senderDeleteTelex
            // 
            this.lbl_senderDeleteTelex.AutoSize = true;
            this.lbl_senderDeleteTelex.Font = new System.Drawing.Font("PMingLiU", 6F);
            this.lbl_senderDeleteTelex.Location = new System.Drawing.Point(317, 307);
            this.lbl_senderDeleteTelex.Name = "lbl_senderDeleteTelex";
            this.lbl_senderDeleteTelex.Size = new System.Drawing.Size(22, 8);
            this.lbl_senderDeleteTelex.TabIndex = 39;
            this.lbl_senderDeleteTelex.Text = "delete";
            // 
            // lbl_receiverDeleteTelex
            // 
            this.lbl_receiverDeleteTelex.AutoSize = true;
            this.lbl_receiverDeleteTelex.Location = new System.Drawing.Point(317, 602);
            this.lbl_receiverDeleteTelex.Name = "lbl_receiverDeleteTelex";
            this.lbl_receiverDeleteTelex.Size = new System.Drawing.Size(32, 12);
            this.lbl_receiverDeleteTelex.TabIndex = 40;
            this.lbl_receiverDeleteTelex.Text = "delete";
            // 
            // lbl_receiverDeleteFax
            // 
            this.lbl_receiverDeleteFax.AutoSize = true;
            this.lbl_receiverDeleteFax.Location = new System.Drawing.Point(292, 602);
            this.lbl_receiverDeleteFax.Name = "lbl_receiverDeleteFax";
            this.lbl_receiverDeleteFax.Size = new System.Drawing.Size(32, 12);
            this.lbl_receiverDeleteFax.TabIndex = 41;
            this.lbl_receiverDeleteFax.Text = "delete";
            // 
            // lbl_receiverDeletePhone
            // 
            this.lbl_receiverDeletePhone.AutoSize = true;
            this.lbl_receiverDeletePhone.Location = new System.Drawing.Point(254, 602);
            this.lbl_receiverDeletePhone.Name = "lbl_receiverDeletePhone";
            this.lbl_receiverDeletePhone.Size = new System.Drawing.Size(32, 12);
            this.lbl_receiverDeletePhone.TabIndex = 42;
            this.lbl_receiverDeletePhone.Text = "delete";
            // 
            // lbl_serviceDeleteAirmail
            // 
            this.lbl_serviceDeleteAirmail.AutoSize = true;
            this.lbl_serviceDeleteAirmail.Location = new System.Drawing.Point(440, 353);
            this.lbl_serviceDeleteAirmail.Name = "lbl_serviceDeleteAirmail";
            this.lbl_serviceDeleteAirmail.Size = new System.Drawing.Size(33, 12);
            this.lbl_serviceDeleteAirmail.TabIndex = 43;
            this.lbl_serviceDeleteAirmail.Text = "label1";
            // 
            // lbl_serviceDeletePrintedMaster
            // 
            this.lbl_serviceDeletePrintedMaster.AutoSize = true;
            this.lbl_serviceDeletePrintedMaster.Location = new System.Drawing.Point(490, 353);
            this.lbl_serviceDeletePrintedMaster.Name = "lbl_serviceDeletePrintedMaster";
            this.lbl_serviceDeletePrintedMaster.Size = new System.Drawing.Size(33, 12);
            this.lbl_serviceDeletePrintedMaster.TabIndex = 44;
            this.lbl_serviceDeletePrintedMaster.Text = "label2";
            // 
            // lbl_shipmentNo
            // 
            this.lbl_shipmentNo.AutoSize = true;
            this.lbl_shipmentNo.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_shipmentNo.Location = new System.Drawing.Point(512, 78);
            this.lbl_shipmentNo.Name = "lbl_shipmentNo";
            this.lbl_shipmentNo.Size = new System.Drawing.Size(130, 24);
            this.lbl_shipmentNo.TabIndex = 45;
            this.lbl_shipmentNo.Text = "lbl_shipmentNo";
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold);
            this.btn_print.Location = new System.Drawing.Point(995, 812);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(130, 32);
            this.btn_print.TabIndex = 46;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EDEapp.Properties.Resources.AirwayBill1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1125, 802);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 27);
            this.label1.TabIndex = 47;
            this.label1.Text = "EDE Shippment Airway Bill (Origin Copy) Non-negotiable";
            // 
            // AirwayBill_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 853);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lbl_shipmentNo);
            this.Controls.Add(this.lbl_serviceDeletePrintedMaster);
            this.Controls.Add(this.lbl_serviceDeleteAirmail);
            this.Controls.Add(this.lbl_receiverDeletePhone);
            this.Controls.Add(this.lbl_receiverDeleteFax);
            this.Controls.Add(this.lbl_receiverDeleteTelex);
            this.Controls.Add(this.lbl_senderDeleteTelex);
            this.Controls.Add(this.lbl_senderDeleteFax);
            this.Controls.Add(this.lbl_senderDeletePhone);
            this.Controls.Add(this.lbl_pkgDimensions);
            this.Controls.Add(this.lbl_pkgWeight);
            this.Controls.Add(this.lbl_pkgQty);
            this.Controls.Add(this.ckb_taxesOther);
            this.Controls.Add(this.ckb_taxesSender);
            this.Controls.Add(this.ckb_taxesReceiver);
            this.Controls.Add(this.ckb_exportTemporary);
            this.Controls.Add(this.ckb_exportRepair);
            this.Controls.Add(this.ckb_exportPermanent);
            this.Controls.Add(this.ckb_shipmentInsurance);
            this.Controls.Add(this.ckb_transportCollect);
            this.Controls.Add(this.ckb_transportExternalBillingAgreement);
            this.Controls.Add(this.ckb_transportCashChequeCreditCard);
            this.Controls.Add(this.ckb_transportSender);
            this.Controls.Add(this.ckb_serviceWorldmail);
            this.Controls.Add(this.ckb_serviceDomestic);
            this.Controls.Add(this.ckb_serviceExpressDocument);
            this.Controls.Add(this.ckb_servicePackageExpress);
            this.Controls.Add(this.ckb_serviceDocument);
            this.Controls.Add(this.lbl_pkgValue);
            this.Controls.Add(this.lbl_pkgDesc);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_receiverContectName);
            this.Controls.Add(this.lbl_receiverPhoneNo);
            this.Controls.Add(this.lbl_senderPhoneNo);
            this.Controls.Add(this.lbl_receiverCountry);
            this.Controls.Add(this.lbl_receiverPostcode);
            this.Controls.Add(this.lbl_receiverAddress);
            this.Controls.Add(this.lbl_receiverCompanyName);
            this.Controls.Add(this.lbl_senderPostcode);
            this.Controls.Add(this.lbl_senderAddress);
            this.Controls.Add(this.lbl_senderCompanyName);
            this.Controls.Add(this.lbl_senderReference);
            this.Controls.Add(this.lbl_senderName);
            this.Controls.Add(this.lbl_accountID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AirwayBill_Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirwayBill_Print";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printAirwayBill;
        private System.Windows.Forms.Label lbl_accountID;
        private System.Windows.Forms.Label lbl_senderName;
        private System.Windows.Forms.Label lbl_senderReference;
        private System.Windows.Forms.Label lbl_senderCompanyName;
        private System.Windows.Forms.Label lbl_senderAddress;
        private System.Windows.Forms.Label lbl_senderPostcode;
        private System.Windows.Forms.Label lbl_receiverCompanyName;
        private System.Windows.Forms.Label lbl_receiverAddress;
        private System.Windows.Forms.Label lbl_receiverPostcode;
        private System.Windows.Forms.Label lbl_receiverCountry;
        private System.Windows.Forms.Label lbl_senderPhoneNo;
        private System.Windows.Forms.Label lbl_receiverPhoneNo;
        private System.Windows.Forms.Label lbl_receiverContectName;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_pkgDesc;
        private System.Windows.Forms.Label lbl_pkgValue;
        private System.Windows.Forms.CheckBox ckb_serviceDocument;
        private System.Windows.Forms.CheckBox ckb_servicePackageExpress;
        private System.Windows.Forms.CheckBox ckb_serviceExpressDocument;
        private System.Windows.Forms.CheckBox ckb_serviceDomestic;
        private System.Windows.Forms.CheckBox ckb_serviceWorldmail;
        private System.Windows.Forms.CheckBox ckb_transportSender;
        private System.Windows.Forms.CheckBox ckb_transportCashChequeCreditCard;
        private System.Windows.Forms.CheckBox ckb_transportExternalBillingAgreement;
        private System.Windows.Forms.CheckBox ckb_transportCollect;
        private System.Windows.Forms.CheckBox ckb_shipmentInsurance;
        private System.Windows.Forms.CheckBox ckb_exportPermanent;
        private System.Windows.Forms.CheckBox ckb_exportRepair;
        private System.Windows.Forms.CheckBox ckb_exportTemporary;
        private System.Windows.Forms.CheckBox ckb_taxesReceiver;
        private System.Windows.Forms.CheckBox ckb_taxesSender;
        private System.Windows.Forms.CheckBox ckb_taxesOther;
        private System.Windows.Forms.Label lbl_pkgQty;
        private System.Windows.Forms.Label lbl_pkgWeight;
        private System.Windows.Forms.Label lbl_pkgDimensions;
        private System.Windows.Forms.Label lbl_senderDeletePhone;
        private System.Windows.Forms.Label lbl_senderDeleteFax;
        private System.Windows.Forms.Label lbl_senderDeleteTelex;
        private System.Windows.Forms.Label lbl_receiverDeleteTelex;
        private System.Windows.Forms.Label lbl_receiverDeleteFax;
        private System.Windows.Forms.Label lbl_receiverDeletePhone;
        private System.Windows.Forms.Label lbl_serviceDeleteAirmail;
        private System.Windows.Forms.Label lbl_serviceDeletePrintedMaster;
        private System.Windows.Forms.Label lbl_shipmentNo;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
    }
}