namespace Day_1_Student_Class_Example;

class Program
{
    // This is an application program 
    // It instantiates and uses objects to perform processing
    // Every application has exactly one method called Main()
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Student Class Example");
        
    // Instantiate (define) a Student class object       
    // A class is data type
    // Define an object of a class liek any other variable with a slight difference
    
    // data-type name = initializer;  int sum = 0;
    
    // A class is instantiated with the new keyword 
    //         is initiaized using one of its constructors
    // className name = new className(initializers);
    
    // We need to be sure have all the data we want to store in our object
    // Before we instantiate the object
    List<double> scores = new List<double>();
    scores.Add(100);
    scores.Add(90);
    scores.Add(80);
    
    List<double> scores2 = new List<double>();
    scores2.Add(100);
    scores2.Add(100);
    scores2.Add(100);

    // Instantiate a Student using the data we want to store in the Student object
    // ClassName objName = new class(initial name-name, initial scores

    Student aStudent = new Student("Frank", scores); // calling the 2 arg that takes a name

    Student aStudent2 = new Student("Marquise", scores2); //


        // Display the Student object we created
        // Console.WriteLine() does not now how to display an object of our class
        Console.WriteLine("aStudent: " + aStudent);
    
    // Use the Student class method to display Student class object
    //
    // object.method() <--- object oriented notations
    aStudent.ShowStudent();

    Console.WriteLine($"The sum of scores: {aStudent.SumOfScores()}");
    Console.WriteLine($"The average of scores: {aStudent.AvgOfScores()}");


    aStudent2.ShowStudent();

    Console.WriteLine($"The sum of scores: {aStudent2.SumOfScores()}");
    Console.WriteLine($"The average of scores: {aStudent2.AvgOfScores()}");

        // Define a student with no scores
        Student johnTheStudent = new Student("John");
        johnTheStudent.ShowStudent();
        // Add some scores to johnTheStudent

        johnTheStudent.AddScore(86);
        johnTheStudent.AddScore(90.5);
        johnTheStudent.AddScore(20);
        johnTheStudent.AddScore(67.6);
        johnTheStudent.AddScore(99);
        johnTheStudent.AddScore(100);

        johnTheStudent.ShowStudent(); // Display the data in the Student Object
        johnTheStudent.AddScore(90.7);
        johnTheStudent.AddScore(92.3);

        Console.WriteLine($"The sum of scores: {johnTheStudent.SumOfScores()}"); // 
        Console.WriteLine($"The average of scores: {johnTheStudent.AvgOfScores()}");
        //Console.WriteLine(aStudent.studentName);
    }
}