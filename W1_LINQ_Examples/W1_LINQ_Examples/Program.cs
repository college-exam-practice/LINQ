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

            List<Category> Query1 = db.Categories;
            Console.WriteLine("Query 1: Category List");
            foreach (var category in Query1)
            {
                Console.WriteLine("{0}", category.ToString());
            }

            List<Product> Query2 = db.Products;
            Console.WriteLine("\nQuery 2: Products List");
            foreach (var product in Query2)
            {
                Console.WriteLine("{0}", product.ToString());
            }

            // Query 3 - Products with Quantity <= 100
            List<Product> Query3 = db.Products
                .Where(p => p.QuantityInStock <= 100)
                .ToList();
            Console.WriteLine("\nQuery 3: Products less than or equal to 100");
            foreach (var product in Query3)
            {
                Console.WriteLine("{0}", product.ToString());
            }

            List<Product> Query4 = db.Products;
            Console.WriteLine("\nQuery 4: All Products along with their total value");
            float total = 0;
            foreach (var product in Query4)
            {
                Console.WriteLine("{0} {1}", product.Description, product.UnitPrice);
                total += product.UnitPrice * product.QuantityInStock;
            }
            Console.WriteLine("Total Value:{0:f}", total);

            Console.WriteLine("\nQuery 5: List all Products in the Hardware Category");
            List<ProductModel> pModels = new List<ProductModel>();
            var pModel = new ProductModel(); // instantiate an instance of the ProductModel Class

            var Query5 = db.Products
                .Join(db.Categories,
                product => product.CategoryID,
                Category => Category.id,
                (product, categories) => new { product, categories }
                ).Where(hardCat => hardCat.categories.Description == "Hardware");
            foreach (var item in Query5)
            {
                Console.WriteLine("{0} is a piece of {1}", item.product.Description.ToString(), item.categories.Description);
            }
           // var Query5a = from c in pModel.Categories

                                
        }
    }
}
