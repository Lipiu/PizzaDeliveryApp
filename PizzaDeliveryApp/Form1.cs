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
                "Pepperoni - 28 RON",
                "Pepperoni & Feta - 35 RON",
                "Margherita - 25 RON",
                "Diavola - 30 RON",
                "Spicy & Meaty - 40 RON",
                "Quattro Stagioni - 30 RON",
                "American Spicy - 35 RON",
                "Quattro formaggi - 36 RON",
                "Veggie & Mozzarella - 30 RON"
            };

            Array.Sort(PizzaOptions);
            comboBoxPizzaChoice.Items.AddRange(PizzaOptions);
            comboBoxPizzaChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPizzaChoice.Width = 255;
            comboBoxPizzaChoice.MaxDropDownItems = 6;
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
            if (checkBoxKetchup.Checked && comboBoxPizzaChoice.SelectedItem == null)
            {
                errorProvider1.SetError(checkBoxKetchup, "Ketchup with no pizza? Ok weirdo.");
            }
            else if(checkBoxKetchup.Checked && comboBoxPizzaChoice.SelectedItem != null)
            {
                checkBoxSpicy.Visible = true;
            }
            else
            {
                checkBoxSpicy.Visible = false;
                checkBoxSpicy.Checked = false;
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
            if(comboBoxPizzaChoice.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxPizzaChoice, "Please select a pizza or just say you hate me.");
            }
            else
            {
                Form2 checkoutForm = new Form2();
                errorProvider1.SetError(comboBoxPizzaChoice, "");
                MessageBox.Show("Proceeding to checkout...");
                checkoutForm.ShowDialog();
            }
        }
    }
}
