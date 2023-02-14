using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Analise a seguinte informação:
Em um jogo, existe um posto que está vendendo combustíveis com a seguinte tabela de descontos:

Álcool
até 20 litros (inclusive 20 litros), desconto de 2% por litro
acima de 20 litros, desconto de 5% por litro

Gasolina
até 20 litros (inclusive 20 litros), desconto de 3% por litro
acima de 20 litros, desconto de 6% por litro

Após à análise, faça um programa que leia o número de litros vendidos e o tipo de combustível 
(codificado da seguinte forma: 1-álcool, 2-gasolina), calcule e imprima o valor
a ser pago pelo jogador, sabendo-se que o preço do litro da gasolina é R$ 5.00
e o preço do litro do álcool é R$ 3.50*/

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double qtdLitro, preco;             //qtdLitro=quantidade de litros foi=verifica se converteu
            int Ga;                             //Ga=gasolina ou alcool preco=preço a pagar
            bool foi;

            Console.WriteLine("Alcool e Gasolina responda 1 para alcool e 2 para gasolina");

            do
            {

                foi = int.TryParse(Console.ReadLine(),out Ga);

            } while (!foi || (Ga!=1 && Ga!=2));

            Console.WriteLine("quantos litros");
            qtdLitro=Double.Parse(Console.ReadLine());

            if (qtdLitro >= 20)
            {
                if (Ga == 1) preco = 3.325 * qtdLitro;
                else preco = 4.70 * qtdLitro;
            }
            else
            {
                if (Ga == 1) preco = 3.43 * qtdLitro;
                else preco = 4.85 * qtdLitro;
            }
            Console.WriteLine($"o preço a se pagar é de {preco}");

            Console.ReadKey();

            
            
            
        }
    }
}
