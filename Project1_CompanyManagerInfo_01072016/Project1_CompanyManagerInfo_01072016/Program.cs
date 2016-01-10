using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_CompanyManagerInfo_01072016
{
    class Program
    {
        static void Main(string[] args)
        {
            // Week 1, Project: Enter Company name, address, phone number, fax number, website, manager first name, manager last name, manager phone number
            // and print all of the entered information to the console.

            // Ask user to enter all information.  Save data in a string variable for each piece of information.

            Console.Write("Enter the company name: ");
            string companyName = Console.ReadLine();     
            Console.Write("Enter the company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Enter the company phone number: ");
            string companyPhoneNum = Console.ReadLine();
            Console.Write("Enter the company fax number: ");
            string companyFaxNum = Console.ReadLine();
            Console.Write("Enter the company website: ");
            string companyWebsite = Console.ReadLine();
            Console.Write("Enter the manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Enter the manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Enter the manager phone number: ");
            string managerPhoneNum = Console.ReadLine(); 

            // Write all of the information to the screen.

            Console.WriteLine();
            Console.WriteLine("Here is the information you entered for this company:");
            Console.WriteLine(companyName);
            Console.WriteLine(companyAddress);
            Console.WriteLine("Phone: " + companyPhoneNum);
            Console.WriteLine("FAX: " + companyFaxNum);
            Console.WriteLine("Manager name: " + managerFirstName + " " + managerLastName);
            Console.WriteLine("Manager phone: " + managerPhoneNum);

            // Display the manager's information in columns of 20 characters 
            // First name and last name is left justified; Phone number is right justified   

            Console.WriteLine();
            Console.WriteLine("{0,-20}{1,-20}{2,-20}|", "First Name", "Last Name", "Phone Num");
            Console.WriteLine("{0,-20}{1,-20}{2,20}|", managerFirstName, managerLastName, managerPhoneNum);
           
        }
    }
}
