namespace Data.Repositories
{
    public class TurmaRepository :ITurmaRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TurmaRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Cadastrar(Turma turma)
        {
            await _dbContext.Turmas.AddAsync(turma);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Turma>> BuscarTurmasAsync(string nomeTurma)
        {
            if (string.IsNullOrEmpty(nomeTurma))
                return await _dbContext.Turmas.ToListAsync();
            else
                return await _dbContext.Turmas.Where(x => x.Nome.ToLower() == nomeTurma.ToLower()).ToListAsync();        
        }

        public async Task DeletarAsync(int id)
        {
            _dbContext.Turmas.Remove(new Turma {
                Id = id
            });
            await _dbContext.SaveChangesAsync();
        }
    }
}
