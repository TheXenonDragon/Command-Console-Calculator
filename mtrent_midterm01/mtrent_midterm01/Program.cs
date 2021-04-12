using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtrent_midterm01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created by: Micah Trent
            //Project Name: Command-Line Calculator



            //Main Loop
            do
            {
                WelcomeMessage();
                double UserChoice = TestUserInput(Console.ReadLine());

                //Add numbers
                if (UserChoice == 1)
                {
                    Console.Write("Enter the first number: ");
                    double FirstUserNum = TestUserInput(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double SecondUserNum = TestUserInput(Console.ReadLine());

                    AddNumbers(FirstUserNum, SecondUserNum);
                }
                //Subtract Numbers
                else if (UserChoice == 2)
                {
                    Console.Write("Enter the first number: ");
                    double FirstUserNum = TestUserInput(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double SecondUserNum = TestUserInput(Console.ReadLine());

                    SubtractNumbers(FirstUserNum, SecondUserNum);
                }
                //Multiply Numbers
                else if (UserChoice == 3)
                {
                    Console.Write("Enter the first number: ");
                    double FirstUserNum = TestUserInput(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double SecondUserNum = TestUserInput(Console.ReadLine());

                    MultiplyNumbers(FirstUserNum, SecondUserNum);
                }
                //Divide Numbers
                else if (UserChoice == 4)
                {
                    Console.Write("Enter the first number: ");
                    double FirstUserNum = TestUserInput(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double SecondUserNum = TestUserInput(Console.ReadLine());

                    DivideNumbers(FirstUserNum, SecondUserNum);
                }
                //Exit the Program
                else if (UserChoice == 5)
                {
                    break;
                }
                //If user's number is outside of menu range
                else
                {
                    Console.WriteLine("You entered the number {0}.  Please enter an integer between 1 and 5.", UserChoice);
                }
                Console.Write("\nPress any key to restart: ");
                Console.ReadKey();
                Console.Clear();
            } while (true);

            Console.Write("You are exiting the program. . .");
            Console.ReadKey();
        }

        static void WelcomeMessage()
        {
            //Displays a welcome message and a list of options for the user to pick from.
            Console.WriteLine("Welcome to the Command-Line Calculator!");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Choose an option:\n1. Add two numbers\n2. Subtract two numbers\n3. Multiply two numbers" +
                "\n4. Divide two numbers\n5. Exit the program");
            Console.WriteLine("---------------------------------------");
            Console.Write("Enter your selection: ");
        }

        static void AddNumbers(double a, double b)
        {
            //Adds variables "a" and "b" together
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        static void SubtractNumbers(double a, double b)
        {
            //Subtracts variable "b" from variable "a"
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }

        static void MultiplyNumbers(double a, double b)
        {
            //Multiplies variables "a" and "b" together
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }

        static void DivideNumbers(double a, double b)
        {
            //Divides variable "a" by variable "b"

            if (b == 0)
            {
                Console.WriteLine("You cannot divide a number by zero.");
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            }
        }

        static double TestUserInput(string UserInput)
        {
            //Tests the user input in order determine whether it is an double/valid number or not.

            double UserNumber;
            do
            {
                if (Double.TryParse(UserInput, out UserNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("{0} is not a valid input.", UserInput);
                    Console.Write("Please enter a number: ");
                    UserInput = Console.ReadLine();
                }
            } while (true);

            //Returns the converted value
            return UserNumber;
        }
    }
}
