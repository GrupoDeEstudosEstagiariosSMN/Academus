namespace Core.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task CadastrarAsync(Usuario usuario);
        Task<IEnumerable<Usuario>> BuscarUsuariosAsync(string nomeUsuario);
    }
}
