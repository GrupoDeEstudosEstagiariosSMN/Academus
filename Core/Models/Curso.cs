namespace Core.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CargaHoraria { get; set; }
        public string Descricao { get; set; }
        public int IdCategoriaCurso { get; set; }
        public CategoriaCurso CategoriaCurso { get; set; }
        public IEnumerable<TrilhaCurso> TrilhaCursos { get; set; }
        public IEnumerable<CursoInstrutor> CursoInstrutores { get; set; }

    }
}
