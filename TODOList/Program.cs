using System;
using System.Collections.Generic;

namespace TODOList
{
    class Program
    {
        static List<string> myTodoList = new List<string>();
        static void Main(string[] args)
        {
            string userChoice;
            do
            {
                PrintDescription();
                userChoice = Console.ReadLine();
                userChoice.ToLower();
                if(userChoice == "s")
                {
                    SeeTodo();
                }
                else if(userChoice == "a")
                {
                    Console.WriteLine("Enter a TODO: ");
                    string newTodo = Console.ReadLine();
                    AddTodo(newTodo);
                    SeeTodo();
                }
                else if(userChoice == "r")
                {
                    Console.WriteLine("Which one do you want to Remove");
                    SeeTodo();
                    var choice = Console.ReadLine();
                    bool isParsed = int.TryParse(choice, out int num);
                    if(isParsed && 1 <= num && num <= myTodoList.Count)
                    {
                        RemoveTodo(num);
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid Number");
                    }
                }
                else if(userChoice == "e")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a Valid Choice");
                }
                Console.WriteLine("Press any key to continue...");
            } while (userChoice != "e");
            Console.ReadKey();
        }
        static void PrintDescription()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What do you want to do ?");
            Console.WriteLine("[S]ee all TODO's");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");
        }
        static void SeeTodo()
        {
            if(myTodoList.Count == 0)
            {
                Console.WriteLine("TODOList is empty");
                return;
            }
            for(int i =0;i<myTodoList.Count;i++)
            {
                Console.WriteLine($"{i+1}. {myTodoList[i]}");
            }
            return;
        }
        static void AddTodo(string todo)
        {
            if(!myTodoList.Contains(todo))
            {
                myTodoList.Add(todo);
            }
            else
            {
                Console.WriteLine("Already Exists, Enter a new Todo");
            }
        }
        static void RemoveTodo(int index)
        {
            myTodoList.RemoveAt(index - 1);
        }
    }
}
