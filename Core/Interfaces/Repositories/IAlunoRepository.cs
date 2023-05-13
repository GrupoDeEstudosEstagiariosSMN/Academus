namespace Core.Interfaces.Repositories
{
    public interface IAlunoRepository
    {
        Task CadastrarAlunoAsync(Aluno aluno);
        Task<IEnumerable<Aluno>> BuscarAlunosAsync();
        Task<Aluno> BuscarAlunoPorIdAsync(int id);
        Task ExcluirAlunoAsync(int id);
        Task EditarAlunoAsync(Aluno aluno);
    }
}