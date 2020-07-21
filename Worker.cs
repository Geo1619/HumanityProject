using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_humanity_1
{
    class Worker : Person
    {
        private int hoursPerDay;
        private double weekSalary;
        private double WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; } 
        }
        private int HoursPerDay 
        {
            get { return hoursPerDay; }
            set { hoursPerDay = value; }
        }
 
         private double SalaryPerHour 
        {              
            get { return  (this.WeekSalary / (this.HoursPerDay * 5)); }
        }


        public void PrintWorker()
        {
            Console.WriteLine("\nFirst name : {0}", this.FirstName);
            Console.WriteLine("Last name : {0}", this.LastName);
            Console.WriteLine("Week salary : {0:0.00}", this.WeekSalary);
            Console.WriteLine("Hours per day : {0}", this.HoursPerDay);
            Console.WriteLine("Salary per hour : {0:0.00}", this.SalaryPerHour);
            Console.WriteLine("Gender : {0}\n", this.Gender);
            Console.WriteLine("-------------------------------------------------------------------------------");
        }

 
        public void GetSalary(string x)
        {
            
            if (!double.TryParse(x, out this.weekSalary) && WeekSalary <= 10)
            {
                Console.WriteLine("Please give a valid Salary");
                GetSalary(Console.ReadLine());
            }
            
        }
        public void GetHours(string x)
        {
            
            if (!int.TryParse(x, out this.hoursPerDay) || this.hoursPerDay <= 1 || this.hoursPerDay >= 12)
            {
                
                Console.WriteLine("Please give a valid timeline");
                GetHours(Console.ReadLine());
            }
            
        }

        public static void AddTo(List<Worker> x)
        {
            Worker worker = new Worker();

            Console.WriteLine("Give firstname");
            worker.GetFirstName(Console.ReadLine());

            Console.WriteLine("\nGive lastname");
            worker.GetLastName(Console.ReadLine());

            Console.WriteLine("\nGive salary");
            worker.GetSalary(Console.ReadLine());

            Console.WriteLine("\nGive hours of work per day");
            worker.GetHours(Console.ReadLine());

            Console.WriteLine("\nSelect gender");
            Console.WriteLine("\n|1. Male\n|2. Female\n|3. Other");
            worker.GetGender(Console.ReadLine());

            Console.WriteLine("\nWorker added!");
            Console.ReadKey();

            x.Add(worker);
        }
        
    }                        
}
