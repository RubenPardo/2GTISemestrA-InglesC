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
        // atributes
        private string id;// auto generated unique value
        private string name;
        private string type;
        private string manufacturer;
        private string description;
        private string price;
        private string stock;

        private string[] typesAllowed = { "sensor", "micro" };

        // properties
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
            // it can't be empty text and will be always normalize "text->"Text"
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
            // only can take the "SENSOR"|"MICRO" values, will be normalize
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
            // it can't be empty text and will be always normalize "text->"Text"
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
            // it can be empty text and will be always normalize "text->"Text"
            set
            {
                Console.WriteLine(value);
                description = Utility.normalizeText(value);
            }
        }

        public string PRICE
        {
            get { return price; }
            // try to convert to double and not negative
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
                // only positive integer numbers
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


        // constructor
        public Product(string id, string name, string type, string manufacturer, string description, string price, string stock)
        {
            ID = id;
            NAME = name;
            TYPE = type;
            MANUFACTURER = manufacturer;
            DESCRIPTION = description;
            PRICE = price;
            STOCK = stock;
        }

        // sirve para cuando creamos un producto nuevo 
        public Product()
        {
            ID = Utility.generateID();

        }

        // methods 
        private bool isValidType(string type)
        {
            return typesAllowed.Contains(type.ToLower());
        }

        //regex \b^[0-9]\d*\b no puede ser porque permite poner 2323.11212 y lo detecta como dos
        // por tanto se debe usar esto: ^[0-9]\d*$ el $ indica que es solo una unica cadena, sin puntos ni espacios permitidos
        // ponemos el ^ delante para solo pillar numeros, de otra forma si se pone un espacio lo pilla o un punto
        private bool isPositiveIntegerValue(string number)
        {


            Match match = Regex.Match(number, @"^[0-9]\d*$");

            return match.Success;

        }
        // regex = ^[0-9]\d*.\d*$ -> lo mismo que antes pero el valor es solo si son digitos positvios separados por un punto
        private bool isPositiveDecimalValue(string number)
        {

            Match matchInteger = Regex.Match(number, @"^[0-9]\d*$");
            // poner 12 de precio tambien es valido
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
    }
}