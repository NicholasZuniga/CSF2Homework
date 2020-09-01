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

        }
    }
}
