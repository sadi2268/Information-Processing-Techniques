using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareemUI
{
    public partial class SearchByAccessoriesForm : Form
    {
        List<string> cars;
        BindingSource carsBinding = new BindingSource();
        List<string> accessories;
        BindingSource accessoriesBinding = new BindingSource();
        Manager manager = new Manager();

        public SearchByAccessoriesForm()
        {
            InitializeComponent();
            populateCheckboxes();
        }

        public void populateCheckboxes()
        {
            accessories = manager.getAccessories();
            accessoriesBinding.DataSource = accessories;
            for(int index = 0; index<accessories.Count();index++)
            {
                accessoriesCheckedListBox.Items.Add(accessories[index]);
            }

        }

        private void accessoriesSubmitButton_Click(object sender, EventArgs e)
        {
            List<string> myAccessories = new List<string>();
            for (int index=0; index< accessoriesCheckedListBox.CheckedItems.Count; index++)
            {
                myAccessories.Add((string)accessoriesCheckedListBox.CheckedItems[index]);
            }
            cars = manager.passManagerAccessories(myAccessories);
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
