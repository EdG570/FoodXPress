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
        }

        
    }
}
