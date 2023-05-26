namespace Core.Models
{
    public class EventoOrganizador
    {
        public int IdEvento { get; set; }
        public int IdOrganizador { get; set; }
        public Boolean Responsavel { get; set; }

        public Evento Evento { get; set; }
        public Organizador Organizador { get; set; }
    }
}