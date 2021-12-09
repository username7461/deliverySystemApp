using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDEapp
{
    public partial class CheckSavedCreditCard : Form
    {
        private string cardrandomCode;
        creditcard creditcard2 = new creditcard();
        public CheckSavedCreditCard()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            ViewAccountInformation view = new ViewAccountInformation();
            view.Show();
            this.Hide();
        }

        private void CheckSavedCreditCard_Load(object sender, EventArgs e)
        {
            showAllCard();
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            combo_cardtype.Items.Add("Visa");
            combo_cardtype.Items.Add("Master");
        }
        private void showAllCard()
        {
            using (var checkallcard = new edeaccountEntities())
            {
                var allcard = (from list in checkallcard.creditcard
                               where list.accountID == Login.log_user
                               select list);

                // select * from employees

                foreach (var allcard2 in allcard.ToList())
                {
                    dataGridView2.Rows.Add(allcard2.cardID, allcard2.cardNo, allcard2.expiryDate.ToString("MM/yyyy"), allcard2.cardType, allcard2.holderName, "Delete");

                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void reload()
        {
            this.dataGridView2.DataSource = null;
            this.dataGridView2.Rows.Clear();
            using (var checkallcard = new edeaccountEntities())
            {
                var allcard = (from list in checkallcard.creditcard
                               where list.accountID == Login.log_user
                               select list);

                // select * from employees

                foreach (var allcard2 in allcard.ToList())
                {
                    
                    dataGridView2.Rows.Add(allcard2.cardID, allcard2.cardNo, allcard2.expiryDate.ToString("MM/yyyy"), allcard2.cardType, allcard2.holderName, "Delete");

                }
            }
        }

        private void txt_cardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void txt_holderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Clear()
        {
            txt_cardNo.Text = txt_expiryDate.Text = txt_holderName.Text = "";
            combo_cardtype.SelectedIndex = -1;
            btn_delete.Enabled = false;
            txt_cardNo.Enabled = true;
            btn_edit.Enabled = false;
            btn_add.Enabled = true;
            combo_cardtype.Enabled = true;
        }
        private void combo_cardtype_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_expiryDate_TextChanged(object sender, EventArgs e)
        {
            txt_expiryDate.MaxLength = 7;
        }

        private void txt_holderName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cardNo_TextChanged(object sender, EventArgs e)
        {
            txt_cardNo.MaxLength = 16;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Random rand1 = new Random();
            cardrandomCode = (rand1.Next(9999)).ToString();
            string testID;
            testID = cardrandomCode;
            var cardCheck = new Regex(@"^[0-9]{16,16}$");
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            bool checkcardexist = false;
            if (txt_cardNo.Text.Trim() == "")
            {
                MessageBox.Show("You Should Provide Your Card No");
            }
            else if (!cardCheck.IsMatch(txt_cardNo.Text))
            {
                MessageBox.Show("Your card No is Invalid");
            }
            else if (txt_expiryDate.Text.Trim() == "")
            {
                MessageBox.Show("You Should Provide Your expiryDate ");
            }
            else if (txt_holderName.Text.Trim() == "")
            {
                MessageBox.Show("You Should Provide Your Holder Name ");
            }
            else
            {
                using (var cardcheck = new edeaccountEntities())

                {

                    var card1 = (from list in cardcheck.creditcard
                                 select list);

                    foreach (var card12 in card1.ToList())
                    {
                        // if (customer2.accountID == txt_accountID.Text)
                        //{
                        //    checkaccountexist = true;
                        //    break;
                        //}
                        if (card12.cardNo == txt_cardNo.Text)
                        {
                            checkcardexist = true;
                            break;
                        }
                    }

                }
                if (checkcardexist)
                {
                    MessageBox.Show("Your Card Is Already In Record");
                }
                else
                {
                    MessageBox.Show("HERE");
                    var dateParts = txt_expiryDate.Text.Split('/');
                    var year = int.Parse(dateParts[1]);
                    var month = int.Parse(dateParts[0]);
                    var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month);
                    var cardExpiry = new DateTime(year, month, 23);
                    if (!monthCheck.IsMatch(dateParts[0]) || !yearCheck.IsMatch(dateParts[1]))
                    {
                        MessageBox.Show("Your Card ExpiryDate Is Invalid");
                    }
                    else if (cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6))
                    {
                        using (edeaccountEntities content = new edeaccountEntities())
                        {

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
                            reload();
                            Clear();
                        }
                    }
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Random rand1 = new Random();
            cardrandomCode = (rand1.Next(9999)).ToString();
            string testID;
            testID = cardrandomCode;
            
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            bool checkcardexist = false;
            if (txt_expiryDate.Text.Trim() == "")
            {
                MessageBox.Show("You Should Provide Your expiryDate ");
            }
            else if (txt_holderName.Text.Trim() == "")
            {
                MessageBox.Show("You Should Provide Your Holder Name ");
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
                        MessageBox.Show("Your Card ExpiryDate Is Invalid");
                    }
                    else if (cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6))
                    {
                        creditcard2.cardNo = Convert.ToString(dataGridView2.CurrentRow.Cells["cardID"].Value);
                        using (edeaccountEntities content = new edeaccountEntities())
                        {
                            creditcard card = content.creditcard.SingleOrDefault(i => i.cardID == creditcard2.cardID);
                            if (card != null)
                            {
                                card.cardNo = txt_cardNo.Text;
                                card.cardType = combo_cardtype.GetItemText(combo_cardtype.SelectedItem);
                                card.expiryDate = Convert.ToDateTime(txt_expiryDate.Text);
                                card.holderName = txt_holderName.Text;
                                content.SaveChanges();
                                MessageBox.Show("Card has been edit!");
                                reload();
                                Clear();
                            }
                        }
                    
                    
                }

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_cardNo.PasswordChar = '\0';
            txt_cardNo.Text = "";
            txt_expiryDate.Text = "";
            txt_holderName.Text = "";
            combo_cardtype.SelectedIndex = -1;
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            txt_cardNo.Enabled = true;
            combo_cardtype.Enabled = true;
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Index != -1)
            {
                creditcard2.cardID = Convert.ToString(dataGridView2.CurrentRow.Cells["cardID"].Value);
                using (edeaccountEntities ede = new edeaccountEntities())
                {
                    creditcard2 = ede.creditcard.Where(x => x.cardID == creditcard2.cardID).FirstOrDefault();
                    txt_cardNo.Text = creditcard2.cardNo;
                    txt_expiryDate.Text = creditcard2.expiryDate.ToString("MM/yyyy");
                    combo_cardtype.SelectedItem = creditcard2.cardType;
                    txt_holderName.Text = creditcard2.holderName;
                }
                btn_delete.Enabled = true;
                btn_edit.Enabled = true;
                btn_add.Enabled = false;
                txt_cardNo.Enabled = false;
                combo_cardtype.Enabled = false;
                txt_cardNo.PasswordChar = '*';
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Delete this Record? ", "Delete Address?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (edeaccountEntities credtcard = new edeaccountEntities())
                {
                    var entry = credtcard.Entry(creditcard2);
                    if (entry.State == EntityState.Detached)
                        credtcard.creditcard.Attach(creditcard2);
                    credtcard.creditcard.Remove(creditcard2);
                    credtcard.SaveChanges();
                    MessageBox.Show("Address delete");
                    reload();
                    Clear();
                }
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == 1)
            {
                var txt = (TextBox)e.Control;
                txt.Text = $"{dataGridView2.CurrentCell.Value}";
                txt.PasswordChar = '*';
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex ==1 && e.Value !=null)
            {
                e.Value = new String('*', e.Value.ToString().Length-4) + e.Value.ToString().Substring(e.Value.ToString().Length - 4); ;
            }
        }
    }
}   