namespace ASP.NET_Core_with_Angular.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String ProductName { get; set; }
        public String Details { get; set; }
        public decimal UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public byte[] ProductImagePath { get; set; }
        //public int CartId { get; set; }
        public int? CategoryId { get; set; }
        //public int OrderLineId { get; set; }
        //public int? PictureId { get; set; }
        public virtual ICollection<CartItem> CartItems {get; set; }
        public virtual Category Categories { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }

    }
}