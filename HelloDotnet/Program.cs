// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        
    {
        Console.WriteLine(4 + 2);
        Console.WriteLine("I am Learning C#");
        
        // Variable Naming in C#
        // Declearing a String Value
        string  MyName = "emmanuel";

        // Declear a Integer variable
        int MyAge = 30;

        // Declear a Float Variable
        double MyHeight = 3.2;


        //Out a string value
        Console.WriteLine("My name is: " + MyName);
        

        // Output a integer value
        Console.WriteLine("I am : " + MyAge);

        //Output a Decimal Value
        Console.WriteLine("My height is : " + MyHeight);

        // Data Types
        int numInt = 100000; // numeric integer data type 
        Console.WriteLine("My integer Numeric data type", numInt);


        long numLong = 15000000000L; // numeric long data type
        Console.WriteLine("My long numeric data type: " + numLong);
        
        // Boolean Data Type
        bool isTRue = true;
        bool is_False = false;

        Console.WriteLine(isTRue);
        Console.WriteLine(is_False);

        // Type Casting
        int myIntCon = 6;
        double myDoubleCon = myIntCon; //implicit casting

        Console.WriteLine(myIntCon);
        Console.WriteLine(myDoubleCon);

        // explicit casting

        double myDoublen = 9.2;
        int doubleToInit = (int)myDoublen;

        Console.WriteLine(myDoublen);
        Console.WriteLine(doubleToInit);

        // Type Conversion Methods
        int myInt = 10;
        double myDouble = 5.25;
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myInt));
        Console.WriteLine(Convert.ToDouble(myInt));
        Console.WriteLine(Convert.ToInt32(myDouble));
        Console.Write(Convert.ToString(myBool));
    

    }
    }

}