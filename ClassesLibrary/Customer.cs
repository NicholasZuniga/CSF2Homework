using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInfo { get; set; }

        public Customer(string customerID, string firstName, string lastName,ContactInfo contactInfo)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInfo = contactInfo;
        }
        public override string ToString()
        {
            return string.Format("\nFirstname: {1}\t\tLastname: {2}\nCustomer ID: {3}\n{0}",
            ContactInfo.ToString(),
            FirstName,
            LastName,
            CustomerID);

        }
    }
}
