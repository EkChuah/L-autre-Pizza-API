
using System.Collections.Generic;
using LautrePizza_Business.Dtos;
using LautrePizza_Data.Model;

namespace LautrePizza_Business.Interfaces
{
    public interface IDishService
    {
        public List<DishDto> GetAllDish();
        void AddDish(DishDto dish);
        List<DishDto> GetByPrice(double price);
        List<DishTypeDto> GetAllDishType();
        void AddDishType(DishTypeDto dishType);

    }
}
