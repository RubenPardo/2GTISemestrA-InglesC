using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PardoCasanova_BenitezEstruch
{
    class Product
    {
        private string id;
        private string name;
        private string type;
        private string manufacturer;
        private string description;
        private string price;
        private string stock;

        private string[] typesAllowed = { "sensor", "micro" };

        public string ID
        {
            get { return id; }
            set
            {
                Console.WriteLine(value);
                if (!Utility.isTextEmpty(id))
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentException("ID can not be empty");
                }
            }
        }

        public string NAME
        {
            get { return name; }
            set
            {
                Console.WriteLine(value);
                if (!Utility.isTextEmpty(value))
                {
                    name = Utility.normalizeText(value);
                }
                else
                {
                    throw new ArgumentException("Name can not be empty");
                }

            }
        }

        public string TYPE
        {
            get { return type; }

            set
            {
                Console.WriteLine(value);
                if (isValidType(value))
                {
                    type = value.ToUpper();
                }
                else
                {
                    throw new ArgumentException("Invalid type of product");

                }

            }
        }

        public string MANUFACTURER
        {
            get { return manufacturer; }

            set
            {
                Console.WriteLine(value);
                if (!Utility.isTextEmpty(value))
                {
                    manufacturer = Utility.normalizeText(value);
                }
                else
                {
                    throw new ArgumentException("Manufacturer can not be empty");
                }

            }
        }

        public string DESCRIPTION
        {
            get { return description; }

            set
            {
                Console.WriteLine(value);
                description = Utility.normalizeText(value);
            }
        }

        public string PRICE
        {
            get { return price; }

            set
            {
                Console.WriteLine(value);
                if (isPositiveDecimalValue(value))
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("Price should be a positive number");
                }
            }
        }
        public string STOCK
        {
            get { return stock; }
            set
            {
                Console.WriteLine(value);

                if (isPositiveIntegerValue(value))
                {
                    stock = value;
                }
                else
                {
                    throw new ArgumentException("Stock should be a positive integer number");
                }
            }
        }


        public Product( string name, string type, string manufacturer, string description, string price, string stock)
        {
            ID = Utility.generateID();
            NAME = name;
            TYPE = type;
            MANUFACTURER = manufacturer;
            DESCRIPTION = description;
            PRICE = price;
            STOCK = stock;
        }


        public Product()
        {
            ID = Utility.generateID();

        }


        private bool isValidType(string type)
        {
            return typesAllowed.Contains(type.ToLower());
        }


        private bool isPositiveIntegerValue(string number)
        {


            Match match = Regex.Match(number, @"^[0-9]\d*$");

            return match.Success;

        }

        private bool isPositiveDecimalValue(string number)
        {

            Match matchInteger = Regex.Match(number, @"^[0-9]\d*$");
            if (matchInteger.Success)
            {
                return true;
            }
            Match matchDecimal = Regex.Match(number, @"^[0-9]\d*.\d*$");
            if (matchDecimal.Success)
            {
                return true;
            }

            return false;

        }


        public override string ToString() {
            return NAME;
        }
    }
}