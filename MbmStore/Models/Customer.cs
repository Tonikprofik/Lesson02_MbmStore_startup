using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        //field
        private DateTime birthDate;
        //props
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate {
            set
            {
                if (CalculateAge(value) > 140 || CalculateAge(value) <0)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    birthDate = value;
                }
            }
            get { return birthDate; }
        }
    
        public int CalculateAge(DateTime dateBirth)
        {
           // code inside the get block of the Age property
            DateTime now = DateTime.Now;
            int age;
            age = now.Year - dateBirth.Year;
            // calculate to see if the customer hasn’t had her birthday yet
            // subtract one year if that is so
            if (now.Month < dateBirth.Month ||
             (now.Month == dateBirth.Month && now.Day < dateBirth.Day))
            {
                age--;
            }
            return age;

        }
        public List<string> PhoneNumbers { get; } = new List<string>();
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();
        public void AddPhone(string phone)
        {
            PhoneNumbers.Add(phone);
        }
        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }

        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        public Customer(string firstName, string lastName, string address
            , string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
           
            Address = address;
            Zip = zip;
            City = city;

            

        }

    }
}
