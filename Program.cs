using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio1_Senai
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Efetue a leitura de quatro valores numericos inteiros
             * e apresente o resultado dois a dois das adicoes e mult
             * de forma distributiva.ou seja, se forem as variaveis 
             * a,b,c,d.Faça a distributiva de cada variavel.
             */

            int a, b, c, d, dista , distb, distc, distd;
            Console.Write("Digite o 1º número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º número: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o 3º número: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Digite o 4º número: ");
            d = int.Parse(Console.ReadLine());
            dista = a * b + a * c + a * d;
            distb = b * a + b * c + b * d;
            distc = c * a + c * b + c * d;
            distd = d * a + d * b + d * c;
            Console.WriteLine("Distributiva de A: " + dista);
            Console.WriteLine("Distributiva de B: " + distb);
            Console.WriteLine("Distributiva de C: " + distc);
            Console.WriteLine("Distributiva de D: " + distd);

            Console.WriteLine();
            Console.Write("Tecla <enter>");
            Console.ReadLine();
        }   
    }
}
