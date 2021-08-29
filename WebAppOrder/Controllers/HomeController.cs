using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Manufacturer.BL;
using Manufacturer.IBL;
using Manufacturer.Model;


namespace WebAppOrder.Controllers
{
    public class HomeController : Controller
    {
        


        private IManufacturerRepository manufacturerRepository;
        

        public HomeController(IManufacturerRepository manufacturerRepository)
        {
            this.manufacturerRepository = manufacturerRepository;
        }

        public ActionResult Index(int id)
        {
            var manufacturerModel = manufacturerRepository.GetManufacturerByID(id);
            return View(manufacturerModel);
        }

        public ActionResult My_Account()
        {
            return View();
        }

        public ActionResult Profile_Page()
        {
            var mymanufacturer = manufacturerRepository.GetManufacturerByID(0);
            return View(mymanufacturer);
        }


    }
}