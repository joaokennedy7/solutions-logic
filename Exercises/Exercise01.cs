using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace solutions
{
    public class Exercise01
    {

        public void Exercise1()
        {
            /*Faça um programa que receba dois números inteiros e gere os números inteiros que estão no intervalo compreendido por eles.
              Altere o programa anterior para mostrar no final a soma dos números.*/

            Console.WriteLine("Digite um número:");
            var numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            var numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Os números entre {numero1} e {numero2}");
            int soma = 0;

            if (numero1 < numero2)
            {
                for (int i = numero1 + 1; i < numero2; i++)
                {
                    Console.WriteLine(i + " ");
                    soma += i;

                }
            }
            else if (numero1 > numero2)
            {
                for (int i = numero2 + 1; i < numero1; i++)
                {
                    Console.WriteLine(i + " ");
                    soma += i;

                }
            }

            Console.Write($"A soma é {soma}");
        }
    }
}