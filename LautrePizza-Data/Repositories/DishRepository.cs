using System.Collections.Generic;
using System.Linq;
using LautrePizza_Data.Context;
using LautrePizza_Data.Interface;
using LautrePizza_Data.Model;

namespace LautrePizza_Data.Repositories
{
    public class DishRepository : IDishRepository
    {
        private PizzeriaContext _context;
        public DishRepository(PizzeriaContext context)
        {
            _context = context;
        }

        public void Add(Dish dish)
        {
            _context.Disches.Add(dish);
            _context.SaveChanges();

        }

        public List<Dish> GetAll()
        {
            return _context.Disches.ToList();
        }

        public List<Dish> GetByPrice(double price)
        {
            return _context.Disches.Where(o=>o.Price==price).ToList();
        }
    }
}
