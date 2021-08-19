using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int32> NumerosPares;
            NumerosPares = new List<Int32>();

            for (int i = 0; i < 11; i++)
            {
                    NumerosPares.Add(i);
            }
            foreach (var item in NumerosPares)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}
