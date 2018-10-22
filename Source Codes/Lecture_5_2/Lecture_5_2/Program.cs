using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            while(i>0)
            {
                Console.WriteLine("i=" + i);
                i--; // i = i -1;
            }

            i = 10;
            while (true)
            {
                Console.WriteLine("i=" + i);
                i--; // i = i -1;
                if (i < 1)
                    break;
            }

            Console.Clear();//clears console screen

            while(true)
            {
                Console.WriteLine("Please enter an integer to test it is prime number or not?");
                string userInput = Console.ReadLine();

                Int64 intCheck = 0;
                Int64.TryParse(userInput, out intCheck);//tries to parse as integer
                
                if(intCheck<2)
                {
                    Console.WriteLine("Please enter an positive integer bigger than 1");
                    Console.WriteLine("");
                    continue;
                }

                //function returns true if the number is a prime number
                bool isAPrimeNumber = check_Is_Prime(intCheck);

                if (isAPrimeNumber == false)
                    Console.WriteLine($"[{intCheck}] is not a prime number");
                else
                    Console.WriteLine($"[{intCheck}] is a prime number");

                Console.WriteLine("");

               // break;//break the infinite loop if you wish
            }

            bool result = check_Is_Prime(31242);

            Console.ReadLine();
        }

        //private protected public : güvenlik seviyesi accessbility
        private static bool check_Is_Prime(Int64 numberToCheck)
        {
            bool asal_sayi_degil_mi = false;

            for (int i = 2; i < numberToCheck; i++)
            {
                if (numberToCheck % i == 0)
                {
                    asal_sayi_degil_mi = true;
                    //evet asal sayi değil / yes it is a prime number
                    break;
                }
            }

            // makes true > false , false > true by using ! infront
            asal_sayi_degil_mi = !asal_sayi_degil_mi;

            return asal_sayi_degil_mi;
        }
    }
}
