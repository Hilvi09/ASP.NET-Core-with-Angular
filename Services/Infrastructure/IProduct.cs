using ASP.NET_Core_with_Angular.Models;

namespace ASP.NET_Core_with_Angular.Services.Infrastructure
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(string id);

        void insert(Product product);
        void update(Product product);
        void detele(int id);

        int Count();
        void Save();
    }
}
