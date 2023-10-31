using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQTOObjectDemo
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public int Salary { get; set; }

       



    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>()
            { 
               new Employee { Id = 1,Name="pradnya",City="pune",Salary=75000},
               new Employee { Id = 2,Name="pooja",City="mumbai",Salary=65000},
               new Employee { Id = 3,Name="priti",City="satara",Salary=55000},
               new Employee { Id = 4,Name="Tanuja",City="sangali",Salary=45000},
               new Employee { Id =5,Name="sakshi",City="kolhapur",Salary=35000},
               new Employee { Id =6,Name="rohan",City="delhi",Salary=25000},
               new Employee { Id =7,Name="anuj",City="panjab",Salary=36000},
               new Employee { Id = 8,Name="vaibhav",City="pune",Salary=15000},
               new Employee { Id = 9,Name="vijay",City="nagar",Salary=63000},
               new Employee { Id = 10,Name="raj",City="mumbai",Salary=69000},
                     
            };
           /*LINQ-->*/ var result = from e in Employees
                         where e.City == "pune"
                         select e;

            //foreach (Employee item in result)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}
/*-------------------------------------------------------------------------------------------------------------------*/
            var result2 = from e in Employees
                          where e.Name.StartsWith("v")
                          select e;
            //foreach (Employee item in result2)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}


            /*-------------------------------------------------------------------------------------------------------------------*/
            var result3 = from e in Employees
                          where e.Salary > 24000 && e.City == "pune"
                          select e;


            //foreach (Employee item in result3)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}

            /*-------------------------------------------------------------------------------------------------------------------*/

            // var result4 = Employees.Where(x => x.City == "mumbai").ToList();
            var result4 = Employees.Where(x => x.City == "pune").OrderBy(x => x.Salary).ToList();
            foreach (Employee item in result4)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            }



        }
    }
}
