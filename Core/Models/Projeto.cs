namespace Core.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Autor { get; set; }
        public string Disciplina { get; set; }
        public DateTime PrazoInicial { get; set; }
        public DateTime PrazoFinal { get; set; }
        public double Nota { get; set; }

    }
}
