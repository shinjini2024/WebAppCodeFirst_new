using System.ComponentModel.DataAnnotations;

namespace WebAppCodeFirst.Models
{
    public class Colour
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }
    }
}
