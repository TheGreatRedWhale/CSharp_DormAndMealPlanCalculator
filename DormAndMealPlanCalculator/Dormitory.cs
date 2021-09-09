using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormAndMealPlanCalculator
{
    public class Dormitory
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public Dormitory(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public Dormitory(string name, int cost)
        {
            Name = name;
            Cost = (double)cost;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} per Semester.", Name, Cost.ToString("C2"));
        }
    }
}
