using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> PhoneNumbers { get; } = new List<string>();
        public void AddPhone(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        public Customer(string firstName, string lastName,string phoneNumbers, string address
            , string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumbers = phoneNumbers;
            Address = address;
            Zip = zip;
            City = city;

            

        }

    }
}
