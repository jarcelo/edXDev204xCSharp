using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Information
            Console.WriteLine("***ENTER STUDENT INFORMATION***");
            Console.Write("Student ID: ");
            String studentID = Console.ReadLine();
            Console.Write("First Name: ");
            String firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            String lastName = Console.ReadLine();
            Console.Write("Birthday (YYYY-MM-DD): ");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Gender: ");
            String gender = Console.ReadLine();
            Console.Write("Address 1: ");
            String address1 = Console.ReadLine();
            Console.Write("Address 2: ");
            String address2 = Console.ReadLine();
            Console.Write("City: ");
            String city = Console.ReadLine();
            Console.Write("State/Province: ");
            String stateOrProvince = Console.ReadLine();
            Console.Write("Zip code: ");
            String zipCode = Console.ReadLine();
            Console.Write("Country: ");
            String country = Console.ReadLine();
            // Output Student Information
            Console.WriteLine();
            Console.WriteLine(" Student ID: {0}\n Student Name: {1} {2} \n Birthday: {3}\n Address: {4} {5}\n City: {5}\n State/Province: {8} Country: {10} Zip Code: {9}",
                studentID, firstName, lastName, birthDate, gender, address1, address2, city, stateOrProvince, zipCode, country);
            Console.WriteLine();

            // Professor Information
            Console.WriteLine("***ENTER PROFESSOR'S INFORMATION***");
            Console.Write("University ID: ");
            string universityID = Console.ReadLine();
            Console.Write("Academic Rank: ");
            String academicRank = Console.ReadLine();
            Console.Write("First Name: ");
            String profFirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            String profLastName = Console.ReadLine();
            Console.Write("Gender: ");
            String profGender = Console.ReadLine();
            Console.WriteLine();

            // University Degree
            Console.WriteLine("***ENTER UNIVERSITY INFORMATION***");
            Console.Write("Degree Name: ");
            String degreeName = Console.ReadLine();
            Console.Write("Degree Description: ");
            String degreeDescription = Console.ReadLine();
            Console.Write("Credits Required: ");
            int creditsRequired = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // University Program
            Console.WriteLine("***ENTER PROGRAM INFORMATION***");
            Console.Write("Program ID: ");
            int programID = int.Parse(Console.ReadLine());
            Console.Write("Program Name: ");
            String programName = Console.ReadLine();
            Console.Write("Department Head: ");
            String departmentHead = Console.ReadLine();
            Console.WriteLine();

            // Course Information
            Console.WriteLine("***ENTER COURSE INFORMATION***");
            Console.Write("Course ID: ");
            int courseID = int.Parse(Console.ReadLine());
            Console.Write("Course Name: ");
            String courseName = Console.ReadLine();
            Console.Write("Course Description: ");
            String courseDescription = Console.ReadLine();
            Console.Write("Course Credits Per Hour: ");
            int creditsPerHour = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Output Course Information
            Console.WriteLine("Course Information: \n Course ID: {0}\n Course Description: {1}\n Course Name: {2}\n Credit Per Hour: {3}",
                courseID, courseDescription, courseName, creditsPerHour);

            Console.ReadLine();
        }
    }
}
