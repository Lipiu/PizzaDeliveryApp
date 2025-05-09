namespace PizzaDeliveryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] PizzaOptions = new string[]
            {
                "Pepperoni",
                "Pepperoni & Feta",
                "Margherita",
                "Diavola",
                "Spicy & Meat",
                "Quattro Stagioni",
                "American Spicy",
                "Quattro formaggi",
                "Veggie & Mozzarella"
            };

            comboBoxPizzaChoice.Items.AddRange(PizzaOptions);
            comboBoxPizzaChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPizzaChoice.MaxDropDownItems = 6;
        }

        private void comboBoxPizzaChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPizza = comboBoxPizzaChoice.SelectedItem.ToString();
            MessageBox.Show("You selected: " + selectedPizza);
        }
    }
}
