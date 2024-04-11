﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391_BL3W.Database
{
    [Table("OrderDetails")]
    public class OrderDetails
    {
        [Key]
        public int ID { get; set; }
        //Fk
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        //Navigation
        public Order Order { get; set; }
        public Products Products { get; set; }
    }
}
