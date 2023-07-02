using ASP.NET_Core_with_Angular.Models;

namespace ASP.NET_Core_with_Angular.Services.Infrastructure
{
    public interface ICategory
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(int id);

        void insert(Category category);
        void update(Category category);
        void detele(int id);

        int Count();
        void Save();


    }
}
