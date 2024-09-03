﻿namespace TEKNOROMA.MODEL.DTOs
{
    public class AddProductDto
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
    }
}
