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
            GetTeacherInfo();
            Console.ReadLine();
            // Create a method to get information for a teacher, a course, and program, and a degree using a similar method as above
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
        // Method that prints student information
        static void PrintStudentDetails(string id, string fName, string lName)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("RECORD: {1} {2} has a student number: {0}", id, fName, lName);
            Console.WriteLine("-------------------------------------------");
        }

        // Method that prompts the user to input teacher information
        static void GetTeacherInfo()
        {
            Console.WriteLine("***ENTER TEACHER INFORMATION***");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Course to teach next semester: ");
            string subject = Console.ReadLine();
            PrintTeacherInfo(firstName, lastName, subject);
        }

        static void PrintTeacherInfo(string firstName, string lastName, string subject)
        {
            //throw new NotImplementedException();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Teacher: {0} {1} will teach: {2}", firstName, lastName, subject);
            Console.WriteLine("-------------------------------------------");
        }
    }
}
