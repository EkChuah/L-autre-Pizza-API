
using System.Collections.Generic;
using System.Linq;
using LautrePizza_Data.Context;
using LautrePizza_Data.Interface;
using LautrePizza_Data.Model;

namespace LautrePizza_Data.Repositories
{
    public class DishTypeRepository : IDishTypeRepository
    {
        private PizzeriaContext _context;
        public DishTypeRepository(PizzeriaContext context)
        {
            _context = context;
        }

        public void Add(DishType dishType)
        {
            _context.DischTypes.Add(dishType);
            _context.SaveChanges();

        }
        public List<DishType> GetAll()
        {
            return _context.DischTypes.ToList();
        }

    }
}
