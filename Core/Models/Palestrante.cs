namespace Core.Models
{
    public class Palestrante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public Evento Evento { get; set; }
    }
}