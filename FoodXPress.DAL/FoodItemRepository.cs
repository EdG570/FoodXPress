using Dapper;
using FoodXPress.BOL;
using FoodXPress.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FoodXPress.DAL
{
    public class FoodItemRepository : IFoodItemRepository
    {
        private static string _env;

        public FoodItemRepository(string env = "Default")
        {
            _env = env;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public FoodItem FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public List<FoodItem> GetAllDrinks()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(Helpers.ConnectionStringHelper.GetConnectionString(_env)))
                {
                    var foodItems = db.Query<FoodItem>("dbo.FoodItem_GetAll")
                                       .Where(f => f.Category == Category.Beverage)
                                       .ToList();
                    return foodItems;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<FoodItem> GetAllMeals()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(Helpers.ConnectionStringHelper.GetConnectionString(_env)))
                {
                    var foodItems = db.Query<FoodItem>("dbo.FoodItem_GetAll")
                                       .Where(f => f.Category == Category.Meal)
                                       .ToList();
                    return foodItems;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Insert(FoodItem foodItem)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(Helpers.ConnectionStringHelper.GetConnectionString(_env)))
                {
                    db.Execute("dbo.FoodItem_Insert @Name, @Price, @Category",
                    new { Name = foodItem.Name, Price = foodItem.Price, Category = foodItem.Category });

                    return true;
                }
                
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void Update(FoodItem foodItem)
        {
            throw new NotImplementedException();
        }
    }
}
