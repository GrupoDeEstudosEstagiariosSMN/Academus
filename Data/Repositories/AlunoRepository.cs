namespace Data.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AlunoRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CadastrarAsync(Aluno aluno)
        {
            await _dbContext.Alunos.AddAsync(aluno);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Aluno>> BuscarAlunosAsync()
        {
            return await _dbContext.Alunos.ToListAsync();
        }

        public async Task<Aluno> BuscarAlunoPorIdAsync(int id)
        {
            return await _dbContext.Alunos.FindAsync(id);
        }

        public async Task ExcluirAsync(int id)
        {
            _dbContext.Alunos.Remove(await BuscarAlunoPorIdAsync(id));
            await _dbContext.SaveChangesAsync();
        }
    }
}
