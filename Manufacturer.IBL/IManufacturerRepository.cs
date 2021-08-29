using System;
using System.Collections.Generic;
using System.Text;
using Manufacturer.Model;

namespace Manufacturer.IBL
{
    public interface IManufacturerRepository
    {
<<<<<<< HEAD
        IEnumerable<ManufacturerModel> GetAllManufacturers();
        IEnumerable<ManufacturerModel> GetManufacturers();

        ManufacturerModel GetManufacturerByID(int OrderID);
=======
        IEnumerable<ManufacturerModel> GetManufacturerByID(int OrderID);
>>>>>>> f8d59a750b3f71ff834a2a661a5d47f3629d7d2c
    }
}
