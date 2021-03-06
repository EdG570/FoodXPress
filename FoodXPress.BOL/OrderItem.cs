﻿using System;

namespace FoodXPress.BOL
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public FoodItem FoodItem { get; set; }
        public Guid FoodItemId { get; set; }
        public Guid OrderId { get; set; }

        public string AllInfo => $"{FoodItem.Name} {Quantity} {Price}";
    }
}
