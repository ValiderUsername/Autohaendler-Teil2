using System.ComponentModel.DataAnnotations;

namespace Autohaendler_Teil2.Models
{
    public class Hersteller
    {
            public int HerstellerID { get; set; }
            [Required]
            public string? Name { get; set; }
            [Required]
            public int Tel { get; set; }
    }
}
