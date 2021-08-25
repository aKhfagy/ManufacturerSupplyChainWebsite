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

        public ManufacturerModel GetManufacturerByID(int OrderID)
        {
            ManufacturerModel manufacturer =
                ((ManufacturerModel)(from objManufacturer in objManufacturerEntities.ManufacturerProfiles
                                     select new ManufacturerModel() { ID = OrderID }));
            return manufacturer;
        }
    }
}
