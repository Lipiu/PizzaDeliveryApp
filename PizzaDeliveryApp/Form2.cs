using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDeliveryApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
                errorProvider1.SetError(textBoxPhoneNumber, "Please enter phone number!");
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

            //validating payment method
            if (string.IsNullOrEmpty(textBoxPayment.Text))
            {
                errorProvider1.SetError(textBoxPayment, "Please enter payment method!");
                textBoxPayment.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBoxPayment, "");
            }

            //if all fields are valid display message
            MessageBox.Show("Order placed sucessfully!");
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
    }
}
