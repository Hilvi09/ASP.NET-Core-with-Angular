namespace ASP.NET_Core_with_Angular.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string subCategoryName { get; set; }
        public virtual Category category { get; set; }
    }
}