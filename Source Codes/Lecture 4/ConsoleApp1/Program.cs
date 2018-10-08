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

            string srTemp2 = "my first score is {0}, my third score is {2}, my second score is {1}";

            string myFormatString = string.Format(srTemp2, 85, 75, 45);

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

            List<char> myList1 = new List<char>("lets go to school");
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

            List<int> myintList = new List<int> { 4, 5, 1, 2, 5, 1 };


            //define this list, change second element to f and print it to the screen
            List<char> myTempList = new List<char> { 'h', 'o', 'm', 'e' };

            Console.WriteLine(myTempList[1]);

            myTempList[1] = 'f';

            myTempList.RemoveAt(1);//deletes the element at the x'th index
            myTempList.Remove('f');

            Console.WriteLine(myTempList[1]);

            Console.WriteLine(myTempList[2]);

            myTempList.Insert(2, 'P');

            Console.WriteLine(myTempList[2]);

            //insert character G after the second element and print it to the screen

            char[] myArray3 = "home".ToCharArray();

            List<char> mySortList = "lets go to the school".ToList();

            mySortList.Sort();//this sorts the list ascendin (from smaller to bigger)
            mySortList.Reverse(); //this reverse orders the list

            mySortList = mySortList.Distinct().ToList();
            var myTemp3 = mySortList.Take(3).ToList();
            mySortList = "lets go to the school".ToList();
            var mytemp4 = mySortList.GetRange(5, 9);

            List<int> myList3 = new List<int> { 4, 511, 32, 56, 78, 32, 56 };

            var maxitem = myList3.Max();
            var minitem = myList3.Min();
            var index32 = myList3.IndexOf(32);
            var lastindex32 = myList3.LastIndexOf(32);
            var avgList = myList3.Average();
            var sumlist = myList3.Sum();

            bool result1 = myList3.Contains(512);
            bool result2 = myList3.Contains(511);

            if (myList3.Contains(512))
            {

            }
            else
            {

            }



            Console.ReadLine();
        }
    }
}
