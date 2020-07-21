using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_humanity_1
{
    class Person
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string Gender { get; set; }



        public virtual void GetFirstName(string x)
        {
            if (x.Length > 2)
                this.FirstName = char.ToUpper(x[0]) + x.Substring(1);
            else
            {
                Console.WriteLine("Please give a valid firstname");
                GetFirstName(Console.ReadLine());
            }
        }
        public virtual void GetLastName(string x)
        {
            if (x.Length > 3)
                this.LastName = char.ToUpper(x[0]) + x.Substring(1);
            else
            {
                Console.WriteLine("Please give a valid lastname");
                GetLastName(Console.ReadLine());
            }
        }
        public void GetGender(string x)
        {

            switch (x)
            {
                case "1": this.Gender = "Male"; break;
                case "2": this.Gender = "Female"; break;
                case "3": this.Gender = "Other"; break;
                default:
                    Console.WriteLine("Please give a valid Gender");
                    GetGender(Console.ReadLine()); break;
            }
        }
    }
}
