using ASP.NET_Core_with_Angular.Models;

namespace ASP.NET_Core_with_Angular.Services.Infrastructure
{
    public interface IOrder
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);
        void detele(int id);

        int Count();
        void Save();
    }
}
