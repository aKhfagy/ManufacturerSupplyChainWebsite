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
<<<<<<< HEAD
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
=======
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
>>>>>>> f8d59a750b3f71ff834a2a661a5d47f3629d7d2c
                    ID = objManufacturer.ID,
                    Name = objManufacturer.Name,
                    Email = objManufacturer.Email,
                    Description = objManufacturer.Description,
                    NumberOfProducts = objManufacturer.NumberOfProducts,
                    PhoneNumber = objManufacturer.PhoneNumber
<<<<<<< HEAD
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

        
=======
                 }).ToList<ManufacturerModel>();
            return manufacturer;
        }
>>>>>>> f8d59a750b3f71ff834a2a661a5d47f3629d7d2c
    }
}
