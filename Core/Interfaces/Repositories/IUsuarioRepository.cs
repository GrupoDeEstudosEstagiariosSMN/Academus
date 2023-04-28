namespace Core.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task Cadastrar (Usuario usuario);
    }
}