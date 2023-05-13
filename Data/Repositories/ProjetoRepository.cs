namespace Data.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProjetoRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CadastrarAsync(Projeto projeto)
        {
            await _dbContext.Projetos.AddAsync(projeto);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Projeto>> BuscarProjetosAsync() => await _dbContext.Projetos.ToListAsync();

        public async Task<Projeto> BuscarProjetoPorIdAsync(int id) => await _dbContext.Projetos.Where(x => x.Id == id).FirstOrDefaultAsync();

        public async Task ExcluirAsync(int id)
        {
            _dbContext.Projetos.Remove(await BuscarProjetoPorIdAsync(id));
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditarAsync(Projeto projeto)
        {
            await _dbContext.UpdateEntryAsync<Projeto>(projeto.Id, new {
                Titulo = projeto.Titulo,
                Descricao = projeto.Descricao,
                Autor = projeto.Autor,
                PrazoFinal = projeto.PrazoFinal.ToUniversalTime(),
            });
            await _dbContext.SaveChangesAsync();
        }
    }
}