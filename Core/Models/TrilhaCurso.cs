
namespace Core.Models
{
    public class TrilhaCurso
    {
        public int IdTrilha { get; set; }
        public int IdCurso { get; set; }
        public Trilha Trilha { get; set; }
        public Curso Curso { get; set; }
    }
}