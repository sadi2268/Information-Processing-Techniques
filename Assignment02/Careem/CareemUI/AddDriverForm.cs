using CareemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareemUI
{
    public partial class AddDriverForm : Form
    {
        Manager manager = new Manager();
        Driver driver;
        string vehicle;
        public AddDriverForm(string car)
        {
            InitializeComponent();
            vehicle = car;
        }

        private void driverSubmitButton_Click(object sender, EventArgs e)
        {
            string fname = null;
            string lname = null;
            string cnicNum = null;
            double ratingInput = 0.0;
            try
            {
                fname = this.firstNameTextBox.Text;
                lname = this.lastNameTextBox.Text;
                cnicNum = this.cnicTextBox.Text;
                ratingInput = Convert.ToDouble(this.ratingTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            driver = new Driver();
            driver.firstName = fname;
            driver.lastName = lname;
            driver.cnic = cnicNum;
            driver.rating = ratingInput;

            //string check = driver.firstName + driver.lastName + driver.cnic + driver.rating;
            //MessageBox.Show(check);

            bool worked = manager.passDriverObject(vehicle, driver);
            //MessageBox.Show(worked.ToString());
            if (worked)
            {
                MessageBox.Show("Driver added!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something seems wrong! :/");
                this.Close();
            }

        }
    }
}
