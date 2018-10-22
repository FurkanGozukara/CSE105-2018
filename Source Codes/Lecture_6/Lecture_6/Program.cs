using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_6
{
    class Program
    {
        private static void printToScreen(string message)
        {
            Console.WriteLine(message);
        }

        private static void setConsoleColor(ConsoleColor colorcode)
        {
            Console.ForegroundColor = colorcode;
        }

        static void Main(string[] args)
        {
            setConsoleColor(ConsoleColor.White);

            //this prints the currently set color
            printToScreen(Console.ForegroundColor.ToString());

            printToScreen("Hello World");

            setConsoleColor(ConsoleColor.DarkGreen);

            printToScreen("This message should be dark green");

            setConsoleColor(ConsoleColor.Yellow);

            printToScreen("This message should be yellow");

            setWhite();
            Console.Write("This text should be white. ");
            setRed();
            Console.Write("This text should be red.\n");

            Console.WriteLine("the status of the capslock: " + Console.CapsLock.ToString());

            Console.ReadLine();

            Console.WriteLine("the status of the capslock: " + Console.CapsLock.ToString());

           

            Console.ReadLine();
        }

        private static void setRed()
        {
            setConsoleColor(ConsoleColor.Red);
        }

        private static void setWhite()
        {
            setConsoleColor(ConsoleColor.White);
        }
    }
}
