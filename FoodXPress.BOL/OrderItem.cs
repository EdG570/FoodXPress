namespace FoodXPress.BOL
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public FoodItem FoodItem { get; set; }
        public int FoodItemId { get; set; }
        public int OrderId { get; set; }

        public string AllInfo => $"{FoodItem.Name} {Quantity} {Price}";
    }
}
