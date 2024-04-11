﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391_BL3W.Database
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        [Url]
        public string? ImageUrl { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public decimal price { get; set; }
        //FK
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        //Navigations
        public ICollection<Cart> Carts { get; set; }
        public ICollection<ProductsDetails> Details { get; set; }
    }
}
