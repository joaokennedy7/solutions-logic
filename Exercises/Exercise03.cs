using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutions
{
    public class Exercise03
    {

        public void Exercise3()
        {

            /* Faça um programa que peça dois números, base e expoente, calcule e mostre o primeiro número elevado ao segundo número.Não utilize a função de potência da linguagem.*/

            Console.Write("Digite o valor base: ");
            var valorBase = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do expoente: ");
            var valorExpoente = Convert.ToInt32(Console.ReadLine());

            int resultado = Expoente(valorBase, valorExpoente);

            Console.WriteLine($"O valor do base {valorBase} e {valorExpoente} tem o resultado {resultado}");
        }

        public int Expoente(int valorBase, int valorExpoente)
        {
            var resultado = 1;

            for (int i = 1; i <= valorExpoente; i++)
            {
                resultado *= valorBase;
            }

            return resultado;
        }
    }
}