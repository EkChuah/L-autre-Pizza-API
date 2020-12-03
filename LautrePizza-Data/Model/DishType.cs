using System.ComponentModel.DataAnnotations;

namespace LautrePizza_Data.Model
{
    public class DishType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
