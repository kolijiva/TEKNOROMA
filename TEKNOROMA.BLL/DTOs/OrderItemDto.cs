﻿using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.MODEL.DTOs
{
    public class OrderItemDto
    {
        public int ProductID { get; set; }
        public Product Product { get; set; }


        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
