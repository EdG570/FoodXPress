using System;

namespace FoodXPress.BOL
{
    public enum Status
    {
        Placed,
        Ready,
        Delivered,
        Paid,
        Hold,
        Void
    }

    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public Status Status { get; set; }
        public int TableId { get; set; }
    }
}
