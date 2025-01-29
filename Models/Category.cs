using System.ComponentModel.DataAnnotations;

namespace Demo_CURD_core.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public double Price { get; set; }
    }
}
