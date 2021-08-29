using System;
using System.Collections.Generic;
using System.Text;
using Manufacturer.Model;

namespace Manufacturer.IBL
{
    public interface IManufacturerRepository
    {
        IEnumerable<ManufacturerModel> GetAllManufacturers();
        IEnumerable<ManufacturerModel> GetManufacturers();

        ManufacturerModel GetManufacturerByID(int OrderID);
    }
}
