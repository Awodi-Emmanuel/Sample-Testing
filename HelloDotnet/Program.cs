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
        
    }
    }

}