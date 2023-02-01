using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1
{
    internal class Program
    {
        static void Main()
        {
            int n, i;

            n = Convert.ToInt32(Console.ReadLine());
            
            for(i=0; i<=10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
                
            }

            Console.ReadKey();
        }
    }
}
