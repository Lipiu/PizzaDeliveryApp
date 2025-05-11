using System.Text.Json;

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
                "Pepperoni - 40 RON",
                "Pepperoni & Feta - 45 RON",
                "Margherita - 35 RON",
                "Diavola - 38 RON",
                "Spicy & Meaty - 50 RON",
                "Quattro Stagioni - 35 RON",
                "Quattro Formaggi - 38 RON",
                "American Spicy - 45 RON",
                "Veggie & Mozzarella - 30 RON",
                "Prosciutto e Funghi - 30 RON"
            };

            //sorting alphabetically
            Array.Sort(PizzaOptions);
            comboBoxPizzaChoice.Items.AddRange(PizzaOptions);

            comboBoxPizzaChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPizzaChoice.Width = 300;
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

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pizza = new Pizza();
            pizza.TypeOfPizza = comboBoxPizzaChoice.Text;
            pizza.HasKetchup = checkBoxKetchup.Checked;
            pizza.SpicyKetchup = checkBoxSpicy.Checked;

            var json = JsonSerializer.Serialize(pizza);
            using (StreamWriter sw = new StreamWriter(File.Create("PizzaOrder.json")))
            {
                sw.WriteLine(json);
            }
            MessageBox.Show("Pizza order serialized successfully!");
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("pizzaOrder.json"))
            {
                using (StreamReader sr = new StreamReader(File.OpenRead("PizzaOrder.json")))
                {
                    try
                    {
                        var json = sr.ReadToEnd();
                        Pizza pizza = JsonSerializer.Deserialize<Pizza>(json);
                        comboBoxPizzaChoice.SelectedItem = pizza.TypeOfPizza;
                        checkBoxKetchup.Checked = pizza.HasKetchup;
                        checkBoxSpicy.Checked = pizza.SpicyKetchup;

                        MessageBox.Show("Pizza order deserialized!");
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show("Error while deserializing!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No saved pizza orders found!");
            }
        }

        private void aboutAppToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutText = "This app allows people to order pizza with optional ketchup (spicy/not spicy)\n" +
                "Support for serialization and deserialization";

            MessageBox.Show(aboutText, "About pizzaDeliveryApp");
        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutText = "All pizzas have the same size (Large, 40cm)\n" +
                               "Very tasty!";

            MessageBox.Show(aboutText, "About pizzaDeliveryApp");
        }

        private void jSONSERIALIZATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
