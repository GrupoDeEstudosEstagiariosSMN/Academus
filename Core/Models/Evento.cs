namespace Core.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public int IdPalestrante { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Localizacao { get; set; }
        public string PublicoAlvo { get; set; }
        public decimal ValorIngresso { get; set; }
        public decimal Custo { get; set; }
        public Palestrante Palestrante { get; set; }

        public bool isValid(Notification notification)
        {
            if (ValorIngresso < 100)
            {
                notification.Add("O valor do ingresso não corresponde ao valor mínimo do palestrante");
            }
            return !notification.Any();
        }
    }
}
