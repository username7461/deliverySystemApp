
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDEapp
{
    public partial class AirwayBillExpenseCalculator : Form
    {

        public AirwayBillExpenseCalculator()
        {

            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_length_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))  //bypass control keys
            {
                int dotIndex = txt_length.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))     //ensure it's a digit
                {   //we cannot accept another digit if
                    if (dotIndex != -1 &&  //there is already a dot and
                                           //dot is to the left from the cursor position and
                        dotIndex < txt_length.SelectionStart &&
                        //there're already 2 symbols to the right from the dot
                        txt_length.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else //we cannot accept this char if
                    e.Handled = e.KeyChar != '.' || //it's not a dot or
                                                    //there is already a dot in the text or
                                dotIndex != -1 ||
                                //text is empty or
                                txt_length.Text.Length == 0 ||
                                //there are more than 2 symbols from cursor position
                                //to the end of the text
                                txt_length.SelectionStart + 2 < txt_length.Text.Length;
            }
        }
        private void txt_width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))  //bypass control keys
            {
                int dotIndex = txt_width.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))     //ensure it's a digit
                {   //we cannot accept another digit if
                    if (dotIndex != -1 &&  //there is already a dot and
                                           //dot is to the left from the cursor position and
                        dotIndex < txt_width.SelectionStart &&
                        //there're already 2 symbols to the right from the dot
                        txt_width.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else //we cannot accept this char if
                    e.Handled = e.KeyChar != '.' || //it's not a dot or
                                                    //there is already a dot in the text or
                                dotIndex != -1 ||
                                //text is empty or
                                txt_width.Text.Length == 0 ||
                                //there are more than 2 symbols from cursor position
                                //to the end of the text
                                txt_width.SelectionStart + 2 < txt_width.Text.Length;
            }
        }

        private void txt_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))  //bypass control keys
            {
                int dotIndex = txt_height.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))     //ensure it's a digit
                {   //we cannot accept another digit if
                    if (dotIndex != -1 &&  //there is already a dot and
                                           //dot is to the left from the cursor position and
                        dotIndex < txt_height.SelectionStart &&
                        //there're already 2 symbols to the right from the dot
                        txt_height.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else //we cannot accept this char if
                    e.Handled = e.KeyChar != '.' || //it's not a dot or
                                                    //there is already a dot in the text or
                                dotIndex != -1 ||
                                //text is empty or
                                txt_height.Text.Length == 0 ||
                                //there are more than 2 symbols from cursor position
                                //to the end of the text
                                txt_height.SelectionStart + 2 < txt_height.Text.Length;
            }
        }

        private void txt_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))  //bypass control keys
            {
                int dotIndex = txt_weight.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))     //ensure it's a digit
                {   //we cannot accept another digit if
                    if (dotIndex != -1 &&  //there is already a dot and
                                           //dot is to the left from the cursor position and
                        dotIndex < txt_weight.SelectionStart &&
                        //there're already 2 symbols to the right from the dot
                        txt_weight.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else //we cannot accept this char if
                    e.Handled = e.KeyChar != '.' || //it's not a dot or
                                                    //there is already a dot in the text or
                                dotIndex != -1 ||
                                //text is empty or
                                txt_weight.Text.Length == 0 ||
                                //there are more than 2 symbols from cursor position
                                //to the end of the text
                                txt_weight.SelectionStart + 2 < txt_weight.Text.Length;
            }
        }

        private void ShippingExpenseCalculator_Load(object sender, EventArgs e)
        {
            edeaccountEntities content = new edeaccountEntities();
            comboBox1.Items.Add("Envelope");
            comboBox1.Items.Add("Freight");
            comboBox2.Items.Add("Australia");
            comboBox2.Items.Add("Japan");
            comboBox2.Items.Add("China Shanghai");
            comboBox2.Items.Add("Hong Kong");

            String type = EditAirwayBillStaff.typeOfGoods;
            String country = EditAirwayBillStaff.destinatedCountry;
            comboBox1.SelectedIndex = comboBox1.FindStringExact(type);
            comboBox2.SelectedIndex = comboBox2.FindStringExact(country);
        }

        private void txt_weight_TextChanged(object sender, EventArgs e)
        {
            //if (txt_weight.Text == "")
            //{
            //    btn_calculate.Enabled = false;
            //}
            // else
            //{
            //    btn_calculate.Enabled = true;
            //}
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {

            //string myString = String.Empty;
            //double weight = Convert.ToDouble(txt_weight.Text);
            double doubleValue;
            //double width = double.Parse(txt_width.Text);
            //double height = Convert.ToDouble(txt_height.Text);
            //double length = Convert.ToDouble(txt_length.Text);
            double total = new double();
            double lastvalue = new double();


            if (txt_length.Text != "" && txt_width.Text != "" && txt_weight.Text != "" && txt_height.Text != "")
            {
                double weight = Convert.ToDouble(txt_weight.Text);
                double width = double.Parse(txt_width.Text);
                double length = Convert.ToDouble(txt_length.Text);
                double height = Convert.ToDouble(txt_height.Text);

                if (weight < 3 && width > 35 && length > 25 && comboBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("The size of EDE Express Document Envelope: 25cm(L) x 35cm(W).Please change your goods type to EXPRESS FREIGHT");
                }
                else if (weight < 0)
                {
                    MessageBox.Show("Weight cant be nagative number");
                }
                else if (weight == 0)
                {
                    MessageBox.Show("Weight cant be  0");
                }
                else if (width > 35 && length > 25 && weight < 3 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || width > 35 && length > 25 && weight < 3 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 75;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width > 35 && length > 25 && weight < 3 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 45;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width <= 35 && length <= 25 && weight <= 0.5 && comboBox1.SelectedIndex == 0)
                {
                    total = 158;
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width <= 35 && length <= 25 && weight > 0.5 && weight <= 1.0 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + 150;
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width <= 35 && length <= 25 && weight > 1.0 && weight <= 1.5 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 2);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width <= 35 && length <= 25 && weight > 1.5 && weight <= 2.0 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 3);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width <= 35 && length <= 25 && weight > 2.0 && weight <= 2.5 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 4);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width <= 35 && length <= 25 && weight > 2.5 && weight < 3 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 5);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }

                else if (width > 35 && length <= 25 && weight <= 0.5 && comboBox1.SelectedIndex == 0)
                {
                    total = 158;
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width > 35 && length <= 25 && weight > 0.5 && weight <= 1.0 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + 150;
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width > 35 && length <= 25 && weight > 1.0 && weight <= 1.5 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 2);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width > 35 && length <= 25 && weight > 1.5 && weight <= 2.0 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 3);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width > 35 && length <= 25 && weight > 2.0 && weight <= 2.5 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 4);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width > 35 && length <= 25 && weight > 2.5 && weight < 3 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 5);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }

                else if (width <= 35 && length > 25 && weight <= 0.5 && comboBox1.SelectedIndex == 0)
                {
                    total = 158;
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width <= 35 && length > 25 && weight > 0.5 && weight <= 1.0 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + 150;
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width <= 35 && length > 25 && weight > 1.0 && weight <= 1.5 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 2);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width <= 35 && length > 25 && weight > 1.5 && weight <= 2.0 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 3);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width <= 35 && length > 25 && weight > 2.0 && weight <= 2.5 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 4);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (width <= 35 && length > 25 && weight > 2.5 && weight < 3 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 5);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }


                else if (weight >= 3 && comboBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("Your weight is high or equal 3 . You should choose FREIGHT type of goods");
                }
                //else if (weight < 3 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight < 3 && comboBox2.SelectedIndex == 1 || weight < 3 && comboBox2.SelectedIndex == 2)
                //{
                //   MessageBox.Show("The weight is less than 3 the good of type should be Envelope");
                //    comboBox1.Focus();
                //}
                else if (width <= 35 && length <= 25 && weight >= 3 && weight <= 15 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || width <= 35 && length <= 25 && weight >= 3 && weight <= 15 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 75;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (weight > 15 && weight <= 29 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight > 15 && weight <= 29 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    total = 1125;
                    weight = weight - 15;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 70;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (weight > 29 && weight <= 44 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight > 29 && weight <= 44 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    total = 2105;
                    weight = weight - 29;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 65;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (weight > 44 && weight <= 69 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight > 44 && weight <= 69 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    total = 3080;
                    weight = weight - 44;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 62;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (weight > 69 && weight <= 99 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight > 69 && weight <= 99 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    total = 4630;
                    weight = weight - 69;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 61;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (weight > 99 && weight <= 999 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight > 99 && weight <= 999 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    total = 6460;
                    weight = weight - 99;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 58;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (weight >= 3 && weight <= 15 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 45;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (weight > 15 && weight <= 29 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    total = 675;
                    weight = weight - 15;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 40;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (weight > 29 && weight <= 44 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    total = 1235;
                    weight = weight - 29;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 37;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (weight > 44 && weight <= 69 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    total = 1790;
                    weight = weight - 44;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 35;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (weight > 69 && weight <= 99 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    total = 2665;
                    weight = weight - 69;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 33;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (weight > 99 && weight <= 999 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    total = 3655;
                    weight = weight - 99;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 32;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                    passValToNextForm(length, width, height, weight, total);
                }
                else if (length <= 25 && width <= 35 && weight > 0 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("You should select country in FREIGHT type of goods");
                }
                else if (weight > 0 && comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("You should select type of goods!");
                }
                else if (length <= 25 && width <= 35 && weight < 3 && comboBox1.SelectedIndex == 1)
                {
                    MessageBox.Show("Your goods weight is lower than 3 and your length and width is not higher than the size of Document Envelope ,You should select ENVELOPE type of goods!");
                }
                else if (length > 25 && width <= 35 && weight < 3 && comboBox1.SelectedIndex == 1)
                {
                    MessageBox.Show("Your goods weight is lower than 3 and your width is not higher than 35,You should select ENVELOPE type of goods!");
                }
                else if (length <= 25 && width > 35 && weight < 3 && comboBox1.SelectedIndex == 1)
                {
                    MessageBox.Show("Your goods weight is lower than 3 and your length is not higher than 25,You should select ENVELOPE type of goods!");
                }
                else if (length > 25 && width > 35 && weight < 3 && comboBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("Your length and width is higher than the Size of EDE Express Document Envelope,Please choose FREIGHT type of goods");
                }
                else if (length > 25 && width > 35 && weight < 3 && comboBox1.SelectedIndex == 1)
                {
                    MessageBox.Show("You should select country in FREIGHT type of goods");
                }



            }
            else if (txt_weight.Text != "")
            {

                double weight = Convert.ToDouble(txt_weight.Text);

                if (weight < 0)
                {
                    MessageBox.Show("Weight cant be nagative number");
                }
                else if (weight == 0)
                {
                    MessageBox.Show("Weight cant be  0");
                }
                else if (weight <= 0.5 && comboBox1.SelectedIndex == 0)
                {
                    total = 158;
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 0.5 && weight <= 1.0 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + 150;
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 1.0 && weight <= 1.5 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 2);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 1.5 && weight <= 2.0 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 3);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 2.0 && weight <= 2.5 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 4);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 2.5 && weight < 3 && comboBox1.SelectedIndex == 0)
                {
                    total = 158 + (150 * 5);
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight >= 3 && comboBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("Your weight is high or equal 3 . You should choose FREIGHT type of goods");
                }
                else if (weight < 3 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight < 3 && comboBox2.SelectedIndex == 1 || weight < 3 && comboBox2.SelectedIndex == 2)
                {
                    MessageBox.Show("The weight is less than 3 the good of type should be Envelope");
                    comboBox1.Focus();
                }
                else if (weight >= 3 && weight <= 15 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight >= 3 && weight <= 15 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 75;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 15 && weight <= 29 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight > 15 && weight <= 29 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    total = 1125;
                    weight = weight - 15;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 70;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 29 && weight <= 44 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight > 29 && weight <= 44 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    total = 2105;
                    weight = weight - 29;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 65;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 44 && weight <= 69 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight > 44 && weight <= 69 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    total = 3080;
                    weight = weight - 44;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 62;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 69 && weight <= 99 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight > 69 && weight <= 99 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    total = 4630;
                    weight = weight - 69;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 61;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 99 && weight <= 999 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 || weight > 99 && weight <= 999 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                {
                    total = 6460;
                    weight = weight - 99;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 58;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight >= 3 && weight <= 15 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 45;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 15 && weight <= 29 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    total = 675;
                    weight = weight - 15;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 40;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 29 && weight <= 44 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    total = 1235;
                    weight = weight - 29;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 37;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 44 && weight <= 69 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    total = 1790;
                    weight = weight - 44;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 35;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 69 && weight <= 99 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    total = 2665;
                    weight = weight - 69;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 33;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 99 && weight <= 999 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                {
                    total = 3655;
                    weight = weight - 99;
                    for (int i = 0; i < weight; i++)
                    {
                        weight = weight - 1;
                        i--;
                        total = total + 32;
                    }
                    MessageBox.Show("The Shipping Expense is $ " + total);
                }
                else if (weight > 0 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex != 1 || weight > 0 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex != 2 || weight > 0 && comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex != 3)
                {
                    MessageBox.Show("You should select country in FREIGHT type of goods");
                }
                else if (weight > 0 && comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("You should select type of goods!");
                }

            }
            else
            {
                MessageBox.Show("You should provide weight");
            }


        }
        public void passValToNextForm(double length, double width, double height, double weight, double total)
        {
            EditAirwayBillStaff.txtHeight.Text = Convert.ToString(height);
            EditAirwayBillStaff.txtLength.Text = Convert.ToString(length);
            EditAirwayBillStaff.txtWidth.Text = Convert.ToString(width);
            EditAirwayBillStaff.txtWeight.Text = txt_weight.Text;
            EditAirwayBillStaff.txtExpense.Text = Convert.ToString(total);
            this.Close();
            //this.DialogResult = DialogResult.OK;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void txt_height_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
