using System;

namespace solutions
{
    public class Exercise02
    {
        public void Exercise2()
        {
            /* Desenvolva um gerador de tabuada, capaz de gerar a tabuada de qualquer número inteiro entre 1 a 10. O usuário deve informar de qual numero ele deseja ver a tabuada. A saída deve ser conforme o exemplo abaixo:
               Tabuada de 5:
               5 X 1 = 5
               5 X 2 = 10
               5 X 10 = 50 */

            Console.WriteLine("Tabuada");
            Console.WriteLine("Digite um número entre 1 a 10:");
            var gerador = Convert.ToInt32(Console.ReadLine());

            if (gerador < 1 || gerador > 10)
            {
                Console.WriteLine("Digite um número válido");
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(gerador + " x " + i + " = " + (gerador * i));
                }
            }
        }
    }
}
