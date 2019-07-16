using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1_LINQ_Examples
{
    class Category
    { 
        public int id { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return String.Concat("Category Id : ", id.ToString(), " Description : ", Description.ToString() );
        }
    }
}
