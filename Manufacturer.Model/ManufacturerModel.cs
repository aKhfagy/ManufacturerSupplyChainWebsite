using System;
using System.Collections.Generic;
using System.Text;

namespace Manufacturer.Model
{
    public class ManufacturerModel
    {
        public int ID { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int NumberOfProducts { get; set; }
    }
}
