using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1_LINQ_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductModel db = new ProductModel();
            List<Category> Query1 = db.Categories;
            Console.WriteLine("Query 1: Category List");
            foreach (var item in Query1)
            {
                Console.WriteLine("{0}", item.ToString());
            }

        }
    }
}
