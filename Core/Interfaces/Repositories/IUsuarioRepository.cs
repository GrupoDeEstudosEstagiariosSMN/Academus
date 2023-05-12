namespace Core.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task CadastrarAsync(Usuario usuario);
        Task<IEnumerable<Usuario>> BuscarUsuariosAsync(string nomeUsuario);
        Task DeletarAsync(int id);
        Task EditarAsync(Usuario usuario);
        Task<bool> EmailUnique(string email);

    }
}
