using FoodXPress.BOL;
using FoodXPress.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FoodXPressUI
{
    public partial class NewOrderForm : Form
    {
        private readonly FoodItemRepository _foodDb;
        List<FoodItem> foodItems = new List<FoodItem>();
        List<OrderItem> orderItems = new List<OrderItem>();
        List<int> quantityChoices= new List<int> {1, 2, 3, 4, 5};

        public NewOrderForm()
        {
            InitializeComponent();
            UpdateBinding();

            _foodDb = new FoodItemRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrinksListButton_Click(object sender, EventArgs e)
        {
            foodItems = _foodDb.GetAllDrinks();
            UpdateBinding();
        }

        private void MealsListButton_Click(object sender, EventArgs e)
        {
            foodItems = _foodDb.GetAllMeals();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            FoodItemListBox.DataSource = foodItems;
            FoodItemListBox.DisplayMember = "AllInfo";

            OrderItemListBox.DataSource = orderItems;
            OrderItemListBox.DisplayMember = "AllInfo";

            FoodItemQuantityDropdown.DataSource = quantityChoices;
          
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            
            var selectedItem = (FoodItem) FoodItemListBox.SelectedItem;

            var orderItem = new OrderItem
            {
                FoodItem = selectedItem,
                FoodItemId = selectedItem.FoodItemId,
                Quantity = (int) FoodItemQuantityDropdown.SelectedItem,
                Price = (decimal)selectedItem.Price * (int) FoodItemQuantityDropdown.SelectedItem
            };

            orderItems.Add(orderItem);
            UpdateBinding();
        }
    }
}
