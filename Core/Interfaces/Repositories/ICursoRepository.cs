namespace Core.Interfaces.Repositories
{
    public interface ICursoRepository
    {
        Task Cadastrar(Curso curso);
        Task<IEnumerable<Curso>> BuscarCursosAsync(string nomeCurso);
        Task DeletarAsync(int id);
        Task EditarAsync(Curso curso);
    }
}
