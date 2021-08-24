using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Model
{
    public class OrderModel
    {
        public int CompanyID { get; set; }
        public string Company_Name { get; set; }
        public int ItemID { get; set; }
        public string Item_Name { get; set; }
        public float Item_Quantity { get; set; }
        public string Shipping_Instructions { get; set; }
        public string Pick_Up_Date { get; set; }
        public float Purchase_Price { get; set; }
        public string Recurring_Order { get; set; }




    }
}
