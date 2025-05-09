using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryApp
{
    internal class Client
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string ClientId { get; set; }
        public static int NumberOfClients;

        public Client() {
            NumberOfClients += 1;
        }

        public Client(string firstName, string lastName, string phoneNumber, string clientId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.ClientId = clientId;

            NumberOfClients += 1;
        }
    }
}
