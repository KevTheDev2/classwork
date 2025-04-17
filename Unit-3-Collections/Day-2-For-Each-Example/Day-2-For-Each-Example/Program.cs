namespace Day_2_For_Each_Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        // Ask the user to enter a sentence
        // (series of words separated by a whitespace -  space, tab, something you can't see)
        // Display each word of the sentence

        Console.WriteLine("Please enter a sentence");
        string sentence = Console.ReadLine();  // Get what they type and put it in a string.

        // .split() will extract parts of a string into an array based on the character inside
        string [] splitSentence = sentence.Split(" "); // Split the sentence into words (It's looking for whatever is between each "<space>")

        // Display each word in the sentence
        for (int i = 0; i < splitSentence.Length; i++)
        {
            // Note: to add 1 to i and use in the string we have to put it in ()
            //      .WriteLine() treats everything you gice it as a string
            //      + for a string meant concatenate
            //      + for a numeric means add
            //      i+1 in the output for WriteLine,
            //      it thinks I want to take the value of i and stick a 1 after it
            //      (i+1) - () indicates





            Console.WriteLine("Word #: " + (i+1) + " is " + splitSentence[i]);
        }

        // for each loop can also pass arrays and Lists
        //
        // Syntax:      foreach(datatype variable-name in array-or-list)
        //              datatype is the type of data in the array of list
        //              use variable name inside the foreach loop to access an element in the array
                    
        //
        // For each goes through the array or List from start to enf assigning each element to the variable
        //
        // * for-loop vs for-each loop
        //
        // Both process an array or a list from beginning to end
        // for-loop can start and end at any element by setting int i= and changing the condition
        // for-each ALWAYS processes from begining to the end
        // for-each you know which element number you're processing by using the value in i
        // for-each you do not know whick element number you're processing

        foreach (string aWord in splitSentence)
        {
            Console.WriteLine(aWord);
        }

        // Display all the words using a do-while loop
        //
        //  do
        //  {
        //  loop processing
        // }  while(condition) // loop while the condition is true
        //
        // We always do the loop processing at least once
        //    becasue the condition is checked at the end of the loop process  

        // Define a variable to keep track of the element in the array/List we are processing
        // We will use it as an index into array or List

        int currentElementNumber = 0;
        do
        {
            Console.WriteLine("Word #: " + (currentElementNumber + 1) + " is " + splitSentence[currentElementNumber]);
        } while (currentElementNumber < splitSentence.Length); // the loop will process all element numbers
    }// End of Main()


}