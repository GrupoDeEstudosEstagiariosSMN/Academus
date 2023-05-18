namespace Core.Interfaces.Repositories
{
    public interface ITurmaRepository
    {
        Task Cadastrar(Turma turma);
        Task<IEnumerable<Turma>> BuscarTurmasAsync(string nomeTurma);
        Task DeletarAsync(int id);
        Task EditarAsync(Turma turma);
    }
}