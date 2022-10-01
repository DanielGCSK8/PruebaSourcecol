using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSourcecol
{
    internal class Fibonacci
    {
        public bool fibonacci(int num)
        {
            double n1 = 5 * Math.Pow(num, 2) + 4;
            double n2 = 5 * Math.Pow(num, 2) - 4;

            int square_n1 = (int)Math.Sqrt(n1);
            int square_n2 = (int)Math.Sqrt(n2);

            if ((square_n1 * square_n1 == n1) || (square_n2 * square_n2 == n2))
            {

                return true;

            }
            else
            {

                return false;
            }

        }

        public void caller()
        {
            Console.WriteLine("Ingresa un número");
            int num = int.Parse(Console.ReadLine());

            if (fibonacci(num) == true)
            {
                Console.WriteLine("El número pertenece a la sucesión fibonacci");
            }
            else
            {
                Console.WriteLine("El número no pertenece a la sucesión fibonacci");
            }

        }
    }
}