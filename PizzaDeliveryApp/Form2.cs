using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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
            if (checkBoxCash.Checked == true)
            {
                checkBoxCard.Enabled = false;
            }
            else
            {
                checkBoxCard.Enabled = true;
            }
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create client
            Client client = new Client();
            client.FullName = textBoxName.Text.Trim();
            client.PhoneNumber = textBoxPhoneNumber.Text;

            //Payment info
            PaymentInfo pay = null;
            if (checkBoxCard.Checked)
            {
                pay = new PaymentInfo();
                pay.CardHolder = textBoxCardHolder.Text;
                pay.CardNumber = textBoxCardNumber.Text;
                pay.ExpireDate = DateTime.Now;
                pay.CVV = textBoxCvv.Text;
            }

            //Create address
            Address address = new Address();
            address.FullAddress = textBoxAddress.Text;

            var orderData = new OrderData
            {
                Pizza = pizza,
                Client = client,
                Address = address,
                PaymentInfo = pay
            };

            var json = JsonSerializer.Serialize(orderData);
            using (StreamWriter sw = new StreamWriter(File.Create("OrderDetails.json")))
            {
                sw.WriteLine(json);
            }
            MessageBox.Show("Order details file created successfully!");

        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("OrderDetails.json"))
            {
                using (StreamReader sr = new StreamReader(File.OpenRead("OrderDetails.json")))
                {
                    try
                    {
                        var json = sr.ReadToEnd();
                        OrderData order = JsonSerializer.Deserialize<OrderData>(json);

                        textBoxName.Text = order.Client.FullName;
                        textBoxPhoneNumber.Text = order.Client.PhoneNumber;
                        textBoxAddress.Text = order.Address.FullAddress;

                        if (order.PaymentInfo != null)
                        {
                            checkBoxCard.Checked = true;
                            textBoxCardHolder.Text = order.PaymentInfo.CardHolder;
                            textBoxCardNumber.Text = order.PaymentInfo.CardNumber;
                            textBoxExpDate.Text = order.PaymentInfo.ExpireDate.ToString("MM/yy");
                            textBoxCvv.Text = order.PaymentInfo.CVV;
                        }
                        else
                        {
                            checkBoxCash.Checked = true;
                        }

                        MessageBox.Show("Order details deserialized successfully!");
                    }
                    catch (JsonException)
                    {
                        MessageBox.Show("Error while deserializing order data!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No saved order found!");
            }

        }

        private void serializeXML_Click(object sender, EventArgs e)
        {
            OrderData orderData = new OrderData();
            orderData.Client = new Client()
            {
                FullName = textBoxName.Text,
                PhoneNumber = textBoxPhoneNumber.Text
            };

            if (checkBoxCard.Checked)
            {
                orderData.PaymentMethod = "Card";
                orderData.PaymentInfo = new PaymentInfo()
                {
                    CardHolder = textBoxCardHolder.Text,
                    CardNumber = textBoxCardNumber.Text,
                    ExpireDate = DateTime.Parse(textBoxExpDate.Text),
                    CVV = textBoxCvv.Text
                };
            }
            else if (checkBoxCash.Checked)
            {
                orderData.PaymentMethod = "Cash";
                orderData.PaymentInfo = null;
            }

            orderData.Address = new Address()
            {
                FullAddress = textBoxAddress.Text
            };
            XmlSerializer serializer = new XmlSerializer(typeof(OrderData));
            using (FileStream stream = File.Create("SerializedOrderXML.xml"))
            {
                serializer.Serialize(stream, orderData);
            }
            MessageBox.Show("Order serialized to XML!");
        }

        private void deserializeXML_Click(object sender, EventArgs e)
        {
            if (File.Exists("SerializedOrderXML.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(OrderData));
                using (FileStream stream = File.OpenRead("SerializedOrderXML.xml"))
                {
                    OrderData orderData = (OrderData)serializer.Deserialize(stream);
                    textBoxName.Text = orderData.Client.FullName;
                    textBoxPhoneNumber.Text = orderData.Client.PhoneNumber;
                    textBoxAddress.Text = orderData.Address.FullAddress;

                    if (orderData.PaymentMethod == "Card")
                    {
                        checkBoxCard.Checked = true;
                        textBoxCardHolder.Text = orderData.PaymentInfo.CardHolder;
                        textBoxCardNumber.Text = orderData.PaymentInfo.CardNumber;
                        textBoxExpDate.Text = orderData.PaymentInfo.ExpireDate.ToString("MM/yy");
                        textBoxCvv.Text = orderData.PaymentInfo.CVV;
                    }
                    else
                    {
                        checkBoxCash.Checked = true;
                        checkBoxCard.Checked = false;
                    }
                    MessageBox.Show("Order deserialized from XML!");
                }
            }
            else
            {
                MessageBox.Show("No saved order found!");
            }
        }

        private void exportToTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = File.CreateText(saveFileDialog.FileName))
                {
                    OrderData order = new OrderData();
                    order.Client = new Client()
                    {
                        FullName = textBoxName.Text.Trim(),
                        PhoneNumber = textBoxPhoneNumber.Text
                    };

                    if (checkBoxCard.Checked)
                    {
                        order.PaymentMethod = "Card";
                        order.PaymentInfo = new PaymentInfo()
                        {
                            CardHolder = textBoxCardHolder.Text,
                            CardNumber = textBoxCardNumber.Text,
                            ExpireDate = DateTime.Parse(textBoxExpDate.Text),
                            CVV = textBoxCvv.Text
                        };
                    }
                    else
                    {
                        order.PaymentMethod = "Cash";
                        order.PaymentInfo = null;
                    }

                    order.Address = new Address()
                    {
                        FullAddress = textBoxAddress.Text
                    };

                    sw.WriteLine("Full name: " + order.Client.FullName);
                    sw.WriteLine("Phone number: " + order.Client.PhoneNumber);
                    sw.WriteLine("Address: " + order.Address.FullAddress);
                    sw.WriteLine("Payment method: " + order.PaymentMethod);

                    if (order.PaymentInfo != null)
                    {
                        sw.WriteLine("Card holder: " + order.PaymentInfo.CardHolder);
                        sw.WriteLine("Card number: " + order.PaymentInfo.CardNumber);
                        sw.WriteLine("Expiration date: " + order.PaymentInfo.ExpireDate.ToString("MM/yy"));
                    }
                    else
                    {
                        sw.WriteLine("Card holder: N/A");
                        sw.WriteLine("Card number: N/A");
                        sw.WriteLine("Expiration date: N/A");
                    }

                    MessageBox.Show($"Order details exported to {saveFileDialog.FileName}");
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutText = "- This is the checkout form!\n" +
                "- Support for JSON serialization and deserialization\n" +
                "- Support for shortcuts:\n" +
                "    -> CTRL+S - Serialization JSON\n" +
                "    -> CTRL+D - Deserialization JSON\n" +
                "- Support for XML serialization and deserialization\n" +
                "    -> CTRL+SHIFT+S - Serialization XML\n" +
                "    -> CTRL+SHIFT+D - Deserialization XML\n" +
                "- Option to export order to text file\n" +
                "    -> CTRL+T - Export to text file";

            MessageBox.Show(aboutText, "About pizzaDeliveryApp");
        }
    }
}
