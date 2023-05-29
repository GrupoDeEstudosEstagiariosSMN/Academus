namespace Core.Models
{
    public class Instrutor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public string Area { get; set; }
        public IEnumerable<CursoInstrutor> CursoInstrutores { get; set; }
    }
}