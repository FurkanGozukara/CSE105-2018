using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i = " + i);
            }

            Console.WriteLine("");

            for (int k = 5; k < 25; k = k + 2)
            {
                Console.WriteLine("k = " + k);
            }

            int counter = 10;

            for (; counter <= 13; counter+=3)
            {
                Console.WriteLine("counter = " + counter);
            }

            if(counter==16)
            { 
                int c = 12;
                if(c==12)
                {
                    int localvariable = 25;
                }
            }

            Console.WriteLine("");

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("i = " + i);
                var mod = i % 10;
                if (i % 10 == 0)
                    break;
            }

            Console.WriteLine("");

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("i = " + i);
                for (int k = 1; k < 20; k++)
                {
                    Console.WriteLine("k = " + k);
                    if (k % 17 == 0)
                        break;
                }
            }

            Console.WriteLine("");

            int isPrimeNumber = 179;

            //Is_Not_Prime
            bool asal_sayi_degil_mi = false;//hayır asal sayı / no not a prime number

            for (int i = 2; i < isPrimeNumber; i++)
            {
                if(isPrimeNumber%i==0)
                {
                    asal_sayi_degil_mi = true;//evet asal sayi değil / yes it is a prime number
                    break;
                }
            }

            if (asal_sayi_degil_mi == true)
                Console.WriteLine($"{isPrimeNumber} is not a prime number");
            else
                Console.WriteLine($"{isPrimeNumber} is a prime number");

            Console.ReadLine();

        }
    }
}
