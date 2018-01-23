using System;

namespace FoodXPress.BOL
{
    public enum Category
    {
        Meal,
        Beverage,
        Side,
        Appetizer,
        Dessert
    }

    public class FoodItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public string AllInfo => $"{Name} {Price}";
    }
}
