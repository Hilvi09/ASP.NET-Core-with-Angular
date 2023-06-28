using System.Net.Http.Headers;

namespace ASP.NET_Core_with_Angular.Models
{
    public class Category
    {
        public int Id { get; set; }
        public String categoryName { get; set; }
        public virtual ICollection<Product> products { get; set; } = new HashSet <Product>();
        public virtual ICollection<SubCategory> subcategories { get; set; } = new HashSet<SubCategory>;
    }
}
