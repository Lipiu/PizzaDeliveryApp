using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryApp
{
    internal class Address
    {
        public string CityName { get; set; }
        public string StreetName { get; set; }
        public int AppartmentNumber { get; set; }
        public int FloorNumber { get; set; }

        public Address() { }
        public Address(string cityName, string streetName, int appartmentNumber, int floorNumber)
        {
            CityName = cityName;
            StreetName = streetName;
            AppartmentNumber = appartmentNumber;
            FloorNumber = floorNumber;
        }
    }
}
