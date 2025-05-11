using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryApp
{
    internal class Address
    {
        public string fullAddress {  get; set; }

        public Address() { }
        public Address(string FullAddress)
        {
            this.fullAddress = FullAddress;
        }
    }
}
