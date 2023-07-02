using ASP.NET_Core_with_Angular.Models;

namespace ASP.NET_Core_with_Angular.Services.Infrastructure
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int id);

        void insert(Customer customer);
        void update(Customer customer);
        void detele(int id);

        void Save();
    }
}
