using System;

namespace c_basic_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Description:
            Use a do-while loop to output "Hello, World!" in a loop. Each time you output "Hello, World!" ask the user whether they would like to continue.
            */

            string userResponse = "";//declare outside of loop so it can be used in the while condition
            do
            {
                Console.WriteLine("Hello, World! - Would you like to continue? (y/n)");
                userResponse = Console.ReadLine();
            } while (userResponse == "y");
            
            /*
            Description:
            Prompt the user for a number. Use a for loop to output all the numbers from that number to 0. After that loop finishes, use another loop to output all the numbers from 0 to that number.
            */
            
            int userNumber = 0;//declare outside of loop so it can be used in the for loop

            Console.WriteLine("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());

            for (int i = userNumber; i >= 0; i--)//use -- to count down
            {
                Console.WriteLine("Counting down: " + i);
            }

            for (int v = 0; v < userNumber;  v++)//use ++ to count up
            {
                Console.WriteLine("Counting up: " + v);
            }

            /*
            Description:
            A door has a keypad entry. The combination to get in is 13579. Write a while loop (not a do-while loop) that asks the user to enter a key code. The loop will repeat as long as the user enters the wrong code. After the user enters the correct code, the program will print out a welcome message.
            */

            int userCode = 0;

            while (userCode != 13579)//use a logical operator to check if the userCode is not equal to the correct code, if it returns true, the loop will continue, if it returns false, the loop will end
            {
                Console.WriteLine("Enter the 5 digit key code: ");
                userCode = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Welcome Home Sir");

            /*
            Description:
            Continue the previous exercise, but now add a limited number of tries, say 5. After 5 unsuccessful attempts, the loop ends, but instead of printing a welcome message, it prints a message warning that there were too many incorrect attempts. (But if the user entered the correct number, it will still print the welcome message as before.)
            */
            int userCode2 = 0;//declare outside of loop so it can be used in the for loop
            bool isCorrect = false;//declare outside of loop so it can be used in the for loop

            for (int z = 0; z < 5; z++)//use a for loop to limit the number of tries

            {
                Console.WriteLine("Enter the 5 digit key code: ");
                userCode2 = int.Parse(Console.ReadLine());
                if (userCode2 == 13579)//use conditional statement to check if the userCode is equal to the correct code
                {
                    isCorrect = true;//if the userCode is correct, set isCorrect to true
                    break;//break out of the loop
                }
            }//end of for loop

            if (isCorrect)//use a conditional statement to check if isCorrect is true
            {
                Console.WriteLine("Welcome Home Sir");
            }
            else
            {
                Console.WriteLine("Too many incorrect attempts, please try again later.");
            }

            
        }
    }
}
