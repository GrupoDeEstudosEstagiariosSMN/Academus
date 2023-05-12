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

        public async Task <Fornecedor> DetalhesFornecedorPorIdAsync(int id) 
        {
            return await _dbContext.Fornecedores.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task EditarFornecedorPorIdAsync(Fornecedor fornecedor) 
        {
            await _dbContext.UpdateEntryAsync<Fornecedor>(fornecedor.Id, new {
                Nome = fornecedor.Nome,
                Email = fornecedor.Email,
                Representante = fornecedor.Representante,
                Produto = fornecedor.Produto
            });
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Fornecedor> BuscarFornecedorPorIdAsync(int id)
        {
            return await _dbContext.Fornecedores.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void UpdateFornecedor(Fornecedor fornecedor)
        {
            _dbContext.Fornecedores.Update(fornecedor);
            _dbContext.SaveChanges();
        }
    }
}
