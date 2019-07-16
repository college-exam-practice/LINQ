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
            /* Creating our object that we can use
            as a base to access the data/ojects in the class */
            ProductModel db = new ProductModel();

            // Query 1 - List all categories
            List<Category> Query1 = db.Categories;
            Console.WriteLine("Query 1: Category List");
            foreach (var category in Query1)
            {
                Console.WriteLine("{0}", category.ToString());
            }

            // Query 2 - List all Products
            List<Product> Query2 = db.Products;
            Console.WriteLine("\nQuery 2: Category List");
            foreach (var product in Query2)
            {
                Console.WriteLine("{0}", product.ToString());
            }
            
        }
    }
}
