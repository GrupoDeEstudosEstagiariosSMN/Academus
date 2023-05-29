namespace Core.Models
{
    public class CursoInstrutor
    {
        public int IdInstrutor { get; set; }
        public int IdCurso { get; set; }
        public Instrutor Instrutor { get; set; }
        public Curso Curso { get; set; }
    }
}