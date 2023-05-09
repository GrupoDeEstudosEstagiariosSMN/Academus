namespace Core.Services
{
    public class UsuarioService : IUsuarioService
    {
       private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        
        public async Task<bool> EmailUnique(Notification notification, string email)
        {

                if (await _usuarioRepository.EmailUnique(email))
                notification.Add("Email já cadastrado");

            return !notification.Any();
        }

    }
}