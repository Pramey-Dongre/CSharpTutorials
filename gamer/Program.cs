using System;

namespace gamer
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //a = 79;
            //Console.WriteLine(a);
            Console.WriteLine("Enter the First Number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the sum is: " + (number1 + number2));
            Console.WriteLine("the diff is: " + (number1 - number2));
            int t = number2;
            number2 = number1;
            number1 = t;
            Console.WriteLine("the product is: " + (number1 * number2));
            Console.WriteLine("the division is: " + ((double)number1 / number2));
            //var userChoice = Console.ReadLine();
            //bool isUserInputAbc = userChoice == "ABC";
            //if (isLengthGreaterThan7(userChoice))
            //{
            //    PrintThalaStyle("Bole jo koyal");
            //}
            //else
            //{
            //    PrintThalaStyle("Not thala certified: "+ userChoice);
            //}
            //int result = Add(60, 9);
            //Console.WriteLine("result is: "+result);
            Console.ReadKey();
        }
        static void PrintThalaStyle(string message)
        {
            Console.WriteLine("Thaala says: "+message);
        }
        static int Add(int a , int b)
        {
            return a + b; 
        }
        static bool isLengthGreaterThan7(string userInput)
        {
            return userInput.Length >= 7;
        }
    }
}