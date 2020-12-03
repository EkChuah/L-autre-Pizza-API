
using System.Collections.Generic;
using System.Linq;
using LautrePizza_Business.Dtos;
using LautrePizza_Business.Interfaces;
using LautrePizza_Data.Interface;
using LautrePizza_Data.Model;
using LautrePizza_Data.Repositories;

namespace LautrePizza_Business.Services
{
    public class DishService : IDishService
    {
        private IDishRepository _dishRepository;
        private IDishTypeRepository _dishTypeRepository;


        public DishService(IDishRepository dishRepository, IDishTypeRepository dishTypeRepository)
        {
           _dishRepository = dishRepository;
           _dishTypeRepository = dishTypeRepository;
        }


        //GetAll
        public List<DishDto> GetAllDish()
        {

            return DishToDto(_dishRepository.GetAll());
        }
        public List<DishTypeDto> GetAllDishType()
        {

            return DishTypeToDto(_dishTypeRepository.GetAll());
        }


        
        public List<DishDto> GetByPrice(double price)
        {

            return DishToDto(_dishRepository.GetByPrice(price));
        }


        //Add

        public void AddDish(DishDto dish)
        {
            var dissh = new Dish { Name = dish.Name, Description = dish.Description,Price=dish.Price,PriceDelivery=dish.PriceDelivery,DishTypeId=dish.TypeId,Image=dish.Image};
            _dishRepository.Add(dissh);
            

        }

        public void AddDishType(DishTypeDto dishType)
        {
            var disshType = new DishType { Id = dishType.TypeId, Description = dishType.Description};
            _dishTypeRepository.Add(disshType);


        }


        //toDto
        public List<DishTypeDto> DishTypeToDto(List<DishType> dishType)
        {
            return dishType.Select(d => new DishTypeDto { TypeId = d.Id, Description = d.Description}).ToList();

        }

        public List<DishDto> DishToDto(List<Dish> dish)
        {
            return dish.Select(d => new DishDto { Name = d.Name, Description = d.Description, Price = d.Price, PriceDelivery = d.PriceDelivery, TypeId = d.DishTypeId, Image = d.Image }).ToList();

        }
    }
}
