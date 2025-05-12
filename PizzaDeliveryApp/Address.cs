using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryApp
{
    public class Address
    {
        public string FullAddress {  get; set; }

        public Address() { }
        public Address(string fullAddress)
        {
            this.FullAddress = fullAddress;
        }
    }
}
