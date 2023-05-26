namespace Core.Models
{
    public class CategoriaCurso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Curso> Cursos { get; set; }

    }
}