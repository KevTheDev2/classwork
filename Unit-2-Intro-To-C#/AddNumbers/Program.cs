namespace AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Start of Program");

            // Ask the user for three numbers, one at a time
            // to produce a sum

            // 1. Do this three times - a loop allows code to be executed multiple times
            //     Ask the user to enter a number
            //     Get the number from the user
            //     Add the number to the sum right immideately

            // 2. Display the sum of the numbers

            // Data we need:
            //
            // 1. A place to hold the number entered by the user
            // 2. A plaxe to hold the numbers

            // Define a place to hold the number entered by the user
            int firstEntry = 0;

            // Define a place to hold the numbers

            int sum = 0;

            // Loop through our process three times
            // If you know the number of times you want to loop
            //  use a for-loop

            // Syntax of a for loop :
            //                  (1)                           (2a)                          (2b)  
            //          initialization-part         ; loop-condition part               ; increment
            //
            //      for(int variable = initial-value; variable < #-times to Loop; variable++) {
            //      }
            //
            // The for-loop is controlled by the variable defined within it:
            //      1. int variable=initial value - initializes the variable (usually 0)
            //      2. The condition following the variable definition is tested:
            //             a. If true - performs the process between the {} for the  for-loop increment
            //                the variable according to the last part of the loop
            //             b. if false - exit the loop after closing the brace }   

            for (int i = 0; i < 5; i++)
            { // i=0, 1, 2 inside the loop - 3 causes it to exit


                // Ask the user to enter the number
                Console.WriteLine("Please enter a number: ");
                // Get the number they type
                string theUserResponse = Console.ReadLine(); //  Get the data from the keyboard
                firstEntry = int.Parse(theUserResponse); // Convert data to an int

                // Alternate wat to get without using a string variable
                //Combines multiple statements into one

                //firstEntry = int.Parse(Console.ReadLine());

                // Add the number to the sum

                sum = sum + firstEntry;
                // Alternate: sum += firstEntry;
            }
            Console.WriteLine("The sum of the numbers is: " + sum);
            

            Console.WriteLine("----End of Program----");
        }
    }
}
