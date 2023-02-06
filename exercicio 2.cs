using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Faça um programa que solicite a idade de várias pessoas e mostre:
• Total de pessoas com menos de 21 anos.
• Total de pessoas com mais de 50 anos.
• A média de idade das pessoas.
Importante: O programa termina quando a idade informada for -1 (Menos 1)*/

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n=0, v=0, m=0, i, t=0, p=0;  //n=mais novo q 21 v=mais velho q 50 m=media i=idade
                                                //t=total de idade p= total de pessoas

            Console.WriteLine("digite a idade quando quiser parar digite -1");

            do
            {

                i = Double.Parse(Console.ReadLine());

                if (i < 0) continue;
                else {
                    t = t + i;
                    p++;
                    if (i < 21) n++;
                    else if (i > 50) v++;
                }
            } while (i != -1);

            m = t / p;

            Console.WriteLine($"Foi coletada a idade de {p}");
            Console.WriteLine($"a media da idade dessas pessoas eh {m:0.00}");
            Console.WriteLine($"A quantidade de pessoas com mais de 50 anos eh {v}");
            Console.WriteLine($"A quantidade de pessoas com menos de 21 anos eh {n}");

            Console.ReadKey();

            
            
            
        }
    }
}
