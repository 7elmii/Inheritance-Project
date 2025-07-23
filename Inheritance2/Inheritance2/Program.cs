using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
        {
            static void Main()
            {
                var staff = new List<Employee>
            {
                new Employee("Alice", 50000m),
                new Manager("Bob", 75000m, teamSize: 5),
                new Intern("Charlie", 15000m, school: "State University")
            };

                foreach (var emp in staff)
                {
                    emp.DisplayInfo();
                    Console.WriteLine($"Calculated Bonus: {emp.CalculateBonus():C}");
                    Console.WriteLine(new string('-', 40));
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
}