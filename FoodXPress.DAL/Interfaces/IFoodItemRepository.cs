using FoodXPress.BOL;
using System.Collections.Generic;

namespace FoodXPress.DAL.Interfaces
{
    public interface IFoodItemRepository
    {
        FoodItem FindOne(int id);
        IEnumerable<FoodItem> GetAll();
        bool Insert(FoodItem foodItem);
        void Update(FoodItem foodItem);
        void Delete(int id);
    }
}
