 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*exercicio Faça um programa que leia 5 números inteiros informados pelo usuário 
 * e no final, mostre o maior número e, também, a soma deles.*/

namespace ex_1
{
    internal class Program
    {
        static void Main()
        {
            int a, m=0, t=0, i; //a=numero atual m=maior numero t=total i=indice

            Console.WriteLine("digite 5 numeros");


            for (i = 1; i < 6; i++)
            {
                Console.Write($"{i}°:");
                a = Convert.ToInt32(Console.ReadLine());

                if (i == 1) m = a;
                if (a > m) m = a;
                t = t + a;

            }
            Console.WriteLine($"o maior numero eh: {m}\na soma de todos eh: {t}");

            Console.ReadKey();
        }
    }
}
