using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
       


            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "David",
                LastName = "Pie",
                AnnualSalary = 60000
            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

            Console.WriteLine("-------------");

            ContractEmployee cte = new ContractEmployee()
            {
                ID = 102,
                FirstName = "Sam",
                LastName = "Brooks",
                HourlyPay = 100,
                TotalHoursWorked = 40
            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
            Console.ReadLine();
           
        }
    }
}
