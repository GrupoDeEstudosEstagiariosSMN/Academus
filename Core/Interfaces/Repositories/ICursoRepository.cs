namespace Core.Interfaces.Repositories
{
    public interface ICursoRepository
    {
        Task Cadastrar(Curso curso);
        Task<IEnumerable<Curso>> BuscarCursosAsync();
        Task DeletarAsync(int id);
        Task EditarAsync(Curso curso);
    }
}
