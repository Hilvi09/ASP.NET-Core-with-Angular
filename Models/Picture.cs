﻿namespace ASP.NET_Core_with_Angular.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string PictureFileName { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
        //public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}