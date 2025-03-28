using System.Runtime.CompilerServices;

namespace FirstProgram
{

    // This program will ask for three numbers
    //      add them together and display the total

    // **Programming is finding the solutuon first. Coding is building/converting it with a programming language**
    // Thinking like a human first, then a coder second
    // Computers don't understand human context. You have to be specific details
    // Programming Solution - Human thinking dictates the following:

    // Ask the numbers one at a time
    // Write down each number as it is given.
    // Add the number 
    // Tell the requester the total (display)

    // Now that we have thee steps in our solution...
    // Identify any data/processes needed for the steps

    // 1. A place to write down each number - a variable in a program (something that needs to be remembered)
    // 2. A place to hold the sum/total - a variable in a program
    // 3. A way to ask for the numbers - a method in a program (a way to do something) (object.method())
    // 4. A way to receive the numbers - a method in a program (object.method())
    // 5. A way to report the total/sum - a method in a program (object.method())
    //      * In object oriented prgramming, we'll need an object and method

    // Place the steps in the order and provide more detail, if needed, to solve the problem.
    // 1. Ask the numbers one at a time
    //      a. Tell whatever is giving us a number to give me the first number
    //      b. Recieve the first number from sender
    //      c. Write down the first number
    //      d. Tell whatever is giving us a number to give me the second number
    //      e. Recieve the second number from sender
    //      f. Write down the second number
    //      g. Tell whatever is giving us a number to give me the third number
    //      h. Recieve the third number from sender
    //      i. Write down the third number

    // 2. Add the numbers together create a sum
    //      a. Add the first number to a sum total
    //      d. Add the second number to a sum total
    //      c. Add the third number to a sum total

    // 3. Tell the requester the sum/total (display)


    class Program
    {
        static void Main(string[] args)
        {

            /**************************************************************************
             *Define any data the program needs at the top of the program
             *
             *Data may be defined anywhere before it's used, is easier to find 
             *at the top of the program
             *
             * To define a variable: data-type-name = initial-value:
             * 
             * Commonly used data types in C#
             * 
             *  int - Numeric data that is a whole number between +/- 2 billion
             *  long - A whole number greater than +/- 2 billion
             *  double - numeric value with decimal places
             *  char _ a single alhpa-numeric character
             *  string - a series of alpha-numeric characters (words or a sentence)
             *  bool(ean) - true or false
             *  
             *      examples:
             *      10 - int
             *      1.0 - double
             *      'a' - char (note it is enclosed in ' ')
             *      "some words" - string (note it is enclosed in " ")
             *      
             *      variable names in C# are usually spelled in  camelCase; Use - to separate words (optional)
             *      (CamelCase means the first letter is in lower case wile other 
             *              words start with an uppercased letter)
             *              
             *              It's always good to initialize variables when defining them so you know
             *              what is in them
             **************************************************************************
             *
             * Define variables to hold the numbers we need to add
             
             */

            int number1 = 0;
            int number2 = 0;
            int number3 = 0;

            // Define a variable to hold the sum of the numbers
            
            int sum = 0;


            Console.WriteLine("---Starting Program---");

            // Ask for numbers one at a time using C# console logic
            //      which represents they keyboard and screen
            // Console.Readline() returns a string - cannot store as an int
            //  
            Console.WriteLine("Please enter a number: "); // Asking for the number
            string aLine;   // String to hold the line of input from the keyboard
            aLine = Console.ReadLine();  // Get a line from the keyboard
            // We need an int value to store our numbers
            // Console.ReadLine() only returns a string
            // So we need to convert the string from Console.ReadLine to an int
            // int.Parse(string) will convert a string to an int
            number1 = int.Parse(aLine);
            
            //**********************************************
            // Verify that I got the data I expected
            // Dsiplay some words and the value I receive
            // "string" + something is called concatenation (it sticks them together)
            //Console.WriteLine("You entered: " + number1);
            
            //
            
            //*********************************************
            Console.WriteLine("---Ending Program---");
        }
    }
}
