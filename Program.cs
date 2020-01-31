using System;
/*
 Author: Anthony Davis
 Date: 1/28/2020
 Description: Project that uses conditional statements once obtaining information from the user
 */

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for the grade they expect to get in the course
            Console.WriteLine("Please enter the grade that you expect to get in ISM 4300...");

            /* Use try catch statements to vslidate the users information and display an error 
               message if incorrect information is inputed
            */
            try
            {
                // Create a variable gathered from input
                string input = Console.ReadLine();

                // Convert input into interger
                int grade = int.Parse(input);

                // Use if else if statements to test the inputs correct letter grades from course syllabus
                if ((grade <= 100) && (grade >= 98))
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is A+");
                }
                else if ((grade <= 97) && (grade >= 92))
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is A");
                }
                else if ((grade <= 91) && (grade >= 90))
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is A-");
                }
                else if ((grade <= 89) && (grade >= 88))
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is B+");
                }
                else if ((grade <= 87) && (grade >= 82))
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is B");
                }
                else if ((grade <= 81) && (grade >= 80))
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is B-");
                }
                else if ((grade <= 79) && (grade >= 78))
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is C+");
                }
                else if ((grade <= 77) && (grade >= 72))
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is C");
                }
                else if ((grade <= 71) && (grade >= 70))
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is C-");
                }
                else if ((grade <= 69) && (grade >= 68))
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is D+");
                }
                else if ((grade <= 67) && (grade >= 62))
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is D");
                }
                else if ((grade <= 61) && (grade >= 60))
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is D-");
                }
                else if (grade < 60) 
                {
                    // Display the correct letter grade
                    Console.WriteLine("Your lettergrade based from the syllabus is F");
                }
            
            else
            {   // Displays an error message that the integer value is not within the parameters
                Console.WriteLine("You have entered an integer value not within the restricted parameters");
                Console.WriteLine("Please retry and enter an integer value for your expected letter grade with the correct parameters!");
                Console.WriteLine("Press any key to exit the program and try again!");
            }
        }
        // Catches incorrect data that was input by user
            catch
            {
        // Displays an error message when incorrect data type is inputed
                Console.WriteLine("You inputted the incorrect data type :(");
                Console.WriteLine("Please use an integer data type for the grade you are expecting");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // End of catch
        } // End of Main
    } // End of class
} // End of namespace
