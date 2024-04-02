using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_console
{
    public class Fatorial
    {
        public static void Calcular()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\nO fatorial de {i} é: {CalcularFatorial(i)}\n");
            }
        }

        private static int CalcularFatorial(int n)
        {
            if (n == 0)
                return 1;

            int resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}