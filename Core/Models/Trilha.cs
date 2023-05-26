namespace Core.Models
{
    public class Trilha
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<Aluno> Alunos { get; set; }
        public IEnumerable<TrilhaCurso> TrilhaCursos { get; set; }

    }
}