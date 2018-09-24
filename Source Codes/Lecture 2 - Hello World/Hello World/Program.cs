using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World");
          //  Console.ReadKey();

            Int16 my15BitNumber = 1250;// -32767 <> 32767
            var result = Convert.ToString(my15BitNumber, 2);

            UInt16 my16BitNumber = 53212;// 0 <> 65535

            var result2 = Convert.ToString(my15BitNumber, 2);

            int my31BitNumber = 2147483647; // -2147483647 <> 2147483647

            var result3 = Convert.ToString(my16BitNumber, 2);

            uint my32BitNumber = 4294967295; // 0 <> 4294967295
            Int64 my63BitNumber = 9223372036854775807; // -9223372036854775807 <> 9223372036854775807
            UInt64 my64BitNumber = 18446744073709551615; // 0 <> 18446744073709551615

            //int = Int32
            //ulong = Int64

            double myDoubleNumber = 321.321;//this can hold 15 after .
            float myFloatNumber = (float)3125.123;
            decimal myDecimal = (decimal)12312.125412512512312;//this can hold 28 29

            decimal myDecimal2 = 12312.125412512512312M;
            float myFloatNumber2 = 3125.123F;

            bool myBool = true;//true false // doğru yanlış

            //*adklmaskld,
            // *asdasdkmkdsf
            // * kmksdfsd

            if (myBool==true)
            {

            }

            sbyte mySbyte = 127;// between -127 <> 127
                                //short equal to Int16

            char myChar = '%';
           string gg = Convert.ToString(myChar, 2);
            string myString = "example";


        }
    }
}
