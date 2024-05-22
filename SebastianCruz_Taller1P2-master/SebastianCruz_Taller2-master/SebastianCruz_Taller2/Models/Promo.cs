namespace SebastianCruz_Taller2.Models
{
    public class Promo
    {
        public int PromoID { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaPromo { get; set; }

        public int BurguerID { get; set; }
        public Burger? Burger { get; set; }
    }
}
