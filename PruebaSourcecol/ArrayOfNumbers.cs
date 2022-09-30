using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSourcecol
{
    internal class ArrayOfNumbers
    {
        public int[] organize(int[] valores)
        {
            int menor;
            for (int i = 0; i < valores.Length - 1; i++) {
                for (int j = 0; j < valores.Length - 1; j++)
                {
                    if (valores[j] < valores[j + 1])
                    {
                        menor = valores[j + 1];
                        valores[j + 1] = valores[j];
                        valores[j] = menor;

                    }
                }  
        }
      
            return valores;

        }

        public void call()
        {
            int count = 0;
            int [] valores = new int[10] {2, 1, 3, 4, 5, 7, 10, 9, 6, 1 };
            organize(valores);

            for (int i = 0; i < valores.Length - 1; i++)
            {
                Console.Write(valores[i] + ",");
                if (valores[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Hay " + count + " números pares");
           
        }
    }
}
