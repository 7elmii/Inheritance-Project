using System;

namespace Inheritance2
{
    public class Intern : Employee
    {
        public string School { get; }

        public Intern(string name, decimal stipend, string school)
            : base(name, stipend)
        {
            School = school;
        }

        public override decimal CalculateBonus()
        {
            return 0m;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"School: {School}");
        }
    }
}