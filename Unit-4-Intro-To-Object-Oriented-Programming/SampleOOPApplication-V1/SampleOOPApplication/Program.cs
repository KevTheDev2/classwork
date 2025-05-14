namespace SampleOOPApplication;

class Program
{
    // Application program will define and mainpulate objects
    static void Main(string[] args)
    {
        Console.WriteLine("------ Start of Sample Object Oriented Application Made From Scratch -------");
        
        Person aPerson = new Person("John", 78, 250.6, 69, "Male");
        Console.WriteLine($"aPerson: {aPerson}");

        Person aPerson2 = new Person("John", 78, 250.6, 69, "Male");
        Console.WriteLine($"aperson2: {aPerson2}");

        // Compare aPerson and aPerson2 to see if they are equal
       // if (aPerson == aPerson2) // == compares the reference value (loacation in memory)
            if (aPerson.Equals(aPerson2)) // .Equals() SHOULD ompare the content of the object
        {
            Console.WriteLine("They are equal");
        }
        else
        {
            Console.WriteLine("They are not equal");
        }



            Console.WriteLine("------ End of Sample Object Oriented Application Made From Scratch -------");
    } // End of Main()
}