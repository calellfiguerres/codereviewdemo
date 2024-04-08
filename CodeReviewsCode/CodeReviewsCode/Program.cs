namespace CodeReviewsCode
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
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
            function2.UserInput = userInput;
            function3.UserInput = userInput;
            function4.UserInput = userInput;
            
            // Executing each Function object and display the output
            object outputOne = function1.Execute();

            Console.WriteLine($"Function1 Output: {outputOne.ToString()}");
            Console.WriteLine($"Function2 Output: {outputTwo.ToString()}");
            Console.WriteLine($"Function3 Output: {outputThree.ToString()}");
            Console.WriteLine($"Function4 Output: {outputFour.ToString()}");
        }
    }
}