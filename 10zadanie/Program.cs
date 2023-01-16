using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10zadanie
{
    class zadanie10
    {
        static void Main()
        {
            Console.WriteLine("Ввести первое число");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввести второе число");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine( a + b );
            Console.WriteLine( a - b );
            Console.ReadKey();
        }
    }
}
