using System;
using System.Collections.Generic;

namespace Lab_humanity_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool choice = false;
            List<Student> Students = new List<Student>();
            List<Worker> Workers = new List<Worker>();
            Worker work = new Worker();

            do
            {
                Console.Clear();
                Console.WriteLine("Choose an option\n");
                Console.WriteLine("1. Add worker\n");
                Console.WriteLine("2. Show workers\n");
                Console.WriteLine("3. Add student\n");
                Console.WriteLine("4. Show students\n");
                Console.WriteLine("5. End program\n");
                string input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1":
                        Worker.AddTo(Workers);
                        break;
                    case "2":
                        Workers.ForEach(x => x.PrintWorker());
                        Console.WriteLine("\nTotal number of workers: {0}", Workers.Count);
                        Console.ReadKey();
                        break;
                    case "3":
                        Student.AddTo(Students);
                        break;
                    case "4":
                        Students.ForEach(x => x.PrintStudent());
                        Console.WriteLine("\nTotal number of students: {0}", Students.Count);
                        Console.ReadKey();
                        break;
                    case "5":
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("Choose a valid option");
                        Console.ReadKey();
                        break;
                }
            }
            while (!choice);
        }
    }
}
