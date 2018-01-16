using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareemUI
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void makeAndModelButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            SearchByMakeAndModelForm f1 = new SearchByMakeAndModelForm();
            f1.ShowDialog();
            //this.Dispose();
        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            SearchByManufacturingRangeForm f1 = new SearchByManufacturingRangeForm();
            f1.ShowDialog();
        }
        private void ratingsButton_Click(object sender, EventArgs e)
        {
            SearchByRatingsForm f1 = new SearchByRatingsForm();
            f1.ShowDialog();
        }
        private void accessoriesButton_Click(object sender, EventArgs e)
        {
            SearchByAccessoriesForm f1 = new SearchByAccessoriesForm();
            f1.ShowDialog();
        }
    }
}
