using System;

namespace Inheritance2
{
    public class Manager : Employee
    {
        public int TeamSize { get; }

        public Manager(string name, decimal baseSalary, int teamSize)
            : base(name, baseSalary)
        {
            TeamSize = teamSize;
        }

        public override decimal CalculateBonus()
        {
            return base.CalculateBonus() + (100m * TeamSize);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }
}