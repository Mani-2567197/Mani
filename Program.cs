using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string EmployeName;
            char Employegender;
            double salary;
            DateTime Doj;
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter EmployeName");
            EmployeName = Console.ReadLine();
            Console.WriteLine("Enter EmployeGender");
            Employegender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            Doj = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Id : \t" + id + "\n EmployeNAme: " +EmployeName + "\n EmployeGender: \t"
                + Employegender + "\n Salary: \t  " + salary + "\n Date of Joining: \t " + Doj);
            Console.ReadKey();
            if (salary > 90000)
            {
                Console.WriteLine("You have to pay 30% tax");
            }
            else
            {
                Console.WriteLine("You have to pay 15% tax");
            }
        }
    }
}
