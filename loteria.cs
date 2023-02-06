using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = new int[6];
            Random roleta= new Random();
            int temp, i;

            for (i = 0; i < 6; i++)
            {
                temp = roleta.Next(1,61);
                if (result.Contains(temp)) i--;

                else result[i] = temp;
            }

            for (i = 0; i < 6; i++) Console.Write($"{result[i]} ");

            Console.ReadKey();

            
            
            
        }
    }
}
