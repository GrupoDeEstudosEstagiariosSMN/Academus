namespace Core.Models
{
    public class EventoPalestra
    {
        public int IdEvento { get; set; }
        public int IdPalestra { get; set; }

        public Evento Evento { get; set; }
        public Palestra Palestra { get; set; }
    }
}