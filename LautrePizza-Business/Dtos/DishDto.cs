using System;
using System.Collections.Generic;
using System.Text;

namespace LautrePizza_Data.Model
{
    public class DishDto
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public Double Price { get; set; }
        public Double PriceDelivery { get; set; }
        public int TypeId { get; set; }
        public String Image { get; set; }

    }
}
