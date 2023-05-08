namespace Core.Interfaces.Repositories
{
    public interface ICursoRepository
    {
        Task Cadastrar(Curso curso);
        Task<IEnumerable<Curso>> BuscarCursosAsync();
    }
}