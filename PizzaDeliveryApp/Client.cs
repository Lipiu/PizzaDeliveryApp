using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryApp
{
    public class Client
    {
        public string FullName {  get; set; }
        public string PhoneNumber { get; set; }
        public string ClientId { get; set; }
        public static int NumberOfClients;

        public Client() {
            NumberOfClients += 1;
        }

        public Client(string fullName, string phoneNumber, string clientId)
        {
            this.FullName = fullName;
            this.PhoneNumber = phoneNumber;
            this.ClientId = clientId;

            NumberOfClients += 1;
        }
    }
}
