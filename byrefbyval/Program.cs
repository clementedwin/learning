using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byrefbyval
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //var emp = new Employee() { Id = 1, Name = "Clement" };
            //ChangeNameVal(emp);
            //if (emp != null)
            //    Console.WriteLine(emp.Name);
            //ChangeNameRef(ref emp);
            //if (emp != null)
            //    Console.WriteLine(emp.Name);


            //System.Collections.Generic.List<Shape> shapes = new System.Collections.Generic.List<Shape>();
            //shapes.Add(new Rectangle());
            //shapes.Add(new Triangle());
            //shapes.Add(new Circle());

            //foreach (Shape s in shapes)
            //{
            //    s.Draw();
            //}

            EmployeeFulltime empFt = new EmployeeFulltime()
                {
                     Id = 1,
                     Name = "Clement",
                     Age = 41,
                     AnnualSalary = 60000
                };

            EmployeeParttime empPt = new EmployeeParttime()
            {
                Id = 2,
                Name = "Edwin",
                Age = 42,
                HourlyPay = 150,
                NbOfHoursWorked = 300
            };

            PrintEmployeeDetails(empFt);
            PrintEmployeeDetails(empPt);

            List<EmployeeaBase> list = new List<EmployeeaBase>();
            list.Add(empFt);
            list.Add(empPt);

            foreach (var emp in list)
                emp.PrintSalary();

            Console.ReadLine();
        }

        static void ChangeNameRef(ref Employee emp)
        {
            emp.Name = "Edwin";
            emp = null;
        }

        static void ChangeNameVal(Employee emp)
        {
            emp.Name = "Edwin";           
        }

        static void PrintEmployeeDetails(EmployeeaBase emp)
        {
            Console.WriteLine("The employee id {0} is ", emp.Id );
            if(emp is EmployeeFulltime)
            {
                Console.WriteLine(((EmployeeFulltime)emp).AnnualSalary);
            }

            if (emp is EmployeeParttime)
            {
                Console.WriteLine(((EmployeeParttime)emp).NbOfHoursWorked * ((EmployeeParttime)emp).HourlyPay);
            }
        }
    }
}
