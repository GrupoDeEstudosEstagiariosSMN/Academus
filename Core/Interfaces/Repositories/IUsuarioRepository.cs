namespace Core.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task Cadastrar(Usuario usuario);
        Task<IEnumerable<Usuario>> BuscarUsuariosAsync(string nomeUsuario);
        Task Deletar(int id);
    }
}
