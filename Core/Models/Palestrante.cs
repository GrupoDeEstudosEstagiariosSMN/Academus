namespace Core.Models
{
    public class Palestrante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorHora { get; set; }

        public IEnumerable<PalestraPalestrante> PalestraPalestrantes { get; set; }
    }
}