using System;
using System.Collections.Generic;
using System.Text;
using Manufacturer.Model;

namespace Manufacturer.IBL
{
    public interface IManufacturerRepository
    {
        ManufacturerModel GetManufacturerByID(int OrderID);
    }
}
