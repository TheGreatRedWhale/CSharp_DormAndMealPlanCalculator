using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormAndMealPlanCalculator
{
    class MealPlan
    {
        public int MealsPerWeek { get; set; }
        public double Cost { get; set; }

        public MealPlan(int mealsPerWeek, double cost)
        {
            MealsPerWeek = mealsPerWeek;
            Cost = cost;
        }

        public MealPlan(int mealsPerWeek, int cost)
        {
            MealsPerWeek = mealsPerWeek;
            Cost = (double)cost;
        }

        public override string ToString()
        {
            if (MealsPerWeek < 0)
            {
                return string.Format("{0} meals per week: {1} per Semester.", MealsPerWeek.ToString(), Cost.ToString("C2"));
            }
            else
            {
                return string.Format("Unlimited meals per week: {0} per Semester.", Cost.ToString("C2"));
            }
        }
    }
}
