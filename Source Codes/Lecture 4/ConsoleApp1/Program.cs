using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "I am going to school";

            char myChar = 'F';

            char[] arEx = example.ToCharArray();

            Console.WriteLine("the first element of the array is {0}", arEx[0]);
            Console.WriteLine($"the second element of the array is {arEx[1]}");
            Console.WriteLine("the third element of the array is " + arEx[2]);

            //this gives error because index starts from 0 last index is 19
            //Console.WriteLine("the last element of the array is {0}", arEx[20]);

            //this gives error because index starts from 0 last index is 19
            //Console.WriteLine("the last element of the array is {0}", arEx[arEx.Length]);

            char[] myTempArray = new char[5];

            myTempArray[0] = 'P';
            myTempArray[1] = 'r';
            myTempArray[2] = 'o';
            myTempArray[3] = 'g';
            myTempArray[4] = 'r';
            //this gives error because the maximum lenght of initialized array is 5 and index 5 means the 6 th element
            //myTempArray[5] = 'a';


            //not declared yet error
            //myTempArray2[0] = 'P';

            char[] myTempArray2;

            //unassigned error
            //myTempArray2[1] = 'r';

            int[] myIntArray = new int[3];
            myIntArray[0] = 3;
            myIntArray[1] = 12;
            myIntArray[2] = 32;

            //2,3
            //7,9

            int[,] mySimpleMatrix = new int[2, 2];
            mySimpleMatrix[0, 0] = 2;
            mySimpleMatrix[0, 1] = 3;
            mySimpleMatrix[1, 0] = 7;
            mySimpleMatrix[1, 1] = 9;

            Console.WriteLine("matrix second row second number is " +
                mySimpleMatrix[1, 1]);

            int[,,] myThreeDimensionalMatrix = new int[3, 5, 7];

            List<char> myList1 = new List<char>();
            myList1.Add('P');
            myList1.Add('r');
            myList1.Add('o');
            myList1.Add('g');

            Console.WriteLine("the 4th element of the list is " + myList1[3]);

            myList1.Clear();

            //what does this do is enumerating each element of the string (string is a character array) and adds into the list
            myList1.AddRange("introduction to programming");

            myList1.Clear();

            List<char> mySecondList = new List<char> { 'h', 'o', 'm', 'e' };

            myList1.AddRange(mySecondList);
            mySecondList.AddRange("go");
            mySecondList.Add('o');
            mySecondList.Add('k');




            //define this list, change second element to f and print it to the screen
            List<char> myTempList = new List<char> { 'h', 'o', 'm', 'e' };

            Console.WriteLine(myTempList[1]);

            myTempList[1] = 'f';

            Console.WriteLine(myTempList[1]);

            //insert character G after the second element and print it to the screen

            Console.ReadLine();
        }
    }
}
