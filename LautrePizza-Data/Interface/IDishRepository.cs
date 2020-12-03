using System;
using System.Collections.Generic;
using System.Text;
using LautrePizza_Data.Model;

namespace LautrePizza_Data.Interface
{
    public interface IDishRepository
    {
        void Add(Dish dish);
        List<Dish> GetAll();
         List<Dish> GetByPrice(double price);
  
    }
}
