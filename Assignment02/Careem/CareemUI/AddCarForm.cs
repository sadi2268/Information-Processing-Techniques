using CareemEntities;
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
    public partial class AddCarForm : Form
    {
        List<string> accessories;
        BindingSource accessoriesBinding = new BindingSource();

        Manager manager = new Manager();
        string RegNum;
        Vehicle vehicle;
        public AddCarForm(string car)
        {
            InitializeComponent();
            RegNum = car;
            populateCheckboxes();
        }

        public void populateCheckboxes()
        {
            accessories = manager.getAccessories();
            accessoriesBinding.DataSource = accessories;
            for (int index = 0; index < accessories.Count(); index++)
            {
                accessoriesCheckedListBox.Items.Add(accessories[index]);
            }
        }


        private void vehicleSubmitButton_Click(object sender, EventArgs e)
        {
            string make = null;
            string model = null;
            string type = null;
            int year = 0;
            long imei = 0;

            List<string> myAccessories = new List<string>();
            for (int index = 0; index < accessoriesCheckedListBox.CheckedItems.Count; index++)
            {
                myAccessories.Add((string)accessoriesCheckedListBox.CheckedItems[index]);
            }

            try
            {
                make = this.makeTextBox.Text;
                model = this.modelTextBox.Text;
                type = this.typeTextBox.Text;
                year = Convert.ToInt32(this.yearTextBox.Text);
                imei = Convert.ToInt64(this.imeiTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                return;
            }
            if(make=="" || model=="" || type=="" || year==0)
            {
                MessageBox.Show("Compulsory fields must have some value!");
                Close();
                return;
            }
            vehicle = new Vehicle();
            vehicle.RegNum = RegNum;
            vehicle.make = make;
            vehicle.model = model;
            vehicle.type = type;
            vehicle.year = year;
            vehicle.ImeiNum = imei;
            vehicle.Accessories = myAccessories;
            //MessageBox.Show(check);

            bool worked = manager.passVehicleObject(vehicle);
            //MessageBox.Show(worked.ToString());
            if (worked)
            {
                MessageBox.Show("Vehicle added!");
                Close();
            }
            else
            {
                MessageBox.Show("Something seems wrong! :/");
                Close();
            }

        }
    }
}
