namespace Core.Models
{
    public class Palestra
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Minutos { get; set; }

        public Categoria Categoria { get; set; }
        public IEnumerable<EventoPalestra> EventosPalestras { get; set; }
        public IEnumerable<PalestraPalestrante> PalestrasPalestrantes { get; set; }
    }
}