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

        //default constructor
        public Pizza() {
        }

        //constructor with parameters
        public Pizza(string typeOfPizza, bool hasKetchup, bool spicyKetchup, string pizzaSize)
        {
            TypeOfPizza = typeOfPizza;
            HasKetchup = hasKetchup;
            SpicyKetchup = spicyKetchup;
            PizzaSize = pizzaSize;
        }
    }
}
