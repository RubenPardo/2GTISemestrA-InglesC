using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PardoCasanova_BenitezEstruch
{
    // with the product list we can desarelize directly from json to an array of objects
    class ProductList
    {
        public List<Product> products { get; set; }
    }
}
