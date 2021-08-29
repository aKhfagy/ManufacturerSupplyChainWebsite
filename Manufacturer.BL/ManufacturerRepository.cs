using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Manufacturer.IBL;
using Manufacturer.Model;
using System.Linq;

namespace Manufacturer.BL
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private ManufacturerEntities1 objManufacturerEntities;


        public ManufacturerRepository()
        {
            objManufacturerEntities = new ManufacturerEntities1();
        }

        public IEnumerable<ManufacturerModel> GetAllManufacturers()
        {
            var manufacturer =
                (from objManufacturer in objManufacturerEntities.ManufacturerProfiles
                 select new ManufacturerModel() { 
                    ID = objManufacturer.ID,
                    Name = objManufacturer.Name,
                    Email = objManufacturer.Email,
                    Description = objManufacturer.Description,
                    NumberOfProducts = objManufacturer.NumberOfProducts,
                    PhoneNumber = objManufacturer.PhoneNumber
                 }).ToList();
            return manufacturer;
        }

       

        public ManufacturerModel GetManufacturerByID(int id)
        {
            var manufacturer =
                (from objManufacturer in objManufacturerEntities.ManufacturerProfiles
                 .Where(objOrder => objOrder.ID == id)
                 select new ManufacturerModel()
                 {
                     ID = objManufacturer.ID,
                     Name = objManufacturer.Name,
                     Email = objManufacturer.Email,
                     Description = objManufacturer.Description,
                     NumberOfProducts = objManufacturer.NumberOfProducts,
                     PhoneNumber = objManufacturer.PhoneNumber
                 }).FirstOrDefault();
            return manufacturer;
        }

        public IEnumerable<ManufacturerModel> GetManufacturers()
        {
            var manufacturer =
                           (from objManufacturer in objManufacturerEntities.ManufacturerProfiles
                            select new ManufacturerModel()
                            {
                                ID = objManufacturer.ID,
                                Name = objManufacturer.Name,
                                Email = objManufacturer.Email,
                                Description = objManufacturer.Description,
                                NumberOfProducts = objManufacturer.NumberOfProducts,
                                PhoneNumber = objManufacturer.PhoneNumber
                            }).ToList();
            return manufacturer;
        }

        
    }
}
