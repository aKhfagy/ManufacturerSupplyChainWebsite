using DataAccess;
using Manufacturer.BL;
using Manufacturer.IBL;
using Manufacturer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppOrder.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository ProductRepo;
        public ProductController()
        {
            this.ProductRepo = new ProductsRepository(new ManufacturerEntities());

        }

        // GET: Product
        public ActionResult Index()
        {
            var proList = ProductRepo.getProduct().ToList();
            return View(proList);
        }

        public ActionResult ProductDetails()
        {
            var proList = ProductRepo.getProduct().ToList();
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var getpro = ProductRepo.GetProductByID(id);
            var prodisplay = new Product();
            prodisplay.ProductID = getpro.ProductID;
            prodisplay.ProductName = getpro.ProductName;
            prodisplay.ProductCategory = getpro.ProductCategory;
            prodisplay.Description = getpro.Description;
            prodisplay.TotalPrice = getpro.TotalPrice;
            prodisplay.ShipmentDate = getpro.ShipmentDate;
            return View(prodisplay);
        }

        // GET: Product/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Product());
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, Product proInsert)
        {
            try
            {
                // TODO: Add insert logic here
                var addpro = new ProductModel();
                addpro.ProductID = proInsert.ProductID;
                addpro.ProductName = proInsert.ProductName;
                addpro.ProductCategory = proInsert.ProductCategory;
                addpro.Description = proInsert.Description;
                addpro.TotalPrice = proInsert.TotalPrice;
                addpro.ShipmentDate = proInsert.ShipmentDate;
                ProductRepo.InsertProductRecord(addpro);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var getpro = ProductRepo.GetProductByID(id);
            var prodisplay = new Product();
            prodisplay.ProductID = getpro.ProductID;
            prodisplay.ProductName = getpro.ProductName;
            prodisplay.ProductCategory = getpro.ProductCategory;
            prodisplay.Description = getpro.Description;
            prodisplay.TotalPrice = getpro.TotalPrice;
            prodisplay.ShipmentDate = getpro.ShipmentDate;
            return View(prodisplay);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductModel proupdate, FormCollection collection)
        {                
            try
            {
                // TODO: Add update logic here
                ProductRepo.UpdateProductRecord(proupdate);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var prodel = ProductRepo.GetProductByID(id);
            return View(prodel);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                ProductRepo.DeleteProductRecord(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

