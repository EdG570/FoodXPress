using FoodXPress.BOL;
using FoodXPress.DAL;
using System;
using System.Windows.Forms;

namespace FoodXPressUI
{
    public partial class NewOrderForm : Form
    {
        
        public NewOrderForm()
        {
            InitializeComponent();
            FoodItemRepository _foodDb = new FoodItemRepository();
            var foodItem = new FoodItem { Name = "Coca-Cola", Price = 1.50M, Category = Category.Beverage};
            var success = _foodDb.Insert(foodItem);
            if (success)
                MessageBox.Show("Successfully added new food item.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
