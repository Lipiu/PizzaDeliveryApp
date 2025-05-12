using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryApp
{
    public class OrderData
    {
        public Pizza Pizza {  get; set; }
        public Client Client { get; set; }
        public Address Address { get; set; }
        public PaymentInfo PaymentInfo { get; set; }
    }
}
