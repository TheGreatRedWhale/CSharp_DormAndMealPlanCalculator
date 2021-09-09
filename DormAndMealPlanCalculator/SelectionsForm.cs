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
        public SelectionsForm()
        {
            InitializeComponent();
            createDorms();
        }

        private void addDorm(string dormName, int dormCost)
        {
            dormsListView.Items.Add(dormName).
                SubItems.Add(dormCost.ToString("C"));
        }

        private void createDorms()
        {
            addDorm(dormName: "Allen Hall", dormCost: 1500);
            addDorm(dormName: "Pike Hall", dormCost: 1600);
            addDorm(dormName: "Farthing Hall", dormCost: 1800);
            addDorm(dormName: "University Suites", dormCost: 2500);
        }
    }
}
