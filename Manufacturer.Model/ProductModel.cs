using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufacturer.Model
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }
        public System.DateTime ShipmentDate { get; set; }
    }
}
