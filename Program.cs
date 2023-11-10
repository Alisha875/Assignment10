using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1.1: Declare and Initialize ArrayList 'studentGrades'
            ArrayList studentGrades = new ArrayList();

            // Task 1.2: Initialize studentGrades with integer values
            studentGrades.Add(85);
            studentGrades.Add(92);
            studentGrades.Add(78);
            studentGrades.Add(95);
            studentGrades.Add(88);

            // Task 2.1: Display the contents of 'studentGrades'
            Console.WriteLine("Student Grades:");
            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }

            // Task 2.2: Calculate and display the sum of all the grades
            int sum = 0;
            foreach (int grade in studentGrades)
            {
                sum += grade;
            }
            Console.WriteLine($"Sum of Grades: {sum}");

            // Task 3.1: Add a new grade of 90 to the end of 'studentGrades'
            studentGrades.Add(90);

            // Task 3.2: Display the updated contents of 'studentGrades'
            Console.WriteLine("\nUpdated Student Grades:");
            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }

            // Task 4.1: Remove the grade of 78 from 'studentGrades'
            studentGrades.Remove(78);

            // Task 4.2: Display the contents of 'studentGrades' after removal
            Console.WriteLine("\nStudent Grades after Removal:");
            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }

            // Task 5.1: Search for the index of the grade 95 in 'studentGrades'
            int index = studentGrades.IndexOf(95);

            // Task 5.2: Update the grade at the found index to 96
            if (index != -1)
            {
                studentGrades[index] = 96;
            }

            // Display the final contents of 'studentGrades'
            Console.WriteLine("\nFinal Student Grades:");
            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
            Console.ReadKey();
        }
    }
}
