using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Add5Integers_01072016
{
    class Program
    {
        static void Main(string[] args)
        {
            // Week 1, Project: Read 5 integer numbers and add them up.

            Console.WriteLine("This program takes 5 numbers that you enter and adds them up.");
            Console.WriteLine("Please enter only whole numbers without commas like 57 or 3 or 2345.");  // The type of number is defined, but not checked.
            Console.WriteLine();

            int sum = 0;    // declare a variable to store the sum and assign its initial value to 0

            for (int numCount = 0; numCount < 5; numCount++)  // Use a loop to ask the user for 5 numbers.  As the numbers are read, calculate a running total.
            {
                Console.Write("Please enter a number: ");
                string userTypedNum = Console.ReadLine();
                //sum = sum + Convert.ToInt32(userTypedNum);  This is an alternative way to code the line below
                //sum += Convert.ToInt32(userTypedNum);  This is an alternative way to code the line below
                sum += int.Parse(userTypedNum);  // Convert user entered information from string to integer.  Add the value to the running total in sum.
            }

            // Write the sum of numbers to the console.
            Console.WriteLine();
            Console.WriteLine("The sum of the numbers you entered is: " + sum);

        }
    }
}
