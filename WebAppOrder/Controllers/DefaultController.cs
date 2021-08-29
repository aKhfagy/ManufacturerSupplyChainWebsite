using Manufacturer.IBL;
using Manufacturer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppOrder.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        private IOrderRepository iOrderRepository;

        public DefaultController(IOrderRepository _iOrderRepository)
        {
            iOrderRepository = _iOrderRepository;
        }
        // GET: Home
        public ActionResult Index()
        {

            IEnumerable<OrderModel> listOfOrderModels = iOrderRepository.GetAllOrders();
            return View(listOfOrderModels);
        }

        public ActionResult AddOrder()
        {
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

        public ActionResult GetRecords()
        {
            var results = iOrderRepository.GetAllOrders();
            return View(results);
        }

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

        public ActionResult Proceed_To_Checkout(int id)
        {
            var myorder = iOrderRepository.GetOrderByID(id);
            return View(myorder);
        }


        public ActionResult Cart(int id)
        {
            var myorder = iOrderRepository.GetOrderByID(id);
            return View(myorder);
        }

        public ActionResult AboutUs()
        {
            return View();

        }
        public ActionResult LogOut()
        {
            return View();

        }
    }
}