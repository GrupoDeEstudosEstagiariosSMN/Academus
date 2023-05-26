namespace Core.Models
{
    public class Organizador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long Cpnj { get; set; }
        public long Telefone { get; set; }

        public IEnumerable<EventoOrganizador> EventosOrganizadores { get; set; }
    }
}