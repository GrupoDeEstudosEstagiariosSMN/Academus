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
            var aluno = await BuscarAlunoPorIdAsync(id);
            _dbContext.Alunos.Remove(aluno);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditarAlunoAsync(Aluno aluno)
        {
            var alunoModificado = new {
                Nome = aluno.Nome,
                Turma = aluno.Turma,
                Email = aluno.Email,
                Matricula = aluno.Matricula
            };

            await _dbContext.UpdateEntryAsync<Aluno>(aluno.Id, alunoModificado);
            await _dbContext.SaveChangesAsync();
        }
    }
}
