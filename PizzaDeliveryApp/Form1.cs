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
                "Spicy & Meat - 40 RON",
                "Quattro Stagioni - 30 RON",
                "American Spicy - 35 RON",
                "Quattro formaggi - 36 RON",
                "Veggie & Mozzarella - 30 RON"
            };

            comboBoxPizzaChoice.Items.AddRange(PizzaOptions);
            comboBoxPizzaChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPizzaChoice.Width = 240;
            comboBoxPizzaChoice.MaxDropDownItems = 6;
        }

        private void comboBoxPizzaChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPizza = comboBoxPizzaChoice.SelectedItem.ToString();

            if (selectedPizza == null)
            {
                errorProvider1.SetError(comboBoxPizzaChoice, "Please select a pizza. Don't you like anything?😭");
            }
            else
            {
                errorProvider1.SetError(comboBoxPizzaChoice, "");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey, stop clicking me!\nOrder some pizza instead🍕");
        }

        private void checkBoxKetchup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKetchup.Checked)
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
    }
}
