using ASP.NET_Core_with_Angular.Models;

namespace ASP.NET_Core_with_Angular.Services.Infrastructure
{
    public interface ISubCategory
    {
        IEnumerable<SubCategory> GetSubCategories();
        SubCategory GetSubCategory(string id);

        void insert(SubCategory subcategory);
        void update(SubCategory subcategory);
        void detele(int id);

        int Count();
        void Save();
    }
}
