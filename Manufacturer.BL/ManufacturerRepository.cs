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
        private ManufacturerEntities objManufacturerEntities;


        public ManufacturerRepository()
        {
            objManufacturerEntities = new ManufacturerEntities();
        }

        public IEnumerable<ManufacturerModel> GetManufacturerByID(int id)
        {
            var manufacturer =
                (from objManufacturer in objManufacturerEntities.ManufacturerProfiles
                 where objManufacturer.ID == id select new ManufacturerModel() { 
                    ID = objManufacturer.ID,
                    Name = objManufacturer.Name,
                    Email = objManufacturer.Email,
                    Description = objManufacturer.Description,
                    NumberOfProducts = objManufacturer.NumberOfProducts,
                    PhoneNumber = objManufacturer.PhoneNumber
                 }).ToList<ManufacturerModel>();
            return manufacturer;
        }
    }
}
