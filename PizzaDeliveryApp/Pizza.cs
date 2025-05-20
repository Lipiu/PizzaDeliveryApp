using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryApp
{
    public class Pizza
    {
        public string TypeOfPizza {  get; set; }
        public bool HasKetchup {  get; set; }
        public bool SpicyKetchup { get; set; }
        public string PizzaSize { get; set; }
        public int Quantity { get; set; }
        public static int NumberOfOrders; // to keep track of orders

        //default constructor
        public Pizza() {
            NumberOfOrders += 1;
        }

        //constructor with parameters
        public Pizza(string typeOfPizza, bool hasKetchup, bool spicyKetchup, string pizzaSize, int quantity)
        {
            TypeOfPizza = typeOfPizza;
            HasKetchup = hasKetchup;
            SpicyKetchup = spicyKetchup;
            PizzaSize = pizzaSize;
            Quantity = quantity;
            NumberOfOrders += 1;
        }
    }
}
