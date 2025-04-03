namespace StringExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*******************************************************************************
             * Strings in C# are a special data type - they don't work like you think they should
             * 
             * String literals are enclosed in " "
             * 
             * A literal is something that says what it is: 1 1,24 bob
             * 
             * String variables sometimes require special processing
             *      you can't use < > to compare strings
             *      Beware; early versions of C# don't allow you to use == with strings
             *      
             *      C# provides several methods to operate on string:
             *      
             *          .Equals(string) - compare the string to the left of the . to string inside() for equals
             *          .CompareTo(string) - returns a number indicating how the first string relates to the second
             *                               returns a negative number if the first string is less than the second
             *                               return a zero if the first string is equal to the second
             *                               return a positive number if first string is greater than the second
             *                              
             ******************************************************************************/

            // if (condition) {
            //      What to do if condition is true
            // }
            // else {
            //      What to do if condition is false
            //}
            //
            // 
            string string1 = "a";
            string string2 = "a";
             if (string1.CompareTo(string2) < 0) // If these lines are equal
            {
                Console.WriteLine("string1 is greater than string2");
            }
            else
            {
                Console.WriteLine("string1 is NOT less than string2");
            }
        }
    }// End of Main()
}// end of Class Program
