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
    public partial class SearchByMakeAndModelForm : Form
    {
        public SearchByMakeAndModelForm()
        {
            InitializeComponent();

        }

        string make, model;
        Manager manager = new Manager();
        List<string> cars;
        BindingSource carsBinding = new BindingSource();

        private void makeAndModelSubmitButton_Click(object sender, EventArgs e)
        {
            make = this.makeTextBox.Text;
            model = this.modelTextBox.Text;

            cars = manager.passManagerMakeAndModel(make, model);

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
    }
}
