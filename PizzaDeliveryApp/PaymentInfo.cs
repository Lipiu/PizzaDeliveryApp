using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryApp
{
    public class PaymentInfo
    {
        public string CardHolder {  get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpireDate { get; set; }
        public string CVV { get; set; }

        public PaymentInfo() { }

        public PaymentInfo(string cardHolder, string cardNumber, DateTime expireDate, string cvv)
        {
            this.CardHolder = cardHolder;
            this.CardNumber = cardNumber;
            this.ExpireDate = expireDate;
            this.CVV = cvv;
        }
    }
}
