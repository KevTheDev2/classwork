using System;
using System.Collections.Generic;
using System.ComponentModel.Design;  // Give me access to the systems generic collections stuff

namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************
             * Example use of a Dictionary with array/List value
             *********************************************************/
                
            // Ask the user for a name and a grade
            // Store them in a Dictionary
            
            // Dictionary to hold name (key) and grade (value)
            //         key     value
            //         type    type    name      = new Dictionary<key-type, value>();
            Dictionary<string, List<double>> gradeBook = new Dictionary<string, List<double>>();

            // Lets students and grades until the user indicates thry are done
            // Loop until the user satisfies a condition instead of a specific # of times
            // replace for-loop with either a while-loop or a do-while loop()
            // Do we want to loop at least once? Yes - do-while | No - while
            // Is it okay to loop zero times? Yes - while loop | No - do-while loop
            //
            // In this case we have the user to at least once to enter some data
            // How do we want the user to let us know they are done?
            // Create an off/on switch
            // Prompt - ask if they are done
            // Set a condition based on what they tell us
            // Define data used in the loop BEFORE the loop so it's accessible
            //      both inside and outside loop
            // scope - where a variable can be used -  only in the block it's defined in
           
            string userResponse = "";
            do
            {
                
                
               

                // Ask the user for the student name and grade
                Console.Write("Enter student name: ");
                string studentName = Console.ReadLine(); // Get student name// Ask the user for the student name
                //Console.Write("Enter grade: ");
                // Becasue the user might enter a nun numeric grade casuing an exception
                // We should handle that exception so the program doesn't end
                //  with a message that would scare a human
                // We can use a try/catch block to handle the exception
                // When the user enters a non numeric grade: 
                //      1. ignore it and keep going - We are doing this
                //                                    don't put student in the dictionary
                //      2. give them another change
                //      3. Set the grsde to zero

                double grade = 0;
                string userGrade = "";
                List<double> grades = new List<double>();
                try 
                {   // A statement inside this block might casue an exception
                    // We need to get multiple grades for each student and store them in a list
                    string whatTheyTyped = "";
                    List<double> grades = new List<double>(); // grades entered by user
                    while (whatTheyTyped != "end") // loop until the user enter "end"
                    {
                        Console.Write("Enter the grade or end");
                        // Get the user input as a string in case we need it later
                        if (whatTheyTyped == "end")
                        {
                            break; // exit the loop - continue would be okay too
                        }


                    }


                    userGrade = Console.ReadLine();
                    //grade = Double.Parse(Console.ReadLine()); // convery user input to number
                    grade = Double.Parse(userGrade);
                }
                catch (FormatException exceptionObject) // if it throws a FormatException ...
                {
                    Console.WriteLine("The data you entered " + userGrade + " is not a valid number");
                    Console.WriteLine("The data is ignored");
                                // Skip adding student to the dictionary 
                    continue;   // Skip the rest of the loop processing
                }
                // Add the data to our Dictionary
                // Dictionary[key}     = value;
                gradeBook[studentName] = grades; // adding the list of grades for the students

                // We need to find out if they have more students to enter
                // We want to be sure they only enter responses we expect
                // Loop until we get a valid response...
                // for-loop - do we know how many times we want to loop? NO
                // while    - Do we loop based on a condition? YES - Can we loop zero times? - NO
                // do-while - Do we loop based on a condition YES - Do we need to loop at least once? YES

               
                
                
                do 
                {
                    Console.WriteLine("Are you done y/n?");
                    // Get response from the user and convert to lower case
                    userResponse = Console.ReadLine().ToLower();
                    

                } while (userResponse != "y" && userResponse != "n");
               
                
            } while (userResponse != "y"); // loop while they are not done (done == "y")
            
            // Display the entrys in our Dictionary
            // Use a KeyValuePair type to get an entry from teh Dictionary
            foreach (KeyValuePair<string, List<double>> anEntry in gradeBook)
            {
                Console.WriteLine(anEntry.Key + " has a grade of " + anEntry.Value);
                foreach (double grade in anEntry.Value)
                {

                }
            }
            
            Console.WriteLine("Please press enter to end program...");
            Console.Read();
        }
    }
}