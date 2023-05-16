namespace Core.Interfaces.Repositories
{
    public interface IAlunoRepository
    {
        Task CadastrarAsync(Aluno aluno);
        Task<IEnumerable<Aluno>> BuscarAlunosAsync();
        Task<Aluno> BuscarAlunoPorIdAsync(int id);
        Task ExcluirAsync(int id);
    }
}
