// This is a comment - everything after it is ignored

/*
 *  This is a block comment. EVerything between the slash-asterisk 
 *  and asterisk-slash is ignored
 *  
 *  Useful if you have a lot to say or if you want to deactivate some code
 *  
 the * at the start of each line is optional
 * */

// a namespace identifies a context in which a word is known
// Allows the same name to be used in different context to mean different things
// Indents in the code are for humans to read easier
namespace First_ProjectA
{
    // everything in C# is defined in a class
    // class - a group of related things*
    // a Class starts with the class keyword
    class Program

        // { } surround blocks of code aka code-blocks or scope/identifiyer
    { // Start of the code or class
            // Every application has a method called Main()
            // a method is a self-contained code that performs a function
            // aka function or program
            // A method may return a value and accept data to process
            // Method signature identifies what the method returns, it's name, and what it accepts
            // Return-type name(data-it-accepts)
            // Main() is where every application starts
            // Every applications has one and only one Main() method

            // Below main() is a method that returns void and accepts string[] called args
            //
            // void means it retuens nothing
            // static means there can only be one of these in this block (program class)
           
        
            // return
            // type  name(data-it-accepts)
        static void Main(string[] args) // method signature
        {// Start of the code for Main()
            // This code will display whatever is between then("") on the screen

            // Console is an object defined by C# to represent the screen
            // an object has certain behaviors
            // A behavior is something an object can do with data
            // Behavior are implemented using methods

            // object.method(data) - object oriented programming
            //
            // when you see a "." after a name, the name to the left is probably an object
            //          name( , the name is a method)
            //          name after ".", the name is usually a method 
            //      object.method(data-for-the-method-to-process)

            Console.WriteLine("Hello, KGII!"); // EVERY C# STATEMENT ENDS WITH A ";"
        }
    } // End of the code for main()
} // end of the code for the class
