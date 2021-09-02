using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Manufacturer.Model
{
    public class OrderModel
    {
        public int CompanyID { get; set; }
        public string Company_Name { get; set; }
        public int ItemID { get; set; }
        public string Item_Name { get; set; }
        public double Status { get; set; }
        public string Pick_Up_Date { get; set; }
        public decimal Purchaise_Price { get; set; }
        public string Shipping_instructions { get; set; }
        public string Recurring_Order { get; set; }
        public double Item_Status { get; set; }

    }
}
