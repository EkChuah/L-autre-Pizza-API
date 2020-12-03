using System;
using System.Collections.Generic;
using System.Text;
using LautrePizza_Data.Model;

namespace LautrePizza_Data.Interface
{
    public interface IDishTypeRepository
    {
       void Add(DishType dishType);
        List<DishType> GetAll();
    }
}
