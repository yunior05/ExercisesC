using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        public static void Wait()
        {
            Console.WriteLine("Press Enter to continue...");
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
        }

        static void Main(string[] args)
        {
            //1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number,
            //display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into
            //input boxes need to be validated.)
            Console.WriteLine("Insert a number between 1 to 10.");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10) Console.WriteLine("Valid");
            else Console.WriteLine("Invalid");

            Wait();

            //2- Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.WriteLine("Insert two numbers respectically");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            int secondNum = Convert.ToInt32(Console.ReadLine());
            if (firstNum > secondNum) Console.WriteLine($"The maximum of the two is {firstNum}");
            else if (firstNum < secondNum) Console.WriteLine($"The maximum of the two is {secondNum}");
            else Console.WriteLine("The two numbers are equals");

            Wait();
            //3 - Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.
            Console.WriteLine("Insert width and height of the image respectically");
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            if (width > height) Console.WriteLine("The image is landscape");
            else Console.WriteLine("The image is portrait");

            Wait();


        }
    }
}
