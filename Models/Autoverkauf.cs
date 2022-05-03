using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Autohaendler_Teil2.Models
{
    public class Autoverkauf
    {
        public int VerkaufID { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Verkaufsanzahl { get; set; }
        [Required]
        public decimal Preis { get; set; }

        [NotMapped]
        public decimal Umsatz
        {
            get { return Preis * Verkaufsanzahl; }
        }
        public ICollection<Auto> Autos { get; set; }

    }
}
