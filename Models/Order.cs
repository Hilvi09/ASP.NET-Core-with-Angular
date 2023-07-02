namespace ASP.NET_Core_with_Angular.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOfOrder { get; set; }
        public decimal TotalOrder { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public virtual ICollection<OrderLine> OrderLine { get; set; }

    }
}