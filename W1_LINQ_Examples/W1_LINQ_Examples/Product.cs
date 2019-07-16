using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1_LINQ_Examples
{
    class Product
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public int QuantityInStock { get; set; }
        public float UnitPrice { get; set; }
        public int CategoryID { get; set; }

        public override string ToString()
        {
            return String.Concat("Product ID : ", ProductID.ToString(),
                                 ", Description : ", Description.ToString(),
                                 ", Quanity in Stock : ", QuantityInStock.ToString(),
                                 ", Unit Price :", UnitPrice.ToString(),
                                 ", Category Id : ", CategoryID.ToString()
                                 );
        }
    }
}
