namespace Day_7_Array_Example;

using System;

class Program
    {
        /**************************************************************************************
         * This app will receive up to 10 numbers from the user
         *
         * After the user has indicated they have no more numbers to enter
         *             or 5 numbers have been entered...
         *               
         * We will display each or the numbers entered with an indicator if number odd or even,
         *                 their sum and average
         *
         * Since we need to do something after we have all the numbers,
         *     rather than as we get each number
         *
         * We need to store the number the user entered and process them all when user is done
         *
         * We need to have some way for the user to tell us they are done entering numbers
         *****************************************************************************************/

        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to my app!");       // Verify the app started

            // Const Marks a variable as a constant
            // a constant can't be changed once it is assigned a value
            // constant names should be all UPPERCASE with _ to separate the parts of the name
            // Define a constant to use to reference the size of the array
            const int ARRAY_SIZE = 5;  // use this every where you want to code the size of the array

            // Define an array to hold up to 5 numbers entered by the user
            double[] theNumbers = new double[ARRAY_SIZE];  //define an array ARRAY_SIZE doubles

            // Define a variable to hold the user input
            string whatUserTyped = "";

            // Define a variable to hold the sum of number
            double theSum = 0;

            // Define a variable to hold the number of variables entered by the user
            int numberEntered = 0;

            // When you need to process an array from start to end
            // Use a for loop
            // for(int i=0; i<size-of-array; i++) - use i as the index into the array inside the loop
        
            // Set up a loop to get ARRAY_SIZE numbers, one at a time or responses indicating the user is done
            for (int i = 0; i < ARRAY_SIZE; i++) // instead of ARRAY_SIZE theNumbers.Length is okay to use
            {   
             // if (moreInput() != true)
                if (!moreInput()) // if they don't have any more input... moreInput() is a method
                {
                    break;  // exit the for-loop before it's gone through all iterations
                }
                // At this point we know the user has a number to enter

                // Call the method to get a numeric value and store it in the current array element indicated by i
                theNumbers[i] = GetANumber();  // get the number and store in the next array element

                numberEntered++;  // Count a number being entered
            }   // end of for-loop - break sends us to end after this
            // Since the variable i has the number of times through the loop
            // Can we use it after the loop to store the number of values entered?
            //
            // numberEntered = i;
            //
            // NO! i is defined in the for loop - so it can be used inside the for-loop (scope)

            // So now the array has all the numbers entered by the user

            Console.WriteLine("So I received "+ numberEntered + " numbers from you");

            // Go through the array and display each number, whether it's odd or even
            // Only process the numbers that were entered. i.e. NOT arrayname.length
            for (int i = 0; i < numberEntered; i++)
            {

            // The ternary operator: condition ? value-if-true : value-if-fasle
            //
            //  (ia array evenly divisible by 2 ? yes - Even : no - Odd
            //  theNumbers{i} % 2 == 0 ? "Even" : "Odd"
            //
            // % modulus operator - returns the remainder after and integer divide
            //
            // 6 % 2 - return 0
            // 7 % 2 - returns 1
            // 101 % 33 - returns 2 (100 / 33 -3 with remainder 2 (99 + )
            //
            // If you divide a number by 2 and the remainder is 0, it's Even
            //                                     remainder is 1, it's Odd


                Console.WriteLine("Element #: " + i + " is: " + theNumbers[i] 
                                + " it is " + (theNumbers[i] % 2 == 0 ? "Even" : "Odd"));

                theSum = theSum + theNumbers[i];
            }

            Console.WriteLine("The sum of the numbers is: " + theSum);
            Console.WriteLine("The avg of the numbers is: " + theSum / numberEntered);

            Console.WriteLine("\nThanks for using my app!"); // Verify the app ended

            Console.WriteLine("\nPress enter to end program...");
            Console.ReadLine();
        } // End of Main()

        /****************************************************************
         * Helper methods used by Main()
         ******************************************************************/

        // return a boolean value to indicate if teh user has more input
        //  return type if not entered "Y"
        //
        static bool moreInput()
        {
            bool   isThereInput  = false;  // Hold the return value 

            string whatUserTyped = "";     // Hold what the user enters

            bool   getInput      = true;   // Control the user interaction loop

            
            // do-while - loop while the condition is true
            // the condition is on the while part of the loop at the bottom of the loop
            // You will always loop at least once with a do-while
            // (the loop condition is not checked until the end of the loop)
            // (unlike for-loop or while-loop where the condition is checked before you loop once
            //
            // We use a do-while loop becasue we need to ask the user at least once they have any 
        
            do
            {
                // Ask the user if they have any numbers to enter (Y/N)
                Console.WriteLine("Do you have any numbers to enter (Y/N)?");
                whatUserTyped = Console.ReadLine();

                // Convert user input to all uppercase - so we don't worry about case
                whatUserTyped = whatUserTyped.ToUpper();

                // Extract first character from the user input - Substring(start-index, # of characters)
                string firstChar = whatUserTyped.Substring(0, 1);

                if (firstChar == "Y")
                {
                    getInput = false; // Done getting input - set loop control variable to false
                    isThereInput = true; // Indicates we have good input - sets the indicator to true
                }
                else
                {
                    if (firstChar == "N")
                    {
                        getInput = false; // Done getting input
                        isThereInput = false; // user has no more input
                    }
                }
            } while (getInput); // Loop while we get input - end loop (while getInput == true) 
            // while(getInput == true) // alternate way of coding
            // it's not necesarry when you have bool variable since the variable can only be tru or false
            // so the variable name will be true or false no need to == or !=


            return isThereInput;
        }

        // method starts with a method signature:  return-type name(parameters)

        // This method will get a numeric value from the user
        // It must be static because it will be used by the static method Main() (more later)
        // this method receives no parameters and returns a double (a double can also hold an int value)
        static double GetANumber()
        {
            // define a variable for the return value
            double theValue = 0;

            // Ask the user for a numeric value and have them keep trying until we get one

            bool isValidNumber = false;  // Determine is user entered a valid value

            // Loop until we get a valid numeric value

            do  // do loop is used so we ask the user for a number at least once
            {
                // Prompt the user to enter a numeric value
                Console.WriteLine("Please enter a number");

                // Get the input from the user
                string userInput = Console.ReadLine();

                // some statements may cause an Exception during process
                // An exception is an error that occurs when the program runs (aka Runtime Exception)
                // When an Exception occures a crytic (to normal people) error message is displayed and
                //              the program stops
                //
                //
                // You can handle an Exception if it occurs in the program and let the program continue
                // with a try/catch blocs
                //
                // Ypu put code that might cause an exception in a try block {}
                // followed by one or more catch blocks for the exception
                //  catch (exception-to-handle name-for-exception-object)
                //
                //  The exception object contains information about the exception you might use 

                try // We want to handle an Exception that might occur in this block of code
                {
                    // Convert the user input to a double
                    theValue = double.Parse(userInput); // Could cause an Exception
                    isValidNumber = true;  // if .Parse() worked we have a valid number
                }
                // catch (Exception exceptionBlock) will handle every Exception that can occur
                catch (FormatException exceptionBlock) // Handle a FormatException in previous try block
                {
                    Console.WriteLine("\n----- Uh-oh Uh-oh Uh-oh ------");
                    Console.WriteLine("There is problem with " + userInput);
                    Console.WriteLine(exceptionBlock.Message); // Display the system message for the error form exception object
                    Console.WriteLine("------ Uh-oh Uh-oh Uh-oh ------\n");
                }
            } while (!isValidNumber); // Loop while we don't have a valid number

            // return the double value from the user input
            return theValue;
        } // End of getANumber() method
    } // End of class Program