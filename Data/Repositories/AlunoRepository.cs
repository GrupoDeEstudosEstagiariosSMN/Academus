namespace Data.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AlunoRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CadastrarAlunoAsync(Aluno aluno)
        {
            await _dbContext.Alunos.AddAsync(aluno);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Aluno>> BuscarAlunosAsync() => await _dbContext.Alunos.ToListAsync();

        public async Task<Aluno> BuscarAlunoPorIdAsync(int id) => await _dbContext.Alunos.FindAsync(id);

        public async Task ExcluirAlunoAsync(int id)
        {
            _dbContext.Alunos.Remove(await BuscarAlunoPorIdAsync(id));
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditarAlunoAsync(Aluno aluno)
        {
            await _dbContext.UpdateEntryAsync<Aluno>(aluno.Id, new {
                Nome = aluno.Nome,
                Turma = aluno.Turma,
                Matricula = aluno.Matricula
            });
            await _dbContext.SaveChangesAsync();
        }
    }
}
