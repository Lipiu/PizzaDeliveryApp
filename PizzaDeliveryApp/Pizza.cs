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
        public string SizeOfPizza { get; set; }
        public bool HasKetchup {  get; set; }
        public bool SpicyKetchup { get; set; }
        public static int NumberOfOrders; // to keep track of orders

        //default constructor
        public Pizza() {
            NumberOfOrders += 1;
        }

        //constructor with parameters
        public Pizza(string typeOfPizza, string sizeOfPizza, bool hasKetchup, bool spicyKetchup)
        {
            TypeOfPizza = typeOfPizza;
            SizeOfPizza = sizeOfPizza;
            HasKetchup = hasKetchup;
            SpicyKetchup = spicyKetchup;
            NumberOfOrders += 1;
        }
    }
}
