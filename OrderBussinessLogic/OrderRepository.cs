
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.IBL;
using Order.Model;
using Order.BL;
using DataAccess;

namespace Order.BL
{
    public class OrderRepository: IOrderRepository
    {
        
        private OrdersEntities objOrdersEntities;
        public OrderRepository()
        {
            objOrdersEntities = new OrdersEntities();

            
        }

        public int AddOrder(OrderModel objOrderModel)
        {
            Requset objOrder = new Requset()
            {
                CompanyID = objOrderModel.CompanyID,
                Company_Name = objOrderModel.Company_Name,
                ItemID = objOrderModel.ItemID,
                Item_Name = objOrderModel.Item_Name,
                Item_Quantity = objOrderModel.Item_Quantity,
                Shipping_instructions = objOrderModel.Shipping_Instructions,
                Purchase_Price = objOrderModel.Purchase_Price,
                Pick_Up_Date = objOrderModel.Pick_Up_Date,
                Recurring_Order = objOrderModel.Recurring_Order,
            };
            objOrdersEntities.Requsets.Add(objOrder);
            return objOrdersEntities.SaveChanges();
        }
        
        public IEnumerable<OrderModel> GetAllOrders()
        {
           var listOfOrders = 
              (from objOrder in objOrdersEntities.Requsets
                                                    select new OrderModel()
                                                    {
                                                       CompanyID=objOrder.CompanyID,
                                                        Company_Name = objOrder.Company_Name,
                                                        ItemID = (int)objOrder.ItemID,
                                                        Item_Name = objOrder.Item_Name,
                                                        Item_Quantity = (float)objOrder.Item_Quantity,
                                                        Shipping_Instructions = objOrder.Shipping_instructions,
                                                        Purchase_Price = (float)objOrder.Purchase_Price,
                                                        Recurring_Order = objOrder.Recurring_Order,
                                                        Pick_Up_Date = objOrder.Pick_Up_Date,


                                                    }).ToList();
            return listOfOrders;
        }




        public OrderModel GetOrderByID(int OrderID)
        {
            throw new NotImplementedException();
        }
    }
}
