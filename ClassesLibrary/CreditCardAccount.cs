using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }
        public Customer Customer { get; set; }

        public CreditCardAccount(int accountNumber, Customer customer, decimal balance, bool isPastDue, decimal annualIntrestRate)
        {
            AccountNumber = accountNumber;
            Customer = customer;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualIntrestRate;

        }

        public override string ToString()
        {
            return string.Format("Account Number: {0}\n {1}\nBalance: {2:c}\nIs Past Due: {3}\nAnnual Interest Rate: {4}%",
                AccountNumber,
                Customer.ToString(),
                Balance,
                IsPastDue,
                AnnualInterestRate);
        }

    }
}
