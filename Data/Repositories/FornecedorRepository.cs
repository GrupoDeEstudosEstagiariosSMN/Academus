namespace Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public FornecedorRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task <IEnumerable<Fornecedor>> BuscarFornecedores()
        {
            return await _dbContext.Fornecedores.ToListAsync();
        }

        public async Task CadastrarFornecedor(Fornecedor fornecedor)
        {
            await _dbContext.Fornecedores.AddAsync(fornecedor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeletarFornecedorAsync(int id)
        {
            _dbContext.Fornecedores.Remove(new Fornecedor {
                Id = id
            });
            await _dbContext.SaveChangesAsync();
        }
    }
}
