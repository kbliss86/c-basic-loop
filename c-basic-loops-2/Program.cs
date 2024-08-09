using System;

namespace c_basic_loops_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Description:
            Start a new console project, and repeat the same exercise as the previous, except this time implement it with a do-while loop.
            Code is 13579
            */

            /*
            Optional Stretch:
            Move the last while loop or the do-while loop into its own function. The function should return a true if access is granted, or a false if the user didn’t enter the correct code within 5 tries.
            */
            {
                //boolean variable that is equal to the result of the function call
                bool accessGranted = AttempAccess();//function call - tells the program to run the function

                if (accessGranted)//if the function returns true
                {
                    Console.WriteLine("Access Granted");//print this
                }
                else
                {
                    Console.WriteLine("Access Denied, try again later");//if the function returns false, print this
                }
            }

            bool AttempAccess()//difines what the function does when it called

            {
                int doorCode = 0;//initialize the door code
                int attempts = 0;//initialize the attempts

                do
                {
                    Console.WriteLine("Enter the door code: ");
                    doorCode = int.Parse(Console.ReadLine());
                    attempts++;//increment the attempts

                    if (doorCode == 13579)//if the door code is correct
                    {
                        return true;//return true
                    }
                    else if (attempts >= 5)//if the attempts are greater than or equal to 5
                    {
                        return false;//return false
                    }
                    else
                    {
                        Console.WriteLine("Access Denied, please try again");//if the door is incorrect and attempts are less than 5, print this
                    }

                } while (true);//do this while true
            }




        }
    }
}
