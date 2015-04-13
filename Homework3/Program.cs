using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call GetStudentInfor method
            GetStudentInfo();
            Console.ReadLine();
            // Output Student Information
            //Console.WriteLine();
            //Console.WriteLine(" Student ID: {0}\n Student Name: {1} {2} \n Birthday: {3}\n Address: {4} {5}\n City: {5}\n State/Province: {8} Country: {10} Zip Code: {9}",
            //    studentID, firstName, lastName, birthDate, gender, address1, address2, city, stateOrProvince, zipCode, country);
            //Console.WriteLine();

        }

        // Method that prompts the user to input student information
        static void GetStudentInfo()
        {
            Console.WriteLine("***ENTER STUDENT INFORMATION***");
            Console.Write("Student ID: ");
            string studentID = Console.ReadLine();
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            PrintStudentDetails(studentID, firstName, lastName);
        }
        static void PrintStudentDetails(string id, string fName, string lName)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("RECORD: {1} {2} has a student number: {0}", id, fName, lName);
            Console.WriteLine("-------------------------------------------");
        }
    }
}
