using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace datagen
{
    class Program
    {
        static void Main(string[] args)
        {
            int ROWS = 50000;
            string filename = "ProductPopulation.sql";
            string nq1 = "DECLARE @var1 int;\n";
            File.WriteAllText(filename, nq1);

            string pname;
            int pcid;
            string pdesc;
            int active = 1;
            double pprice;
            int pricefactor;
            Random random = new Random();

            List<string> SizeList = new List<string>() { "Extra Small", "Small", "Medium", "Large", "Extra Large" };
            List<string> ColorList = new List<string>() { "Blue", "Red", "Green", "Purple", "Black", "Orange", "Yellow", "White", "Pink" };
            List<string> UnitList = new List<string>() { "cm", "inches", "meter", "ft" };
            List<string> MaterialList = new List<string>() { "Cotton", "Leather", "Denim", "Velvet", "Satin", "Lawn", "Khaki", "Jeans" };

            List<int> clothid = new List<int>() { 1, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            List<int> furnitureid = new List<int>() { 2, 20, 21, 22, 23, 24, 25 };

            //loop begins
            for(int outerloop = 0; outerloop < ROWS; outerloop++)
            {

                string qstring = @"INSERT INTO PRODUCT(ProductName, PrimaryCategoryId, ProductDescription, Active, ProductPrice, OtherAttributes) Values(";

                StringBuilder buildername = new StringBuilder();
                StringBuilder builderdesc = new StringBuilder();

                char ch;
                for (int i = 0; i < 100; i++)
                {
                    if (i < 10)
                    {
                        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                        buildername.Append(ch);
                    }
                    ch = ' ';
                    if (random.NextDouble() > 0.5 && i < 10)
                    {
                        buildername.Append(ch);
                    }
                    else if (random.NextDouble() < 0.2 && i > 15)
                    {
                        builderdesc.Append(ch);
                    }
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    builderdesc.Append(ch);
                }
                pname = buildername.ToString().ToLower();
                pdesc = builderdesc.ToString().ToLower();

                pcid = random.Next(1, 32);
                pricefactor = random.Next(10, 101);
                pprice = Math.Round(random.NextDouble() + pricefactor, 2);

                int length = random.Next(10, 51);
                int width = random.Next(5, 21);
                int height = random.Next(10, 151);
                int inputwatts = random.Next(100, 2501);
                string materialtype = MaterialList[random.Next(0, 8)];
                int warranty = random.Next(1, 10);


                XElement OtherAttributes = new XElement("OtherAttributes");
                XElement Sizes = new XElement("Sizes");
                XElement Colors = new XElement("Colors");
                XElement Dimensions = new XElement("Dimensions");

                for (int index = 0; index < random.Next(1, 5); index++)
                {
                    XElement size = new XElement("Size", SizeList[index]);
                    Sizes.Add(size);
                }
                for (int index = 0; index < random.Next(1, 10); index++)
                {
                    XElement color = new XElement("Color", ColorList[index]);
                    Colors.Add(color);
                }
                string unit = UnitList[random.Next(0, 4)];
                XElement Length = new XElement("Length", length + " " + unit);
                Dimensions.Add(Length);
                XElement Width = new XElement("Width", width + " " + unit);
                Dimensions.Add(Width);
                XElement Height = new XElement("Height", height + " " + unit);
                Dimensions.Add(Height);

                if (pcid == 21)
                {
                    XElement InputWatts = new XElement("InputWatts", inputwatts + " watts");
                    OtherAttributes.Add(InputWatts);
                }

                OtherAttributes.Add(Sizes);
                OtherAttributes.Add(Colors);
                OtherAttributes.Add(Dimensions);
                if (pcid == 21)
                {
                    XElement InputWatts = new XElement("InputWatts", inputwatts + " watts");
                    OtherAttributes.Add(InputWatts);
                }
                if (clothid.Contains(pcid))
                {
                    XElement MaterialType = new XElement("MaterialType", materialtype);
                    OtherAttributes.Add(MaterialType);
                }
                if (furnitureid.Contains(pcid))
                {
                    XElement Warranty = new XElement("Warranty", warranty + " years");
                    OtherAttributes.Add(Warranty);
                }
                qstring += "'" + pname + "', ";
                qstring += pcid + ", ";
                qstring += "'" + pdesc + "', ";
                qstring += active + ", ";
                qstring += pprice + ", ";
                qstring += "'" + OtherAttributes + "');\n";
                File.AppendAllText(filename, qstring);

                string nq2 = "SELECT @var1 = @@IDENTITY;\n";
                File.AppendAllText(filename, nq2);

                List<int> ListCat = new List<int>() { pcid };
                for (int index = 0; index < random.Next(0, 6); index++)
                {
                    string seccat = "INSERT INTO ProductSecondaryCategory VALUES(@var1, ";
                    int secid = random.Next(1, 32);

                    if (!ListCat.Contains(secid))
                    {
                        seccat += secid;
                        ListCat.Add(secid);
                    }
                    else break;
                    seccat += ");\n";
                    File.AppendAllText(filename, seccat);

                }
            }

        }
    }
}
