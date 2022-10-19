using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week2
{
    public class Program
    {
        public static Employee FindMaxAgeEmployee(Employee[] emp)
        {
            var max = emp[0];
            for (int i = 1; i < emp.Length; i++)
                if (max.Age <= emp[i].Age)
                    max = emp[i];
            return max;
        }

        public static void Main()
        {
            Employee[] empArray = new Employee[] {
        new Employee(){Id=1, FirstName="Ali", LastName="kilic", Employees="Emp1", Age=25 },
        new Employee(){Id=2, FirstName="Adnan", LastName="yildiz", Employees="Emp2", Age=30 },
        new Employee(){Id=3, FirstName="Muhammet", LastName="önder", Employees="Emp3", Age=45 },
        new Employee(){Id=4, FirstName="Kenan", LastName="yildirim", Employees="Emp4", Age=50 },
        new Employee(){Id=5, FirstName="Mehmet", LastName="aslan", Employees="Emp5", Age=18 },
        new Employee(){Id=6, FirstName="Mert", LastName="can", Employees="Emp6", Age=23 },
        new Employee(){Id=7, FirstName="Sinan", LastName="Dag", Employees="Emp7", Age=24 },
        new Employee(){Id=8, FirstName="su", LastName="sahin", Employees="Emp8", Age=22 },
        new Employee(){Id=9, FirstName="zeynep", LastName="kaya", Employees="Emp9", Age=20 },
        new Employee(){Id=10, FirstName="İlayda", LastName="yigid", Employees="Emp10", Age=19 },
        };

            foreach (var emp in empArray)
                Console.WriteLine($"{emp.Id} {emp.FirstName} {emp.LastName} {emp.Age}");

            var empMax = FindMaxAgeEmployee(empArray);
            Console.WriteLine($"{empMax.Id} {empMax.FirstName} {empMax.LastName} {empMax.Age}");
        }
    }
}