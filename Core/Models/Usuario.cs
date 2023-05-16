namespace Core.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha {get; set; }
        
        public bool IsValid(Notification notification)
        {
            if (!Email.Contains(@"^[\w-\.]+@(smn\.com\.br)$")) 
                notification.Add("Email inválido");

            return !notification.Any();
        }
    }
}
