using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_CircleAreaCircum_01072016
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program asks the user to enter a radius and then calculates the circumference and area of the circle.

            Console.WriteLine("This program will ask you to enter the radius of a circle \nand then it will calculate the circle's circumference and area.");
            Console.WriteLine();
            Console.Write("Please enter the radius: ");
            double radius = double.Parse(Console.ReadLine());  // The user is able to enter a decimal radius
            radius = (radius < 0) ? (radius *= (-1)) : radius ;  // If the user enters a negative number, we will convert it to a positive number
            Console.WriteLine();

            double circumference = Math.PI * 2 * radius;
            double area = Math.PI * radius * radius;

            // The output below includes formatting to round and show answer to 2 decimal places
            Console.WriteLine("The circumference of the circle is {0:f2} square units.", circumference);
            Console.WriteLine("The area of the circle {0:f2} cubic units.", area);
            Console.WriteLine();
            Console.WriteLine("Thank you for playing along!");
        }

    }
}

