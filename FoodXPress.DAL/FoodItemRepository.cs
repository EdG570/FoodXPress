using Dapper;
using FoodXPress.BOL;
using FoodXPress.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FoodXPress.DAL
{
    public class FoodItemRepository : IFoodItemRepository
    {
        private readonly IDbConnection _db;

        public FoodItemRepository(string env = "Default")
        {
            _db = new SqlConnection(Helpers.ConnectionStringHelper.GetConnectionString(env));
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public FoodItem FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FoodItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(FoodItem foodItem)
        {
            try
            {
                using (_db)
                {
                    _db.Execute("dbo.FoodItem_Insert @Name, @Price, @Category",
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
