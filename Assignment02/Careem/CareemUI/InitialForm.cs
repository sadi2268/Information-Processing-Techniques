using System;
using CareemEntities;
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
    public partial class InitialForm : Form
    {
        Manager manager = new Manager();
        public InitialForm()
        {
            InitializeComponent();
        }

        private void searchVehicleButton_Click(object sender, EventArgs e)
        {
            SearchForm f1 = new SearchForm();
            f1.Show();
        }

        private void deleteVehicleButton_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the registration number of the vehicle", "Delete Vehicle", "ABCD1234", -1, -1);
            //MessageBox.Show(input);
            int car = 0;
            car = manager.getCar(input);
            if (car == 0)
            {
                MessageBox.Show("No such car exists..");
                return;
            }
            bool deleted = false;
            deleted = manager.passManagerRegNum(input);
            if (deleted)
            {
                MessageBox.Show("Car deleted!");
            }
            else
            {
                MessageBox.Show("Something seems wrong! :/");
            }
        }

        private void deleteDriverButton_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter CNIC number of the driver", "Delete Driver", "12345-1234567-1", -1, -1);
            //MessageBox.Show(input);
            int driver = 0;
            driver = manager.getDriver(input);
            if (driver == 0)
            {
                MessageBox.Show("No such driver exists..");
                return;
            }

            bool deleted = false;
            deleted = manager.passManagerCnic(input);
            if (deleted)
            {
                MessageBox.Show("Driver deleted!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something seems wrong! :/");
                this.Close();
            }
        }

        private void addDriverButton_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the registration number of the vehicle that you want to add driver to:", "Add Driver", "ABCD1234", -1, -1);
            int car = 0;
            car = manager.getCar(input);
            if (car == 0)
            {
                MessageBox.Show("No such car exists..");
                return;
            }
            //if car==1 means the car exists, 
            //now for the real trick, I'd like to have a volunteer on stage
            else if (car == 1)
            {
                AddDriverForm f1 = new AddDriverForm(input);
                f1.Show();
            }
            //MessageBox.Show(car.ToString());

        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the registration number of the vehicle that you want to add:", "Add Vehicle", "1234wxyz", -1, -1);
            int car = 0;
            car = manager.getCar(input);
            if (car > 0)
            {
                MessageBox.Show("A car with the same Registration Number already exists..");
                return;
            }
            else if (car == 0)
            {
                AddCarForm f1 = new AddCarForm(input);
                f1.Show();
            }

        }

    }
}
