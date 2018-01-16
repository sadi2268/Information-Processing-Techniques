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
    public partial class SearchByRatingsForm : Form
    {
        public SearchByRatingsForm()
        {
            InitializeComponent();
        }
        double fromRating, toRating;
        Manager manager = new Manager();
        List<string> cars;
        BindingSource carsBinding = new BindingSource();

        private void ratingsSubmitButton_Click(object sender, EventArgs e)
        {
            fromRating = Convert.ToDouble(this.fromRatingTextBox.Text);
            toRating = Convert.ToDouble(this.toRatingTextBox.Text);
            if (toRating >= fromRating)
            {
                cars = manager.passManagerRatingsRange(fromRating, toRating);
                carsBinding.DataSource = cars;
                resultsListBox.DataSource = carsBinding;

                if (cars.Count != 0)
                {
                    resultsListBoxLabel.Visible = true;
                    resultsListBox.DisplayMember = "cars";
                }
                else
                    MessageBox.Show("No results!");

            }
            else
            {
                MessageBox.Show("Wait... You don't know how numbers work?!");
            }
        }

    }
}
