using ASP.NET_Core_with_Angular.Models;

namespace ASP.NET_Core_with_Angular.Services.Infrastructure
{
    public interface IOrderLine
    {
        IEnumerable<OrderLine> GetOrderLines();
        OrderLine GetOrderLine(int id);

        void insert(OrderLine orderLine);
        void update(OrderLine orderLine);
        void detele(int id);

        int Count();
        void Save();
    }
}
