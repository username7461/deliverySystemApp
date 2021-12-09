using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDEapp
{
    public partial class Payment : Form
    {
        public static string CIP = "";
        private string randomCode;
        private string cardrandomCode;
        public static string cardselect = "";
        public static DateTime saveexpirydate;
        public static string savecardNo = "";
        public static string saveholderName="";

        public Payment()
        {
            InitializeComponent();
            loadInvoiceID();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            getIP();
            combo_paymentMethod.Items.Add("Credit Card");
            combo_paymentMethod.Items.Add("Cash");
            combo_paymentMethod.Items.Add("Cheque");
            combo_cardtype.Items.Add("Visa");
            combo_cardtype.Items.Add("Master");
            group_creditCard.Visible = false;
            group_cheque.Visible = false;
            group_Cash.Visible = false;
            offtextbox();
            txt_value.Visible = false;
            lab_value.Visible = false;
            group_Cash.Visible = false;
        }

        public void getIP()  // get customer IP
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    CIP = ip.ToString();
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_invoiceID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void loadInvoiceID()
        {
            using (var invoiceID = new edeaccountEntities())
            {
                var invoicelist = (from list in invoiceID.consolidatemonthlyinvoice
                                   where list.accountID == Login.log_user
                                   where list.isPay == 0
                                   select list);

                foreach (var item in invoicelist)
                {
                    combo_invoiceID.Items.Add(item.invoiceID);
                }
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            EDEapp_MainMenu main = new EDEapp_MainMenu();
            main.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void combo_cardtype_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



        private void combo_paymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combo_paymentMethod.SelectedIndex)
            {
                case 0:
                    group_creditCard.Visible = true;
                    group_Cash.Visible = false;
                    group_cheque.Visible = false;
                    break;
                case 1:
                    group_creditCard.Visible = false;
                    group_Cash.Visible = true;
                    group_cheque.Visible = false;
                    break;
                case 2:
                    group_creditCard.Visible = false;
                    group_Cash.Visible = false;
                    group_cheque.Visible = true;
                    break;
            }
        }

        private void combo_cardtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_cardtype.SelectedItem == "" && combo_cardtype.SelectedIndex == -1)
            {
                offtextbox();
                cardselect = "";
            }
            else if(combo_cardtype.SelectedItem == "Visa" || combo_cardtype.SelectedItem == "Master")
            {
                cardselect = Convert.ToString(combo_cardtype.SelectedItem);
                opentextbox();
                using (edeaccountEntities content = new edeaccountEntities())
                {

                    //creditcard card = content.creditcard.Where(i => i.cardType == combo_cardtype.SelectedItem.ToString() && i.accountID == Login.log_user);
                    var card = content.creditcard.Where(i => i.cardType == combo_cardtype.SelectedItem.ToString() && i.accountID == Login.log_user);
                    if (card != null)
                    {
                        if (MessageBox.Show("Do you want to select your saved credit card?", "Get the saved credit card?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            CreditcardRecord record = new CreditcardRecord();

                            if (record.ShowDialog() == DialogResult.OK && record !=null)
                            {
                                
                                this.txt_cardNo.Text = Payment.savecardNo;
                                this.txt_expiryDate.Text = Payment.saveexpirydate.ToString("MM/yyyy");
                                this.txt_holderName.Text = Payment.saveholderName;
                                txt_cardNo.Enabled = false;
                                txt_expiryDate.Enabled = false;
                                txt_holderName.Enabled = false;
                                txt_cardNo.PasswordChar = '*';
                            }
                            
                            //txt_cardNo.Text = CreditcardRecord.savecardNo;
                            //txt_expiryDate.Text = Convert.ToString(CreditcardRecord.saveexpirydate);
                            //txt_holderName.Text = CreditcardRecord.saveholderName;
                        }
                    }
                }
            }

        }

        private void offtextbox()
        {
            txt_cardNo.Visible = false;
            txt_cvv.Visible = false;
            txt_expiryDate.Visible = false;
            txt_holderName.Visible = false;
            lab_cardNo.Visible = false;
            lab_expiryDate.Visible = false;
            lab_cvv.Visible = false;
            lab_holderName.Visible = false;
            btn_pay.Visible = false;
            btn_cancel.Visible = false;
        }

        private void opentextbox()
        {
            txt_cardNo.Visible = true;
            txt_cvv.Visible = true;
            txt_expiryDate.Visible = true;
            txt_holderName.Visible = true;
            lab_cardNo.Visible = true;
            lab_expiryDate.Visible = true;
            lab_cvv.Visible = true;
            lab_holderName.Visible = true;
            btn_pay.Visible = true;
            btn_cancel.Visible = true;
        }

        private void txt_cvv_TextChanged(object sender, EventArgs e)
        {
            txt_cvv.MaxLength = 3;
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            Random rand1 = new Random();
            Random rand2 = new Random();
            cardrandomCode = (rand1.Next(9999)).ToString();
            randomCode = (rand2.Next(999999999)).ToString();
            string paymentID;
            string testID;
            paymentID = randomCode;
            testID = cardrandomCode;
            var cardCheck = new Regex(@"^[0-9]{16,16}$");
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            var cvvCheck = new Regex(@"^\d{3}$");
            bool checkcreditcard = false;
            if (txt_cardNo.Text.Trim() == "")
            {
                MessageBox.Show("You should provide your card no.");
            }
            else if (!cardCheck.IsMatch(txt_cardNo.Text))
            {
                MessageBox.Show("Your card No is invalid.");
            }
            else if (txt_cvv.Text.Trim() == "")
            {
                MessageBox.Show("You should provide your CVV.");
            }
            else if (!cvvCheck.IsMatch(txt_cvv.Text))
            {
                MessageBox.Show("Your CVV is invalid.");
            }
            else if (txt_expiryDate.Text.Trim() == "")
            {
                MessageBox.Show("You should provide your expiry date.");
            }
            else if (txt_holderName.Text.Trim() == "")
            {
                MessageBox.Show("You should provide your card's holder name.");
            }
            else
            {
                var dateParts = txt_expiryDate.Text.Split('/');
                var year = int.Parse(dateParts[1]);
                var month = int.Parse(dateParts[0]);
                var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month);
                var cardExpiry = new DateTime(year, month, 23);
                if (!monthCheck.IsMatch(dateParts[0]) || !yearCheck.IsMatch(dateParts[1]))
                {
                    MessageBox.Show("Your card Expiry Date is invalid.");
                }
                else if (cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6))
                {
                    using (edeaccountEntities content = new edeaccountEntities())
                    {
                        consolidatemonthlyinvoice invoice = content.consolidatemonthlyinvoice.SingleOrDefault(i => i.invoiceID == combo_invoiceID.SelectedItem.ToString());
                        creditcard pay1 = content.creditcard.SingleOrDefault(i => i.cardNo == txt_cardNo.Text);

                        using (var checkcreditcardexist = new edeaccountEntities())

                        {
                            var creditcardexist1 = (from list in checkcreditcardexist.creditcard
                                                    select list);
                            foreach (var creditcardexist2 in creditcardexist1.ToList())
                            {
                                if (creditcardexist2.cardNo == txt_cardNo.Text)
                                {
                                    checkcreditcard = true;
                                    break;
                                }
                            }
                        }
                        if (MessageBox.Show("Are you sure that to do the payment?", "Payment?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if(checkcreditcard)
                            {
                                paymentrecord paymentrecordhavecard = new paymentrecord
                                {
                                    paymentID = "p" + paymentID,
                                    accountID = Login.log_user,
                                    payDateTime = DateTime.Now,
                                    payMethod = combo_paymentMethod.GetItemText(combo_paymentMethod.SelectedItem),
                                    cardID = pay1.cardID,
                                    payValue = Convert.ToDouble(txt_value.Text)

                                };
                                content.paymentrecord.Add(paymentrecordhavecard);
                                content.SaveChanges();
                                MessageBox.Show("Your payment is successful! Your paymentID is p" + paymentID);

                                log logging = new log
                                {
                                    accountID = Login.log_user,
                                    times = DateTime.Now,
                                    actionPerformed = "Do Payment",
                                    ipAddress = CIP

                                };
                                content.log.Add(logging);
                                content.SaveChanges();
                                if (invoice != null)
                                {
                                    invoice.isPay = 1;
                                }
                                content.SaveChanges();
                                EDEapp_MainMenu main = new EDEapp_MainMenu();
                                main.Show();
                                this.Hide();
                            }
                            else if (!checkcreditcard)
                            {
                                DialogResult result = MessageBox.Show("Do you want to save your card information?", "Save Card Information?", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {

                                    Random rand = new Random();
                                    cardrandomCode = (rand.Next(9999)).ToString();
                                    randomCode = (rand.Next(999999999)).ToString();
                                    paymentrecord paymentrecord = new paymentrecord
                                    {
                                        paymentID = "p" + paymentID,
                                        accountID = Login.log_user,
                                        payDateTime = DateTime.Now,
                                        payMethod = combo_paymentMethod.GetItemText(combo_paymentMethod.SelectedItem),
                                        cardID = "cardID" + testID,
                                        payValue = Convert.ToDouble(txt_value.Text)

                                    };
                                    content.paymentrecord.Add(paymentrecord);
                                    content.SaveChanges();
                                    MessageBox.Show("Your Payment is successful!Your paymentID is p" + paymentID);

                                    log logging = new log
                                    {
                                        accountID = Login.log_user,
                                        times = DateTime.Now,
                                        actionPerformed = "Do Payment",
                                        ipAddress = CIP

                                    };
                                    content.log.Add(logging);
                                    content.SaveChanges();
                                    if (invoice != null)
                                    {
                                        invoice.isPay = 1;
                                    }
                                    content.SaveChanges();
                                    creditcard card = new creditcard
                                    {
                                        cardID = "cardID" + testID,
                                        accountID = Login.log_user,
                                        cardNo = txt_cardNo.Text,
                                        cardType = combo_cardtype.GetItemText(combo_cardtype.SelectedItem),
                                        expiryDate = Convert.ToDateTime(txt_expiryDate.Text),
                                        holderName = txt_holderName.Text
                                    };
                                    content.creditcard.Add(card);
                                    content.SaveChanges();
                                    MessageBox.Show("Card information saved!");
                                    EDEapp_MainMenu main = new EDEapp_MainMenu();
                                    main.Show();
                                    this.Hide();
                                }
                                else if(result == DialogResult.No)
                                {
                                    paymentrecord paymentrecord2 = new paymentrecord
                                    {
                                        paymentID = "p" + paymentID,
                                        accountID = Login.log_user,
                                        payDateTime = DateTime.Now,
                                        payMethod = combo_paymentMethod.GetItemText(combo_paymentMethod.SelectedItem),
                                        // cardID = "cardID" + testID,
                                        payValue = Convert.ToDouble(txt_value.Text)
                                    };
                                    content.paymentrecord.Add(paymentrecord2);
                                    try
                                    {
                                        content.SaveChanges();
                                    }
                                    catch (DbEntityValidationException dbEx)
                                    {
                                        Exception raise = dbEx;
                                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                                        {
                                            foreach (var validationError in validationErrors.ValidationErrors)
                                            {
                                                string message = string.Format("{0}:{1}",
                                                    validationErrors.Entry.Entity.ToString(),
                                                    validationError.ErrorMessage);
                                                // raise a new exception nesting  
                                                // the current instance as InnerException  
                                                raise = new InvalidOperationException(message, raise);
                                            }
                                        }
                                        throw raise;
                                    }
                                    MessageBox.Show("Your Payment is successful!Your paymentID is p" + paymentID);
                                    log logging = new log
                                    {
                                        accountID = Login.log_user,
                                        times = DateTime.Now,
                                        actionPerformed = "Do Payment",
                                        ipAddress = CIP

                                    };
                                    content.log.Add(logging);
                                    content.SaveChanges();
                                    if (invoice != null)
                                    {
                                        invoice.isPay = 1;
                                    }
                                    content.SaveChanges();
                                    EDEapp_MainMenu main = new EDEapp_MainMenu();
                                    main.Show();
                                    this.Hide();
                                }
                            }
                        }

                    }
                }

            }
        }
    
        
        private void lab_value_Click(object sender, EventArgs e)
        {

        }

        private void combo_invoiceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_invoiceID.SelectedItem=="")
            {
                txt_value.Visible = false;
                lab_value.Visible = false;
            }
            else
            {
                txt_value.Visible = true;
                lab_value.Visible = true;
                using (edeaccountEntities content = new edeaccountEntities())
                {
                    var adb = (from list in content.consolidatemonthlyinvoice
                               where list.accountID == Login.log_user
                               where list.invoiceID == combo_invoiceID.SelectedItem.ToString()
                               select list);
                    foreach(var adb2 in adb.ToList())
                    {
                        txt_value.Text = Convert.ToString(adb2.value);
                    }
                }
            }
        }

        private void txt_cardNo_TextChanged(object sender, EventArgs e)
        {
            txt_cardNo.MaxLength = 16;
        }

        private void txt_expiryDate_TextChanged(object sender, EventArgs e)
        {
            txt_expiryDate.MaxLength = 7;
        }

        private void txt_cardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_cvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_holderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_expiryDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_stgooglemap_Click(object sender, EventArgs e)
        {
            shaTinLocation shaTinLocation = new shaTinLocation();
            shaTinLocation.Show();
        }

        private void btn_lwlgooglemap_Click(object sender, EventArgs e)
        {
            LeeWaiLeeLocation leeWaiLeeLocation = new LeeWaiLeeLocation();
            leeWaiLeeLocation.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_cardNo.Enabled = true;
            txt_expiryDate.Enabled = true;
            txt_holderName.Enabled = true;
            txt_holderName.Text = "";
            txt_cardNo.Text = "";
            txt_expiryDate.Text = "";
            txt_cvv.Text = "";
            combo_cardtype.SelectedIndex = -1;
            combo_cardtype.SelectedItem = "";
            txt_cardNo.PasswordChar = '\0';
        }
    }
}
