using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = 0;
            //while(number < 10)
            //{ 
            //        Console.WriteLine($"Number is {++number}");
            //}
            //Console.WriteLine("Enter a Word");
            //var userInput = Console.ReadLine();
            //while(userInput.Length < 15)
            //{
            //    userInput += 'a';
            //    Console.WriteLine(userInput);
            //}
            //string word;
            //do
            //{
            //    Console.WriteLine("Enter a word longer than 10 letters");
            //    word = Console.ReadLine();
            //} while (word.Length <= 10);
            //int[] numbers = new[] { 10, -5, 45, -9, -98, 35, 78, -9 };
            //int neg;
            //var ans = OnlyPositive(numbers,out neg);
            //foreach(var ele in ans)
            //{
            //    Console.WriteLine(ele);
            //}
            //Console.WriteLine(neg);
            //bool isParsingSuccessfull;
            //do
            //{
            //    Console.WriteLine("Enter a Number");
            //    var userInput = Console.ReadLine();
            //    isParsingSuccessfull = int.TryParse(userInput, out int number);
            //    if (isParsingSuccessfull)
            //    {
            //        Console.WriteLine("The Parsing was successfull " + number);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not able to Parse");
            //    }
            //} while (!isParsingSuccessfull);
            var myBday = new DateTime(2000, 11, 9);
            Console.WriteLine(myBday.DayOfWeek);
            var myNextBday = myBday.AddYears(24);
            Console.WriteLine(myNextBday.DayOfWeek);
            Console.WriteLine(myNextBday.Year);
            Console.WriteLine(myNextBday.Month);
            Console.WriteLine(myNextBday.Day);

            //var words = new List<string>
            //{ 
            //    "apple",
            //    "dog",
            //    "elephant",
            //    "Billo Rani",
            //    "Sheila"
            //};

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word); 
            //}
            //Console.WriteLine(words.Count);
            //Console.WriteLine(words.IndexOf("Billo Rani"));
            //Console.WriteLine(words.IndexOf("Chikni Chameli"));
            //words.Remove("Billo Rani");
            //for(int i = 1; i<= words.Count;i++)
            //{
            //    Console.WriteLine(words[^i]);
            //}
            ////Console.WriteLine(words.Find("dog"));
            ////Console.WriteLine(words.Find("cat"));
            //words.RemoveAt(0);
            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}
            ////List<string> moreWords = new List<string> { "xyz","abc"};
            //words.AddRange(new [] { "xyz","abc"});
            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}



            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i*i;
            //}
            //Console.WriteLine(nums[^1]);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine($"value at nums[{i}] : {nums[i]}");
            //}
            //Console.WriteLine("Enter first Number");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second Number");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("What Operation DO you want to Do");
            //PrintDescription();
            //var ch = Console.ReadLine();
            //ch.ToLower();
            //if (ch == "a")
            //{
            //    Console.WriteLine($"{num1} + {num2} = {Add(num1,num2)}");
            //}
            //else if (ch == "s")
            //{
            //    Console.WriteLine($"{num1} - {num2} = {Subtract(num1, num2)}");
            //}
            //else if (ch == "m")
            //{
            //    Console.WriteLine($"{num1} * {num2} = {Product(num1, num2)}");
            //}
            //else if (ch == "d")
            //{
            //    Console.WriteLine($"{num1} / {num2} = {Divide(num1, num2)}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid choice");
            //}
            //Console.WriteLine("Hit any key to close");
            Console.ReadKey();
        }
        static List<int> OnlyPositive(int[] num, out int countNeg)
        {
            countNeg = 0;
            List<int> res = new List<int>();
            foreach (int ele in num)
            {
                if (ele > 0)
                {
                    res.Add(ele);
                }
                else
                {
                    countNeg++;
                }
            }
            return res;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Product(int a, int b)
        {
            return a * b;
        }
        static double Divide(int a, int b)
        {
            return (double)a / b;
        }
        static void PrintDescription()
        {
            Console.WriteLine("[A]dd the numbers");
            Console.WriteLine("[S]ubtract the numbers");
            Console.WriteLine("[M]ultiply the numbers");
            Console.WriteLine("[D]ivide the numbers");
        }
    }
}
