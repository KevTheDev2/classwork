namespace Day_1_Student_Class_Example
{
    class Program
    {

        // This is an application program
        // it instantiates and uses objects to perform processing
        // Every application has exactly one method calle dmain


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Student Class Example");
            // Instanciate (define) a student class object
            // a class is a data type
            // Define an object of the class like any other variable with a slight difference

            // data-type name + initializers; int sum = 0;

            // A class is instantiated with the new keyword
            //         is initialized using one of the contructors
            // className name = new ClassName(initializers);
            // We need to be sure to have all the data we want to store in our object
            // Before we instantiate the object

            List<int> scores = new List<int> ();
            scores.Add(100);
            scores.Add(90);
            scores.Add(80);


           Student aStudent = new Student("Frank", scores);

            // Display the Student object we created
            // Console.WriteLine() does not know how to display an object of our class
            Console.WriteLine("aStudent: " + aStudent);
        }
    }
}
