using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slump
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    Random slump = new Random();
                int summa = 0;

                for (int i = 0; i <= 10 ; i++)
                {
                    int tal = slump.Next(20);
                    summa = summa + tal;
                    Console.WriteLine(tal);

                }
                Console.WriteLine("medelvärdet är " + summa/10); */

            Random slump = new Random();
            
            int[] nummer = new int[20];

            for (int i = 0; i < 21; i++)
            {
                nummer[i] = slump.Next(15, 31);
            }
            Array.Sort(nummer);
            for (int i = 0; i <21; i++)
            {
                Console.WriteLine((nummer[i]) + ",");
            }
            Console.WriteLine("median är : " + ((nummer[9] + nummer[10]) / 2));
        }
    }
}
    



