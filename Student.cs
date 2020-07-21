using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_humanity_1
{
    class Student : Person
    {

        private string FacultyNumber { get; set; }
        
        public void PrintStudent()
        {
            Console.WriteLine("\nFirst name : {0}", this.FirstName);
            Console.WriteLine("Last name : {0}", this.LastName);
            Console.WriteLine("Faculty number : {0}", this.FacultyNumber);
            Console.WriteLine("Gender : {0}\n", this.Gender);
            Console.WriteLine("-------------------------------------------------------------------------------");
        }
        //public void GetFirstName(string x)
        //{
        //    if (x.Length > 2)
        //        this.firstName = char.ToUpper(x[0]) + x.Substring(1);
        //    else
        //    {
        //        Console.WriteLine("Please give a valid firstname");
        //        GetFirstName(Console.ReadLine());
        //    }
        //}
        //public void GetLastName(string x)
        //{
        //    if (x.Length > 3)
        //        this.lastName = char.ToUpper(x[0]) + x.Substring(1);
        //    else
        //    {
        //        Console.WriteLine("Please give a valid lastname");
        //        GetLastName(Console.ReadLine());
        //    }
        //}
        public void GetFaculty(string x)
        {
            if (x.All(char.IsLetterOrDigit) && x.Length >= 5 && x.Length <= 10)
            {
                this.FacultyNumber = x;
            }
            else
            {
                Console.WriteLine("Please give a valid faculty number");
                GetFaculty(Console.ReadLine());
            }
        }

        public static void AddTo(List<Student> x)
        {
            Student student = new Student();

            Console.WriteLine("Give firstname");
            student.GetFirstName(Console.ReadLine());

            Console.WriteLine("Give lastname");
            student.GetLastName(Console.ReadLine());

            Console.WriteLine("Give faculty number");
            student.GetFaculty(Console.ReadLine());

            Console.WriteLine("\nSelect gender");
            Console.WriteLine("\n|1. Male\n|2. Female\n|3. Other");
            student.GetGender(Console.ReadLine());

            Console.WriteLine("\nStudent added!");
            Console.ReadKey();

            x.Add(student);
        }
    }
}
