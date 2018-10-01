using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            int c = a + b;
            Console.Write("version 1 : c is equal to {0}\n\n", c);
            Console.Write("version 2 : c is equal to " + c + "\n");
            Console.Write($"version 3 : c is equal to {c}\n\n");

            int d = c * a * b;
            int e = d / 5;
            int k = d - e;

            Console.WriteLine("version 1 : c is equal to {0}, d is equal to {1}, e is equal to {2}, k is equal to {3}, c is equal to {0}"
                , c, d, e, k);

            Console.WriteLine("version 2 : c is equal to " + c + ", d is equal to " + d + ", e is equal to " + e + ", k is equal to " + k + ", c is equal to " + c);

            Console.WriteLine($"version 3 : c is equal to {c}, d is equal to {d}, e is equal to {e}, k is equal to {k}, c is equal to {c}");


            if (d > e)
                Console.WriteLine("d is bigger than e");

            if (d < e)
                Console.WriteLine("e is bigger than d");

            if (d < e)
            {
                Console.WriteLine("e is bigger than d 1");
                Console.WriteLine("e is bigger than d 2");
                Console.WriteLine("e is bigger than d 3");
            }

            if (e < d)
            {
                Console.WriteLine("e is bigger than d 1");
                if (k > e)
                {
                    Console.WriteLine("e is bigger than d 2");
                }

                Console.WriteLine("e is bigger than d 3");
            }

            if (e > k)
            {
                Console.WriteLine("since e is not smaller than k this line is executed 1 ");
                Console.WriteLine("since e is not smaller than k this line is executed 2");
                Console.WriteLine("since e is not smaller than k this line is executed 3");
            }
            else
            {
                Console.WriteLine("since e is smaller than k this line is executed");
            }

            if (e > k)
                Console.WriteLine("since e is not smaller than k this line is executed 1 ");
            else
                Console.WriteLine("since e is smaller than k this line is executed");


            int number1 = 15;
            int number2 = 15;
            int number3 = 21;

            if (number1 == number3)
            {
                Console.WriteLine("number 1 is equal to number 3");
            }
            // if (number1 => number3) this is incorrect
            if (number1 >= number3)
            {
                Console.WriteLine("number 1 is bigger or equal to number 3");
            }
            if (number1 <= number3)
            {
                Console.WriteLine("number 1 is smaller or equal to number 3");
            }

            if (number1 == number2)
            {
                Console.WriteLine("number 1 is equal to number 2");
            }
            // if (number1 => number3) this is incorrect
            if (number1 >= number2)
            {
                Console.WriteLine("number 1 is bigger or equal to number 2");
            }
            if (number1 <= number2)
            {
                Console.WriteLine("number 1 is smaller or equal to number 2");
            }

            string myText1 = "my text 1";
            string myText2 = "my text 2";
            string myText3 = "my Text 2";

            if (myText1 == myText2)
            {
                Console.WriteLine("1");
            }
            if (myText1 != myText2)
            {
                Console.WriteLine("2");
            }
            if (myText1 == myText3)
            {
                Console.WriteLine("3");
            }
            if (myText1 != myText3)
            {
                Console.WriteLine("4");
            }
            if (myText1 != myText2)
            {
                Console.WriteLine("5");
            }
            if (myText2 == myText3)
            {
                Console.WriteLine("5");
            }

            if (myText2.ToLower() == myText3.ToLower())
            {
                Console.WriteLine("5");
            }

            string myTurkishText1 = "İIsim";
            string myTurkishText2 = "iısim";

            if (myTurkishText1.ToLower() == myTurkishText2.ToLower())
            {
                Console.WriteLine("5");
            }

            var mytex1 = myTurkishText1.ToUpperInvariant();
            mytex1 = mytex1.ToLowerInvariant();

            var mytex2 = myTurkishText2.ToUpperInvariant();
            mytex2 = mytex2.ToUpperInvariant();

            if (myTurkishText1.ToUpperInvariant().ToLowerInvariant() == myTurkishText2.ToUpperInvariant().ToLowerInvariant())
            {
                Console.WriteLine("5");
            }

            if (myTurkishText1.ToLower(new System.Globalization.CultureInfo("tr-TR")) == myTurkishText2.ToLower(new System.Globalization.CultureInfo("tr-TR")))
            {
                Console.WriteLine("5");
            }

            string text1 = null;
            string text2 = null;

            if (text1 == text2)
            {

            }

            Console.WriteLine(text1);

            if (text1 == mytex1)
            {

            }

            string text4 = "";


            if (text1 == text4)
            {

            }

            //if (text1.Length == 0)
            //{
            //this throws error since null lenght can not be checked
            //}


            if (text1?.Length == 0)
            {

            }
            if (text1 != null)
            {
                if (text1.Length == 0)
                {

                }
            }

            if (text4.Length == 0)
            {

            }
            if (mytex1.Length == 0)
            {

            }



            Console.WriteLine("hello world");


            Console.ReadLine();
        }
    }
}
