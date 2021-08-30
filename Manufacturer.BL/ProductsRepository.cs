﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Manufacturer.Model;
using DataAccess;
using Manufacturer.IBL;
namespace Manufacturer.BL
{
    public class ProductsRepository : IProductsRepository
    {
       
        private ManufacturerEntities manufacturerEntities;
        public ProductsRepository(ManufacturerEntities manufacturerEntities)
        {
            this.manufacturerEntities = manufacturerEntities;
        }

        public void DeleteProductRecord(int proID)
        {
            var productToDelete = 
                from product in manufacturerEntities.Products 
                where product.ProductID == proID 
                select product;
            manufacturerEntities.Products.Remove(productToDelete.First());
            manufacturerEntities.SaveChanges();
        }

        public IEnumerable<ProductModel> getProduct()
        {
            var products = from product in manufacturerEntities.Products
                           where product.ProductID != -1
                           select new ProductModel
                           {
                               ProductID = product.ProductID,
                               ProductName = product.ProductName,
                               ProductCategory = product.ProductCategory,
                               TotalPrice = product.TotalPrice,
                               Description = product.Description,
                               ShipmentDate = product.ShipmentDate
                           };
            return products;
        }

        public ProductModel GetProductByID(int proID)
        {
            var product_ =
                from product in manufacturerEntities.Products
                where product.ProductID == proID
                select new ProductModel
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    ProductCategory = product.ProductCategory,
                    TotalPrice = product.TotalPrice,
                    Description = product.Description,
                    ShipmentDate = product.ShipmentDate
                };
            return product_.First();
        }

        public void InsertProductRecord(ProductModel pro)
        {
            Product product = new Product();
            product.ProductID = pro.ProductID;
            product.ProductCategory = pro.ProductCategory;
            product.ProductName = pro.ProductName;
            product.ShipmentDate = pro.ShipmentDate;
            product.Description = pro.Description;
            product.TotalPrice = pro.TotalPrice;
            manufacturerEntities.Products.Add(product);
            manufacturerEntities.SaveChanges();


        }

        public void UpdateProductRecord(ProductModel pro)
        {
            manufacturerEntities.Entry(pro).State = System.Data.Entity.EntityState.Modified;
            manufacturerEntities.SaveChanges();
        }
    }
}