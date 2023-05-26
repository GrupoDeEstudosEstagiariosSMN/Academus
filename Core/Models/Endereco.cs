namespace Core.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
    }
}