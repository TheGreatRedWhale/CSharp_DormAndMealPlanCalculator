using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormAndMealPlanCalculator
{
    public partial class SelectionsForm : Form
    {
        List<Dormitory> dormitories = new List<Dormitory>();
        List<MealPlan> mealPlans = new List<MealPlan>();

        public SelectionsForm()
        {
            InitializeComponent();
            createDorms();
            createMealPlans();
        }

        public void addDorm(string name, int cost)
        {
            dormitories.Add(new Dormitory(name, cost));
            dormsListView.Items.Add(name).
                SubItems.Add(cost.ToString("C2"));
        }

        public void createDorms()
        {
            addDorm(name: "Allen Hall", cost: 1500);
            addDorm(name: "Pike Hall", cost: 1600);
            addDorm(name: "Farthing Hall", cost: 1800);
            addDorm(name: "University Suites", cost: 2500);
        }

        public void refreshDorms()
        {
            dormsListView.Clear();
            for (int i = 0; i < dormitories.Count; i++)
            {
                dormsListView.Items.Add(dormitories[i].Name).
                    SubItems.Add(dormitories[i].Cost.ToString("C2"));
            }
        }

        public void addMealPlan(int mealsPerWeek, int cost)
        {
            mealPlans.Add(new MealPlan(mealsPerWeek, cost));
            if (mealsPerWeek == -1)
            {
                mealsListView.Items.Add("Unlimited").
                    SubItems.Add(cost.ToString("C2"));
            }
            else
            {
                mealsListView.Items.Add(mealsPerWeek.ToString()).
                    SubItems.Add(cost.ToString("C2"));
            }
        }

        public void createMealPlans()
        {
            addMealPlan(mealsPerWeek: 7, cost: 600);
            addMealPlan(mealsPerWeek: 14, cost: 1200);
            addMealPlan(mealsPerWeek: -1, cost: 1700);
        }

        public void refreshMealPlans()
        {
            mealsListView.Clear();
            for (int i = 0; i < mealPlans.Count; i++)
            {
                if (mealPlans[i].MealsPerWeek == -1) {
                    mealsListView.Items.Add("Unlimited").
                        SubItems.Add(mealPlans[i].Cost.ToString("C2"));
                } else {
                    mealsListView.Items.Add(mealPlans[i].MealsPerWeek.ToString()).
                        SubItems.Add(mealPlans[i].Cost.ToString("C2"));
                }
            }
        }

        public void calculate()
        {
            try
            {
                int dormCost = Int32.Parse(dormsListView.SelectedItems[0].SubItems[1].Text.ToString(), NumberStyles.Currency);
                int mealPlanCost = Int32.Parse(mealsListView.SelectedItems[0].SubItems[1].Text.ToString(), NumberStyles.Currency);
                MessageBox.Show((dormCost + mealPlanCost).ToString("C2"));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n-----\n" + e.StackTrace);
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            calculate();
        }
    }
}
