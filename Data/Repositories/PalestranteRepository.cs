namespace Data.Repositories
{
    public class PalestranteRepository : IPalestranteRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public PalestranteRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Palestrante>> BuscarPalestrantes()
        {
            return await _dbContext.Palestrantes.ToListAsync();
        }
    }
}