﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Manufacturer.IBL;
using Manufacturer.Model;


namespace WebAppOrder.Controllers
{
    public class HomeController : Controller
    {
        //private IOrderRepository iOrderRepository;

        //public HomeController(IOrderRepository _iOrderRepository)
        //{
        //    iOrderRepository = _iOrderRepository;
        //}
  

        // GET: Home
        //public ActionResult Index()
        //{


        //    IEnumerable<OrderModel> listOfOrderModels = iOrderRepository.GetAllOrders();
        //    return View(listOfOrderModels);
        //}

        //public ActionResult AddOrder()
        //{
        //    OrderModel objOrderModel = new OrderModel()
        //    {
        //        CompanyID = 2,
        //        Company_Name = "Dell",
        //        ItemID = 2,
        //        Item_Name = "Bag",
        //        Item_Quantity = 25,
        //        Pick_Up_Date = "25/3/2020",
        //        Purchase_Price = 200,
        //        Recurring_Order = "no",
        //        Shipping_Instructions = "nothing"
        //    };

        //    int result = iOrderRepository.AddOrder(objOrderModel);
        //    return RedirectToAction(actionName: "Index");
        //}


        private IManufacturerRepository manufacturerRepository;

        public HomeController(IManufacturerRepository manufacturerRepository)
        {
            this.manufacturerRepository = manufacturerRepository;
        }

        public ActionResult Index()
        {
            var manufacturerModel = manufacturerRepository.GetManufacturerByID(0);
            return View(manufacturerModel);
        }
    }
}