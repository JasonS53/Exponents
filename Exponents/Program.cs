using System;

namespace Exponents
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = getInput();

            runProgram(x);
        }
        public static void runProgram(int x)
        {
            bool loopProgram = true;
            while (loopProgram)
            {
                
                if (x < 0)
                {
                    Console.WriteLine("Please enter a positive number");
                    break;
                }
                else if (x > 1290)
                {
                    Console.WriteLine("That number is too large to calculate");
                    break;
                }
                else
                {
                    DisplayResult(x);
                    break;
                }

            }
            Console.WriteLine("Do you want to continue? y/n");
            while (true)
            {
                string continueResult = Console.ReadLine();
                if (continueResult == "y")
                {
                    break;
                }
                else if (continueResult == "n")
                {
                    loopProgram = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid input");
                }

            }
        }
       
        public static int getInput()
        {
            Console.WriteLine("Please enter an integer: ");
            int input = int.Parse(Console.ReadLine());//user input               
                return input;//return back number    
        }
        static int Square(int x)
        {
        return x * x;
        }
        static int Cube(int x)
        {
        return x * x * x;
        }
        static void DisplayResult(int result)
        {
            Console.WriteLine("Number          Squared       Cubed");
            Console.WriteLine("=======         ========      ======");
            Console.WriteLine($"{result}\t\t{Square(result)}\t\t{Cube(result)}");
        }
        static void CountUp(int value)
        {
            for (int i = 1; i <= value; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
