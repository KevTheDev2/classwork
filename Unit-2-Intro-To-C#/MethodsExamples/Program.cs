namespace MethodsExamples
{
    class Program
    {/*****************************************************************************
      * Demonstrate the use of a Programmer Method
      * 
      *  a method is a program that processes data and usually returns a value
      *  
      *  a method starts with a method signature - identifies the name of the method
      *                                            what type of data ir returns
      *                                            what data it will accept for processing 
      *                                            
      *    method signature:    return-type Name(data-it-will-accept)
      *    
      *          return-type - the type of data returned from the method
      *                       use void if the method does not return data
      *                       
      *          Name() - name of the method - method names are used in PascalCase
      *                                        PascalCase - the first letter of every word is capitalized 
      *          
      *          (data-it-will-accept) - data data-type and name of parameters  
      *          
      *          parameter is a pice of data passed/given to a method for processing
      *********************************************************************************/

        /******************************************************************************
 * Background information - Data Types, conversion                            
 *
 * Computers can perform two types of arithmetic: integer and floating-point
 *
 * The type of arithmetic done depends on the data types of the
 * values in the operation
 *
 *   if both are int-type values, integer arithmetic is done
 *   if both are floating-point types, floating-point arithmetic is done
 *   if they one is an int-type and the other a floating-point type,
 *               the int-type is converted to a floating-point type (double)
 *               and floating-point arithmetic is done.
 *
 *   int-types:  int, long, short, uint, ushort, ulong
 *
 *   floating-point types: float, double, decimal
 *
 * an int can covert to a double, but a double can't convert to an int
 *
 *
 ***************************************************************************/


        // Every application has only one method called Main()
        //
        // Main() method signature
        //
        // static - indicates there can be one of this in an application
        //
        //      return
        //      name(parameters-it-may-accept)
        //
        static void Main(string[] args) // Main is a method that returns nothing and receives a string[] called args
        {
            Console.WriteLine("Sup West");

            int mySum = Addem(4, 5); // Send the numbers 4 and 5 to Addem to get sum
                                     // Addem() will be executed with the numbers 4 and 5
                                     // It will be the sum
                                     // which will be stored in the variable mySum

            int yoda = 97;
            int obiWan = 420;

            Console.WriteLine("The sum of 4 and 5 is: " + mySum);
            Console.WriteLine("The sum of 3 and 4 is: " + Addem(3, 4));
            Console.WriteLine("The sum of yoda and obiWan is: " + Addem(yoda, obiWan)); // Calling with two ints 
                                                                                        // Run the Addem that takes two ints

            Console.WriteLine("The sum of 3.1 and 4.5 is: " + Addem(3.1, 4.5)); // Calling with two doubles
                                                                                // Run the Addem that takes two doubles
            
            Console.WriteLine("The sum of 67 and 9.9 is: " + Addem(67, 9.9)); // Calling Attem with an int and a double
                                                                              // We don't have an Attem with an int and a double
                                                                              // It ran it as two doubles
                                                                              // C# Converts the int to a double  
        } // End of Main() method


        // After a method, you may define other methods that method can use
        // "Helper Methods" - helps a method to perform a specific task

        // Define a method to receive two numbers and return the sum
        //
        // If a method will be used by a static method, it must be static itself
        // Any method used by Main() must be static becasue Main() is stais
        //
        // return
        // type name(parameters)
        //
        // Addem is a method that receives two integers that it's calling num1 and num2
        //                      and returns the sum of the integers as an int
       static int Addem(int num1, int num2)
        {
            //Console.WriteLine("Addem(int, int) was called with " + num1 + " " + num2);
            return num1 + num2; // Add the two parameters and return the sum
        }
        // return double
        static double Addem(double num1, double num2)
        {
            //Console.WriteLine("Addem(double, double) was called with " + num1 + " " + num2);
            return num1 + num2; // Add the two parameters and return the sum
            // double + double - result is a double
            // return type must be a double
        }
    }
}
