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

        }
    }
}
