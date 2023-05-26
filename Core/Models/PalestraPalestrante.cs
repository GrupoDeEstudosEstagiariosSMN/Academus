namespace Core.Models
{
    public class PalestraPalestrante
    {
        public int IdPalestrante { get; set; }
        public int IdPalestra { get; set; }
        public Palestrante Palestrante { get; set; }
        public Palestra Palestra { get; set; }
    }
}