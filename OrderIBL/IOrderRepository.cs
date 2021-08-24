using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Model;

namespace Order.IBL
{

    public interface IOrderRepository
    {
        IEnumerable<OrderModel> GetAllOrders();


        int AddOrder(OrderModel objOrderModel);
        OrderModel GetOrderByID(int OrderID);
    }
}
