﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;
using Manufacturer.IBL;
using Manufacturer.Model;

namespace Manufacturer.BL
{
    public class OrderRepository : IOrderRepository
    {

        private ManufacturerEntities objOrdersEntities;
        public OrderRepository()
        {
            objOrdersEntities = new ManufacturerEntities();


        }


        public int AddOrder(OrderModel objOrderModel)
        {
            Requset objOrder = new Requset()
            {
                CompanyID = objOrderModel.CompanyID,
                Company_Name = objOrderModel.Company_Name,
                ItemID = objOrderModel.ItemID,
                Item_Name = objOrderModel.Item_Name,
                Item_Status = objOrderModel.Item_Status,
                Shipping_instructions = objOrderModel.Shipping_instructions,
                Purchaise_Price = objOrderModel.Purchaise_Price,
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
                    CompanyID = objOrder.CompanyID,
                    Company_Name = objOrder.Company_Name,
                    ItemID = (int)objOrder.ItemID,
                    Item_Name = objOrder.Item_Name,
                    Item_Status = (float)objOrder.Item_Status,
                    Shipping_instructions = objOrder.Shipping_instructions,
                    Purchaise_Price = objOrder.Purchaise_Price,
                    Recurring_Order = objOrder.Recurring_Order,
                    Pick_Up_Date = objOrder.Pick_Up_Date,


                }).ToList();
            return listOfOrders;
        }



        public void AcceptedOrder(int orderId)
        {
            Requset order = objOrdersEntities.Requsets.Find(orderId);
            order.Item_Status = 1;


            objOrdersEntities.Entry(order).State = System.Data.Entity.EntityState.Modified;
            objOrdersEntities.SaveChanges();
        }



        public OrderModel GetOrderByID(int id)
        {
            var listOfOrders =
                           (from objOrder in objOrdersEntities.Requsets
                            .Where(objOrder => objOrder.CompanyID == id)
                            select new OrderModel()
                            {
                                CompanyID = objOrder.CompanyID,
                                Company_Name = objOrder.Company_Name,
                                ItemID = (int)objOrder.ItemID,
                                Item_Name = objOrder.Item_Name,
                                Item_Status = (float)objOrder.Item_Status,
                                Shipping_instructions = objOrder.Shipping_instructions,
                                Purchaise_Price = objOrder.Purchaise_Price,
                                Recurring_Order = objOrder.Recurring_Order,
                                Pick_Up_Date = objOrder.Pick_Up_Date,

                            }).FirstOrDefault();
            return listOfOrders;
        }

        /* public OrderModel AccepttOrderByID(int id)
         {
             var listOfOrders =
                            (from objOrder in objOrdersEntities.Requsets
                             .Where(objOrder => objOrder.ItemID == id)
                             .Where(  )
                             select new OrderModel()
                             {
                                 CompanyID = objOrder.CompanyID,
                                 Company_Name = objOrder.Company_Name,
                                 ItemID = (int)objOrder.ItemID,
                                 Item_Name = objOrder.Item_Name,
                                 Item_Status = (float)objOrder.Item_Status,
                                 Shipping_Instructions = objOrder.Shipping_instructions,
                                 Purchase_Price = (float)objOrder.Purchase_Price,
                                 Recurring_Order = objOrder.Recurring_Order,
                                 Pick_Up_Date = objOrder.Pick_Up_Date,


                             }).FirstOrDefault();
             return listOfOrders;
         }
 */

        public List<OrderModel> GetOrders()
        {
            var listOfOrders =
               (from objOrder in objOrdersEntities.Requsets
                select new OrderModel()
                {
                    CompanyID = objOrder.CompanyID,
                    Company_Name = objOrder.Company_Name,
                    ItemID = (int)objOrder.ItemID,
                    Item_Name = objOrder.Item_Name,
                    Item_Status = (float)objOrder.Item_Status,
                    Shipping_instructions = objOrder.Shipping_instructions,
                    Purchaise_Price = (decimal)objOrder.Purchaise_Price,
                    Recurring_Order = objOrder.Recurring_Order,
                    Pick_Up_Date = objOrder.Pick_Up_Date,
                    Status=objOrder.Status


                }).ToList();
            return listOfOrders;
        }



    }

}


/*

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
    public class OrderRepository : IOrderRepository
    {

        private OrdersEntities objOrdersEntities;
        public OrderRepository()
        {
            objOrdersEntities = new OrdersEntities();
        }

        *//* public OrderModel AccepttOrderByID(int id)
         {
             var listOfOrders =
                            (from objOrder in objOrdersEntities.Requsets
                             .Where(objOrder => objOrder.ItemID == id)
                             .Where(  )
                             select new OrderModel()
                             {
                                 CompanyID = objOrder.CompanyID,
                                 Company_Name = objOrder.Company_Name,
                                 ItemID = (int)objOrder.ItemID,
                                 Item_Name = objOrder.Item_Name,
                                 Item_Status = (float)objOrder.Item_Status,
                                 Shipping_Instructions = objOrder.Shipping_instructions,
                                 Purchase_Price = (float)objOrder.Purchase_Price,
                                 Recurring_Order = objOrder.Recurring_Order,
                                 Pick_Up_Date = objOrder.Pick_Up_Date,


                             }).FirstOrDefault();
             return listOfOrders;
         }
 *//*



    }
}
*/