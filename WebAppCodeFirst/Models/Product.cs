using System.ComponentModel.DataAnnotations;

namespace WebAppCodeFirst.Models
{
    public class Product
    {
        [Key]
        public int Pid { get; set; }
        [MaxLength(20)]
        public string Pname { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string Details { get; set; }
    }
}
