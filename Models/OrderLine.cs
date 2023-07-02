namespace ASP.NET_Core_with_Angular.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Price { get; set; }
        public int OrdenId { get; set; }
        public int? ProductId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}