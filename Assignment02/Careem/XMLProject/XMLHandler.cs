using CareemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Schema;

namespace XMLProject
{
    public class XMLHandler
    {
        //Change these lines as per the respective paths in your PC.
        string XMLDB = @"C:/Users/Israr/source/repos/Careem/XMLProject/bin/Debug/CareemXmlDatabase.xml";
        string XMLSch = @"C:/Users/Israr/source/repos/Careem/XMLProject/bin/Debug/CareemXmlSchema.xsd";

        public XMLHandler()
        {
            //
        }
        public List<string> queryByMakeAndModel(string newMake, string newModel)
        {
            List<string> cars = new List<string>();
            string make = newMake.ToLower().Trim();
            string model = newModel.ToLower().Trim();
            XElement vehiclesDocument = XElement.Load(XMLDB);
            IEnumerable<XElement> vehicles;
            if (model != "")
            {
                vehicles = from vehicle in vehiclesDocument.Elements()
                           where ((string)vehicle.Element("make")).ToLower() == make && ((string)vehicle.Element("model")).ToLower() == model
                           orderby (string)vehicle.Element("RegNum")
                           select vehicle;
            }
            else
            {
                vehicles = from vehicle in vehiclesDocument.Elements()
                           where ((string)vehicle.Element("make")).ToLower() == make
                           orderby (string)vehicle.Element("RegNum")
                           select vehicle;
            }

            foreach (XElement vehicle in vehicles)
            {
                string car = (string)vehicle.Element("RegNum") + " | " + (string)vehicle.Element("make") + " | " + (string)vehicle.Element("model") + " | " + ((string)vehicle.Element("year")).Trim('Z') + " | " + (string)vehicle.Element("type");
                cars.Add(car);
            }
            return cars;
        }
        public List<string> queryByManufacturingRange(ushort fromYear, ushort toYear)
        {
            List<string> cars = new List<string>();
            XElement vehiclesDocument = XElement.Load(XMLDB);
            IEnumerable<XElement> vehicles;
            vehicles = from vehicle in vehiclesDocument.Elements()
                       where Convert.ToUInt16(((string)vehicle.Element("year")).Trim('Z')) >= fromYear && Convert.ToUInt16(((string)vehicle.Element("year")).Trim('Z')) <= toYear
                       orderby (string)vehicle.Element("year")
                       select vehicle;

            foreach (XElement vehicle in vehicles)
            {
                string car = (string)vehicle.Element("RegNum") + " | " + (string)vehicle.Element("make") + " | " + (string)vehicle.Element("model") + " | " + ((string)vehicle.Element("year")).Trim('Z') + " | " + (string)vehicle.Element("type");
                cars.Add(car);
            }

            return cars;
        }
        public List<string> queryByRatingsRange(double fromRating, double toRating)
        {
            List<string> cars = new List<string>();
            XElement vehiclesDocument = XElement.Load(XMLDB);
            IEnumerable<XElement> vehicles;
            vehicles = from vehicle in vehiclesDocument.Elements()
                       where vehicle.Element("drivers") != null && (double)vehicle.Element("drivers").Element("driver").Element("rating") >= fromRating && (double)vehicle.Element("drivers").Element("driver").Element("rating") <= toRating
                       orderby (double)vehicle.Element("drivers").Element("driver").Element("rating")
                       select vehicle;

            foreach (XElement vehicle in vehicles)
            {
                string car = (string)vehicle.Element("RegNum") + " | " + (string)vehicle.Element("make") + " | " + (string)vehicle.Element("model") + " | " + ((string)vehicle.Element("year")).Trim('Z') + " | " + (string)vehicle.Element("type");
                cars.Add(car);
            }

            return cars;
        }
        public List<string> queryByAccessories(List<string> accessories)
        {
            List<string> cars = new List<string>();
            XElement vehiclesDocument = XElement.Load(XMLDB);
            IEnumerable<XElement> vehicles;
            vehicles = from vehicle in vehiclesDocument.Elements()
                       //where vehicle.Element("accessories") != null && accessories.Equals(vehicle.Element("accessories").Element("accessory"))
                       where vehicle.Element("accessories") != null
                       select vehicle;

            foreach (XElement vehicle in vehicles)
            {
                List<string> carAccess = new List<string>();
                var acc = vehicle.Element("accessories");
                var acce = "";
                foreach (XElement access in acc.Descendants())
                {
                    carAccess.Add((string)access);
                    acce += (string)access + " / ";
                }
                if (Enumerable.SequenceEqual(accessories.OrderBy(t => t), carAccess.OrderBy(t => t)))
                {
                    string car = (string)vehicle.Element("RegNum") + " | " + acce;
                    cars.Add(car);
                }

            }

            return cars;
        }

        public List<string> getAllUniqueAccessories()
        {
            List<string> accessories = new List<string>();

            XElement vehiclesDocument = XElement.Load(XMLDB);
            IEnumerable<XElement> vehicles = (from
                                 vehicle in vehiclesDocument.Descendants("accessory")
                                              orderby (string)vehicle
                                              select
                                              vehicle).GroupBy(x => x.Value).Select(x => x.First()).ToList();
            foreach (XElement vehicle in vehicles)
            {
                accessories.Add((string)vehicle);
            }

            return accessories;
        }

        public bool deleteVehicleByRegNum(string RegNum)
        {
            XDocument vehiclesDocument = XDocument.Load(XMLDB);
            try
            {
                vehiclesDocument.Element("vehicles").Elements("vehicle").Where(x => x.Element("RegNum").Value == RegNum).Remove();
                vehiclesDocument.Save(XMLDB);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getCar(string RegNum)
        {
            XElement vehiclesDocument = XElement.Load(XMLDB);
            try
            {
                List<string> cars = new List<string>();

                var query = from vehicle in vehiclesDocument.Elements()
                            where (string)vehicle.Element("RegNum") == RegNum
                            select vehicle;

                foreach(XElement car in query)
                {
                    cars.Add((string)car.Element("RegNum"));
                }
                return cars.Count;
            }
            catch
            {
                return 0;
            }
        }

        public int getDriver(string cnic)
        {
            XElement vehiclesDocument = XElement.Load(XMLDB);
            try
            {
                List<string> drivers = new List<string>();

                /*
                 //Works only if the driver is the first one in the list of drivers.
                var query = from vehicle in vehiclesDocument.Elements()
                            where (string)vehicle.Element("drivers").Element("driver").Element("cnic") == cnic
                            select vehicle;
                */
                //Ideally, we want to delete ANY driver, regardless of their position. So:
                var query = vehiclesDocument.Descendants("vehicle").Where( v =>
                v.Descendants("driver").Any( d => (string)d.Element("cnic")==cnic)
                    );


                foreach (XElement car in query)
                {
                    drivers.Add((string)car.Element("RegNum"));
                }
                return drivers.Count;
            }
            catch
            {
                return 0;
            }
        }

        public bool addDriverToVehicle(string RegNum, Driver driver)
        {
            //Load DB as an XDocument
            XDocument DbDocument = XDocument.Load(XMLDB);
            //Create driver as an XElement to write to file
            XElement driversEle = new XElement("drivers");
            XElement carElement = new XElement("driver",
                    new XElement("FirstName", driver.firstName),
                    new XElement("LastName", driver.lastName),
                    new XElement("cnic", driver.cnic),
                    new XElement("rating", driver.rating)
                );
            bool validated = false;
            var query = from car in DbDocument.Descendants("vehicle")
                        where (string)car.Element("RegNum") == RegNum
                        select car;
            int count = 0;
            foreach (XElement car in query)
            {
                count++;
                //When a new car is added, it has no drivers. To handle it,
                //we first add an empty drivers node. 
                if (car.Element("drivers") == null)
                {
                    car.Add(driversEle);
                }
                //And then add a driver to the vehicle.
                car.Element("drivers").Add(carElement);
                DbDocument.Element("vehicles").Elements("vehicle").Where(x => x.Element("RegNum").Value == RegNum).Remove();
                DbDocument.Element("vehicles").Add(car);
                /*
                //Individual constraints are checked like datatypes 
                //but not the global constraints like uniqueness 
                //which is why we use another technique instead this one.
                carDocument = new XDocument(
                    new XElement("vehicles", car)
                    );
                    */
                validated = validationProc(DbDocument);
            }
            if (validated)
            {
                DbDocument.Save(XMLDB);
            }
            return validated;
        }

        public bool addVehicle(Vehicle vehicle)
        {
            //Load DB as an XDocument
            XDocument DbDocument = XDocument.Load(XMLDB);
            
            long imei = vehicle.ImeiNum;
            List<string> accessories = vehicle.Accessories;
            //Create driver as an XElement to write to file
            XElement car = new XElement("vehicle",
                    new XElement("RegNum", vehicle.RegNum),
                    new XElement("make", vehicle.make),
                    new XElement("model", vehicle.model),
                    new XElement("year", vehicle.year),
                    new XElement("type", vehicle.type)
                    );
            if (imei != 0)
            {
                car.Add(new XElement("imei", imei));
            }
            if (accessories.Count>0)
            {
                XElement accessEle = new XElement("accessories");
                for(int index=0; index< accessories.Count; index++)
                {
                    accessEle.Add(new XElement("accessory", accessories[index]));
                }

                car.Add(accessEle);
            }

            bool validated = false;
            DbDocument.Element("vehicles").Add(car);
            validated = validationProc(DbDocument);
            if (validated)
            {
                DbDocument.Save(XMLDB);
            }
            return validated;
        }

        public bool validationProc(XDocument node)
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", XMLSch);
            
            bool errors = false;

            node.Validate(schemas, (o, e) =>
            {
                string errorMessage = e.Message;
                errors = true;
            });                 //Create a breakpoint here to read the actual error message (Not displayed on UI)

            return errors ? false : true;
        }

        public bool deleteDriverByCnic(string cnic)
        {
            XDocument vehiclesDocument = XDocument.Load(XMLDB);
            try
            {
                vehiclesDocument.Descendants("drivers").Elements("driver").Where(x => x.Element("cnic").Value == cnic).Remove();
                vehiclesDocument.Save(XMLDB);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}
