using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manufacturer.Model;

namespace Manufacturer.IBL
{
    public interface IProductsRepository
    {
        void InsertProductRecord(ProductModel pro);


        IEnumerable<ProductModel> getProduct();
        void UpdateProductRecord(ProductModel pro);
        void DeleteProductRecord(int proID);
        ProductModel GetProductByID(int proID);
        ProductModel GetProductFilter(string category, DateTime shipmentdate);


    }
}
