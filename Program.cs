/*
    Author: Valentina Delgado-Rodriguez
    Date: 9/23/2020
    Comments:Create a console program that demonstrates a Method with the following instructions:
    a. Ask the User to enter their name.
    b. Write a Method that prints to the Console: "Hello user's name (insert real name)

*/

using System;
using System.IO;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           // ask the user to enter their name
           Console.WriteLine("Please enter your name: ");

            // Try-catch used to display a message if a user inputs characters that are not supported
            try
            {
                // console reads the input from user
                string input = Console.ReadLine();
                // the input from the user is then sent to the Enter_Name method which is called here
                Enter_Name(input);

            } // End of Try

            // Try-catch used to display a message if a user inputs characters that are not supported
            catch
            {
                Console.WriteLine("Please enter your name.");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // End of Catch
      
        } // End of Main

        // A method called Enter_Name is created to say hello to the user
        private static void Enter_Name(string name)
        {
            // the console will say hello to the user and call them by their name
            Console.WriteLine("Hello, " + name + ", nice to meet you.");
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);

        } // End of Enter_Name method
    } // End of Class
} // End of Namespace
