namespace Core.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public IEnumerable<Palestra> Palestras { get; set; }
    }
}