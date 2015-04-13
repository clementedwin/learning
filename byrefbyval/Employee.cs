using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byrefbyval
{
    class EmployeeaBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public  virtual void PrintSalary()
        {

        }
    }

    class EmployeeFulltime : EmployeeaBase
    {
        public int AnnualSalary { get; set; }
        public override void PrintSalary()
        {
            Console.WriteLine(AnnualSalary);
        }
    }


    class EmployeeParttime : EmployeeaBase
    {
        public int HourlyPay { get; set; }
        public int NbOfHoursWorked { get; set; }
        public override void PrintSalary()
        {
            Console.WriteLine(HourlyPay * NbOfHoursWorked);
        }
    }
}
