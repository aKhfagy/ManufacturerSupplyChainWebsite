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
       


    }
}