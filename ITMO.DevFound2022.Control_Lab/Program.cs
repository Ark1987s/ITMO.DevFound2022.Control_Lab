using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.DevFound2022.Control_Lab
{
    internal class Program
    {
        public static int IndexOf(Array array, object value);
        static void Main(string[] args)
        {

            int n = 13;
            int index = n + 1;
            int[] Array = new int[index];
            int i = 1;

            for (i = 1; i < index; i++)
                Array[i] = 5 + i;

            while (Array[i] <= Array[n])
            {
                int current = (Array[i] + Array[n]) / 2;
                int key = IndexOf(Array, current);
                if (key != 0)
                {
                    n = current;

                }
                else
                    if (Array[current] < 0)
                { n = current - 1; }
                else i = current + 1;
            }

            Console.WriteLine(Array[1]);
            Console.Read();


        }

    }

}
