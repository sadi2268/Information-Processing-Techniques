using CareemEntities;
using XMLProject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CareemUI
{
    class Manager
    {
        XMLHandler myXmlHandler;

        public Manager()
        {
            myXmlHandler = new XMLHandler();
        }

        public List<string> passManagerMakeAndModel(string make, string model)
        {
            List<string> cars;

            cars = myXmlHandler.queryByMakeAndModel(make, model);

            return cars;
        }

        public List<string> passManagerManufacturingRange(ushort from, ushort to)
        {
            List<string> cars;

            cars = myXmlHandler.queryByManufacturingRange(from, to);

            return cars;
        }
        public List<string> passManagerRatingsRange(double from, double to)
        {
            List<string> cars;

            cars = myXmlHandler.queryByRatingsRange(from, to);

            return cars;
        }
        public List<string> passManagerAccessories(List<string> accessories)
        {
            List<string> cars;

            cars = myXmlHandler.queryByAccessories(accessories);

            return cars;
        }

        public List<string> getAccessories()
        {
            List<string> accessories;

            accessories = myXmlHandler.getAllUniqueAccessories();

            return accessories;
        }

        public bool passManagerRegNum(string regNum)
        {
            return myXmlHandler.deleteVehicleByRegNum(regNum);
        }

        public int getCar(string regNum)
        {
            return myXmlHandler.getCar(regNum);
        }

        public int getDriver(string cnic)
        {
            return myXmlHandler.getDriver(cnic);
        }

        public bool passManagerCnic(string cnic)
        {
            return myXmlHandler.deleteDriverByCnic(cnic);
        }

        public bool passDriverObject(string vehicle, Driver driver)
        {
            return myXmlHandler.addDriverToVehicle(vehicle, driver);
        }

        public bool passVehicleObject(Vehicle vehicle)
        {
            return myXmlHandler.addVehicle(vehicle);
        }
    }
}
