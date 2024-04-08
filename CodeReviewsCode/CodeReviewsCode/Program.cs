// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CodeReviewsCode
{
    using System;

    /// <summary>
    /// Main program class to run the program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method to run the program code.
        /// </summary>
        /// <param name="args">Commandline arguments.</param>
        public static void Main(string[] args)
        {
            // Creating instances of each Function object
            Function1 function1 = new Function1();
            int userInput = 0;

            // Fetching user input to use for all of the user-defined functions
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Enter an integer to use for all of the user-defined functions:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out userInput))
                {
                    validInput = true;
                }
            }

            // Setting the UserInput property of each Function object to the user input integer
            function1.UserInput = userInput;

            // Executing each Function object and display the output
            object outputOne = function1.Execute();

            Console.WriteLine($"Function1 Output: {outputOne.ToString()}");
        }
    }
}