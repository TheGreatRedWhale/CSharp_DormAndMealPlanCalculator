using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormAndMealPlanCalculator
{
    public partial class SelectionsForm : Form
    {
        List<Dormitory> dormitories = new List<Dormitory>();

        public SelectionsForm()
        {
            InitializeComponent();
            createDorms();
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

        private void dormsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
