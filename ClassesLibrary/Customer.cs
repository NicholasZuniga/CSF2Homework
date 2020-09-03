using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer: ContactInfo
    {
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(string customerID, string firstName, string lastName,string streetAddress, string city, string state,string zip, string phone, string email) :base(streetAddress,city,state,zip,phone,email)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return string.Format("\nFirstname: {1}\t\tLastname: {2}\nCustomer ID: {3}\n{0}",
            base.ToString(),
            FirstName,
            LastName,
            CustomerID);

        }
    }
}
