using System;

namespace Inheritance2
{
    public class Employee
    {
        public string Name { get; }
        public decimal BaseSalary { get; }

        public Employee(string name, decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }
        public virtual decimal CalculateBonus()
        {
            return BaseSalary * 0.10m;
        }

            
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee: {Name}");
            Console.WriteLine($"Base Salary: {BaseSalary:C}");
        }
    }
}