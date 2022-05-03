using System.ComponentModel.DataAnnotations;

namespace Autohaendler_Teil2.Models
{
    public class Auto
    {
        public int AutoID { get; set; }
        public int HerstellerID { get; set; }
        public int VerkaufID { get; set; }
        public decimal Preis { get; set; }

        public Hersteller Herstellers { get; set; }
        public Autoverkauf Autoverkaufs { get; set; }
    }
}
