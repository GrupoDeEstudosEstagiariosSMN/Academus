namespace Web.ViewModels.Usuario
{
    public class CadastrarUsuarioViewModel 
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha {get; set; }
        public string RepetirSenha { get; set; }

        public bool IsValid(Notification notification)
        {
            if (RepetirSenha != Senha)
                notification.Add("Senhas não batem");

            return !notification.Any();
        }

        public bool IsValidEmail(Notification notification)
        {
            if (!Email.Contains("@'^[\w-\.]+@(smn\.com\.br)$'")) 
                notification.Add("Email inválido");

            return !notification.Any();
        }
    }
}
