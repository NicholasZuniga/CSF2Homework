using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class DataTypeHarness
    {
        static void Main(string[] args)
        {
            Students s1 = new Students("Emily", "Briggs", "1001", 3.2f);

            Console.WriteLine(s1);

            Vehicle v1 = new Vehicle("Toyata", "Hatchback", 2010, 2900);

            Console.WriteLine(v1);

            Login l1 = new Login("bunnyH0ps", "ChimkenNuggetz");

            Console.WriteLine(l1);

            ContactInfo c1 = new ContactInfo("3100 Dependent Street", "Kansas City", "Kansas", "66109", "837-384-7734", "TotallyARealEmail@email.com");

            Console.WriteLine(c1);

            Customer cus1 = new Customer("CD8887", "John", "Briggs","2304 Dolphin Way", "Lipsy City", "Kansas", "39878", "873-475-3333", "Dontemailme@email.com");

            Console.WriteLine(cus1);

        }
    }
}
