using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_Student_Class_Example
{
    // internal attribute was removed so we can use this class anywhere
    
    // public - anyone can use this class
    // class - this is the definition of a C# class
    // Student is the name of the class - Classname are is PascalCase

    // A class is a description of an object that's used in object oriented programming
    // A class contains data class member/class data and methods (class methods)
    // A class is a programmer defined data type (much like an int, string, double, List<>)
    // Because it is a PROGRAMMER defined data type, the programmer is responsible for:
    //
    //      the data in the class
    //      the methods that manipulate the class data (behaviors of the object)
    // class can do whatever a programmer decides it should do or shouldn't do
    public class Student
    {
        // define the data for our class
        // private indicates only member of a class can access the data
        // Private implements thw Object-Oriented principal Encapsulation
        // **Encapsulation** - Class should protect the data from outside access
        //                  only methods in the class can access the
        //                  
        //                  users of the class access the data using methods
        //                  defined in the class.
        // Note: the data is defined without an initial value
        //       Class data should be initialized in constructors
       private string studentName;
        private List<int> testScores;

        // define methods for the class

        // One special method for a class is called acontructor
        // A constructor is responsible for initilizing the data in a class
        // (data shiuld never be uninitialized - the starting value needs to be knonw)

        // a contructor method is special because:
        //
        // 1. it has no return type; not even void
        // 2. it has the same name as the class
        // 3. it may or may not receive parameters (initializers)
        //      ( a contructor with no parameters is called a default constructor)

        // Define a constructor to initialize our data with values
        //          specified by the user

        public Student(string name, List<int> scores)
        {
            studentName = name;
            testScores = scores;
        }

        // Provide a method to display our data 
        // (Console.WriteLine() doesn't know how to do
        public void ShowStudent()
        {
            Console.WriteLine("Name: " )
        }

    }
}
