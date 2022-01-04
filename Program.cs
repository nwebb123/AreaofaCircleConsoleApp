using System;

namespace AreaofaCircleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Instructions
            Write a C# program to calculate the "area of a circe" based on a given "radius" value
            Formula: PI * radius * radius
            PI is a constant value, approximately equal to 3.14159, which is equal to the ratio of the circumference of any circle to its diameter.
            */


            //Start of App
            Console.WriteLine("The purpose of this console app is to find the area of a circle given a radius from the user");

            Console.WriteLine("Please enter a radius for a given circle.");

            //Input from the user is by default a string, need to explicitly convert it to a double
            double radius =  Convert.ToDouble(Console.ReadLine());

            //Declare variables        
            double pi = 3.14159;
            double areaOfCircle = (pi * radius * radius);

            Console.WriteLine($"The area of the circle is {areaOfCircle}");       
            Console.WriteLine("Press any button to exit");
            Console.ReadLine();
          
        }
    }
}



