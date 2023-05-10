namespace Core.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task<bool> EmailUnique(Notification notification, string email);
    }
}
