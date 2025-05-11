using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDeliveryApp
{
    public partial class Form2 : Form
    {
        public Form2(Pizza pizza)
        {
            InitializeComponent();
            this.pizza = pizza;
            errorProvider1 = new ErrorProvider();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            //validating name
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                errorProvider1.SetError(textBoxName, "Enter your name please!");
                textBoxName.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBoxName, "");
            }

            //validating phone number
            if (string.IsNullOrEmpty(textBoxPhoneNumber.Text))
            {
                errorProvider1.SetError(textBoxPhoneNumber, "Please enter phone number!"); //checking if phone number field is empty
                textBoxPhoneNumber.Focus();
                return;
            }
            else if (textBoxPhoneNumber.Text.Length != 10)
            {
                errorProvider1.SetError(textBoxPhoneNumber, "Phone number must have only 10 digits!"); //checking if phone number has exactly 10 digits
                textBoxPhoneNumber.Focus();
                return;
            }
            else if (!textBoxPhoneNumber.Text.All(char.IsDigit))
            {
                errorProvider1.SetError(textBoxPhoneNumber, "Phone number must contain only digits!"); //checking if phone number filed contains any characters that are not digits
                textBoxPhoneNumber.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBoxPhoneNumber, "");
            }

            //validating address
            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                errorProvider1.SetError(textBoxAddress, "Please enter address!");
                textBoxAddress.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBoxAddress, "");
            }

            //validation for card payment info
            if (!checkBoxCard.Checked && !checkBoxCash.Checked) //checking if the customer selected a payment method
            {
                errorProvider1.SetError(checkBoxCard, "Please select payment method!");
                return;
            }
            else
            {
                errorProvider1.SetError(checkBoxCard, "");
            }

            //if card payment method is selected
            if (checkBoxCard.Checked)
            {
                //validating card holder
                if (string.IsNullOrEmpty(textBoxCardHolder.Text))
                {
                    errorProvider1.SetError(textBoxCardHolder, "Please enter name of card holder!");
                    textBoxCardHolder.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(textBoxCardHolder, "");
                }

                //validating card number
                if (string.IsNullOrEmpty(textBoxCardNumber.Text)) //checking if the field is empty
                {
                    errorProvider1.SetError(textBoxCardNumber, "Card number cannot be empty!");
                    textBoxCardNumber.Focus();
                    return;
                }
                else if (textBoxCardNumber.Text.Length != 16) //checking if the card is exactly 16 digits long
                {
                    errorProvider1.SetError(textBoxCardNumber, "Card number must be exactly 16 digits!");
                    textBoxCardNumber.Focus();
                    return;
                }
                else if (!textBoxCardNumber.Text.All(char.IsDigit)) //checking if the card contains any characters that are not digits
                {
                    errorProvider1.SetError(textBoxCardNumber, "Card number must contain only digits!");
                    textBoxCardNumber.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(textBoxCardNumber, "");
                }

                //validating expiring date
                string expiringDateText = textBoxExpDate.Text.Trim();
                if (!Regex.IsMatch(expiringDateText, @"^(0[1-9]|1[0-2])\/\d{2}$"))
                {
                    errorProvider1.SetError(textBoxExpDate, "Expiration date must be in MM/YY format.");
                    textBoxExpDate.Focus();
                    return;
                }
                else
                {
                    string[] parts = expiringDateText.Split('/');
                    int month = int.Parse(parts[0]);
                    int year = int.Parse(parts[1]) + 2000;

                    DateTime expDate = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);
                    if (expDate < DateTime.Now)
                    {
                        errorProvider1.SetError(textBoxExpDate, "Card is expired.");
                        textBoxExpDate.Focus();
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(textBoxExpDate, "");
                    }
                }

                //validating CVV
                if (textBoxCvv.Text.Length != 3)
                {
                    errorProvider1.SetError(textBoxCvv, "Invalid CVV!");
                    textBoxCvv.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(textBoxCvv, "");
                }
            }


            //if all fields are valid display message
            MessageBox.Show("Order placed sucessfully!\nThank you and enjoy your pizza!!");

            string[] nameParts = textBoxName.Text.Trim().Split(' ');
            string firstName = nameParts[0];
            string lastName = "";
            if (nameParts.Length > 1)
            {
                lastName = nameParts[1];
            }

            //Create client
            Client client = new Client();
            client.FirstName = firstName;
            client.LastName = lastName;
            client.PhoneNumber = textBoxPhoneNumber.Text;

            //Create address
            Address address = new Address();
            address.fullAddress = textBoxAddress.Text;
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCard_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCard.Checked)
            {
                labelCardHolder.Visible = true;
                textBoxCardHolder.Visible = true;

                labelCardNumber.Visible = true;
                textBoxCardNumber.Visible = true;

                labelExpDate.Visible = true;
                textBoxExpDate.Visible = true;

                labelCvv.Visible = true;
                textBoxCvv.Visible = true;

                checkBoxCash.Enabled = false;
            }
            else
            {
                labelCardHolder.Visible = false;
                textBoxCardHolder.Visible = false;

                labelCardNumber.Visible = false;
                textBoxCardNumber.Visible = false;

                labelExpDate.Visible = false;
                textBoxExpDate.Visible = false;

                labelCvv.Visible = false;
                textBoxCvv.Visible = false;

                checkBoxCash.Enabled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelCardHolder.Visible = false;
            textBoxCardHolder.Visible = false;

            labelCardNumber.Visible = false;
            textBoxCardNumber.Visible = false;

            labelExpDate.Visible = false;
            textBoxExpDate.Visible = false;

            labelCvv.Visible = false;
            textBoxCvv.Visible = false;
        }

        private void labelExpDate_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxCash_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCash.Checked == true)
            {
                checkBoxCard.Enabled = false;
            }
            else
            {
                checkBoxCard.Enabled = true;
            }
        }
    }
}
