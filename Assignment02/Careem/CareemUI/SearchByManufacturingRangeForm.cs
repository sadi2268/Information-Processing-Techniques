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
    public partial class SearchByManufacturingRangeForm : Form
    {
        public SearchByManufacturingRangeForm()
        {
            InitializeComponent();
        }

        ushort fromYear, toYear;
        Manager manager = new Manager();
        List<string> cars;
        BindingSource carsBinding = new BindingSource();

        private void manufacturingRangeSubmitButton_Click(object sender, EventArgs e)
        {
            fromYear = Convert.ToUInt16(this.fromYearTextBox.Text);
            toYear = Convert.ToUInt16(this.toYearTextBox.Text);
            if (toYear >= fromYear)
            {
                cars = manager.passManagerManufacturingRange(fromYear, toYear);
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
