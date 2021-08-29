using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
<<<<<<< HEAD
using Manufacturer.BL;
using Manufacturer.IBL;
using Manufacturer.Model;

=======
using Order.BL;
using Order.IBL;
using Manufacturer.IBL;
using Manufacturer.Model;
using Order.Model;
>>>>>>> f8d59a750b3f71ff834a2a661a5d47f3629d7d2c

namespace WebAppOrder.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< HEAD
        


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
        public ActionResult GetRecords()
        {
            var results = manufacturerRepository.GetAllManufacturers();
            return View(results);
        }
       

/*

        private IOrderRepository iOrderRepository;

        public HomeController(IOrderRepository _iOrderRepository)
        {
            iOrderRepository = _iOrderRepository;
        }
        
        public ActionResult Index2()
        {

            IEnumerable<OrderModel> listOfOrderModels = iOrderRepository.GetAllOrders();
            return View(listOfOrderModels);
        }
=======
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
>>>>>>> f8d59a750b3f71ff834a2a661a5d47f3629d7d2c

        //    int result = iOrderRepository.AddOrder(objOrderModel);
        //    return RedirectToAction(actionName: "Index");
        //}


        private IManufacturerRepository manufacturerRepository;

        public HomeController(IManufacturerRepository manufacturerRepository)
        {
<<<<<<< HEAD
            OrderModel objOrderModel = new OrderModel()
            {
                CompanyID = 2,
                Company_Name = "Lenovo",
                ItemID = 2,
                Item_Name = "Bag",
                Item_Quantity = 25,
                Pick_Up_Date = "25/3/2020",
                Purchase_Price = 200,
                Recurring_Order = "no",
                Shipping_Instructions = " We would the Shippment to arrive before [22/8/2022] "
            };

            int result = iOrderRepository.AddOrder(objOrderModel);
            return RedirectToAction(actionName: "Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(OrderModel order)
        {
            int id = iOrderRepository.AddOrder(order);

            if (ModelState.IsValid)
            {
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.Issuccess = "Data Added";
                }
            }
            return View();
        }
*//*
        public ActionResult GetRecords()
        {
            var results = iOrderRepository.GetAllOrders();
            return View(results);
        }
*//*
        public ActionResult Details(int id)
        {
            var myorder = iOrderRepository.GetOrderByID(id);
            return View(myorder);
        }
        public ActionResult Accept(int id)
        {

            var myorder = iOrderRepository.GetOrderByID(id);
            return View(myorder);
        }

        public ActionResult Reject(int id)
        {
            var myorder = iOrderRepository.GetOrderByID(id);
            return View(myorder);
        }

        public ActionResult Edit(int id)
        {
            var myorder = iOrderRepository.GetOrderByID(id);
            return View(myorder);
        }

*/


=======
            this.manufacturerRepository = manufacturerRepository;
        }

        public ActionResult Index()
        {
            var manufacturerModel = manufacturerRepository.GetManufacturerByID(0);
            return View(manufacturerModel);
        }
>>>>>>> f8d59a750b3f71ff834a2a661a5d47f3629d7d2c
    }
}