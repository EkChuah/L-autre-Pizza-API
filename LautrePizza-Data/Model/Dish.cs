using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LautrePizza_Data.Model
{
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Double Price { get; set; }
        public Double PriceDelivery { get; set; }
       [ForeignKey("DishType")]
        public int DishTypeId { get; set; }
        public String Image { get; set; }

    }
}
