namespace Core.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int Matricula { get; set; }
        public long Cpf { get; set; }
        public long Celular { get; set; }
        public string Email { get; set; }
        public int IdTrilha { get; set; }
        public Trilha Trilha { get; set; }

    }
}