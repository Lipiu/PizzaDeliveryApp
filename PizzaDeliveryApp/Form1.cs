namespace PizzaDeliveryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] PizzaOptions = new string[]
            {
                "Pepperoni - 30 RON",
                "Pepperoni & Feta - 35 RON",
                "Margherita - 25 RON",
                "Diavola - 30 RON",
                "Spicy & Meaty - 40 RON",
                "Quattro Stagioni - 30 RON",
                "Quattro Formaggi - 36 RON",
                "American Spicy - 35 RON",
                "Veggie & Mozzarella - 30 RON",
                "Prosciutto e Funghi - 28 RON"
            };

            //sorting alphabetically
            Array.Sort(PizzaOptions);
            comboBoxPizzaChoice.Items.AddRange(PizzaOptions);

            comboBoxPizzaChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPizzaChoice.Width = 255;
        }

        private void comboBoxPizzaChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey, stop clicking me!\nOrder some pizza instead!🍕");
        }

        private void checkBoxKetchup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKetchup.Checked)
            {
                checkBoxNoKetchup.Checked = false;
                checkBoxSpicy.Visible = true;
                checkBoxSpicy.Enabled = true;

                if (checkBoxKetchup.Checked && comboBoxPizzaChoice.SelectedItem == null)
                {
                    errorProvider1.SetError(checkBoxKetchup, "Ketchup with no pizza? Ok weirdo.");

                }
                else if (checkBoxKetchup.Checked && comboBoxPizzaChoice.SelectedItem != null)
                {
                    checkBoxSpicy.Visible = true;
                }
                else
                {
                    checkBoxSpicy.Visible = false;
                    checkBoxSpicy.Checked = false;
                    checkBoxSpicy.Enabled = false;
                }
            }

        }

        private void checkBoxSpicy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxPizzaChoice.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxPizzaChoice, "Please select a pizza or just say you hate me.");
            }
            else
            {
                Pizza pizza = new Pizza();
                pizza.TypeOfPizza = comboBoxPizzaChoice.Text;
                pizza.HasKetchup = checkBoxKetchup.Checked;
                pizza.SpicyKetchup = checkBoxSpicy.Checked;
                Form2 checkoutForm = new Form2(pizza);
                errorProvider1.SetError(comboBoxPizzaChoice, "");
                MessageBox.Show("Proceeding to checkout...");
                checkoutForm.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoKetchup.Checked)
            {
                checkBoxKetchup.Checked = false;
                checkBoxSpicy.Checked = false;
                checkBoxSpicy.Enabled = false;

                if (comboBoxPizzaChoice.SelectedItem == null)
                {
                    errorProvider1.SetError(comboBoxPizzaChoice, "Please select a pizza or just say you hate me.");
                }
                else
                {
                    errorProvider1.SetError(comboBoxPizzaChoice, "");
                }
            }
        }
    }
}
