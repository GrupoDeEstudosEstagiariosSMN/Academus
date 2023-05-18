namespace Core.Interfaces.Repositories
{
    public interface IProjetoRepository
    {
        Task CadastrarAsync(Projeto projeto);
        Task<IEnumerable<Projeto>> BuscarProjetosAsync();
        Task<Projeto> BuscarProjetoPorIdAsync(int id);
        Task ExcluirAsync(int id);
        Task EditarAsync(Projeto projeto);
    }
}