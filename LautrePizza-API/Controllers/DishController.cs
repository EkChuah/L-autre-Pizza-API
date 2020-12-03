using System.Collections.Generic;
using LautrePizza_Business.Dtos;
using LautrePizza_Business.Interfaces;
using LautrePizza_Business.Services;
using LautrePizza_Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace LautrePizza_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DishController : ControllerBase
    {
        private readonly IDishService _platService;

        public DishController(IDishService platService)
        {
            _platService = platService;
        }

        [HttpGet("/Dish")]
        public List<DishDto> GetDishes(double? price)
        {
            if(price == null)
            {
                return _platService.GetAllDish();
            }
            else
            {
                return _platService.GetByPrice(price.Value);
            }
            //price != null ?_platService.GetByPrice(price.Value) : _platService.GetAll();
            //return null;//_platService.GetByPrice(price);
        }

        [HttpGet("/DishType")]
        public List<DishTypeDto> GetDishTypes()
        {
            return _platService.GetAllDishType();
            
        }

        [HttpPost("/Dish")]
        public void Insert(DishDto dish)
        {
            _platService.AddDish(dish);

            
        }

        [HttpPost("/DishType")]
        public void Insert(DishTypeDto dishType)
        {
            _platService.AddDishType(dishType);


        }
    }
}
