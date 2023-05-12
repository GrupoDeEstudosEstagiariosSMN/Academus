namespace Core.Interfaces.Repositories
{
    public interface IFornecedorRepository
    {
        Task <IEnumerable<Fornecedor>> BuscarFornecedores();
        Task CadastrarFornecedor(Fornecedor fornecedor);
        Task DeletarFornecedorAsync(int id);
        Task<Fornecedor> DetalhesFornecedorPorIdAsync(int id);
        Task EditarFornecedorPorIdAsync(Fornecedor fornecedor);
        Task<Fornecedor> BuscarFornecedorPorIdAsync(int id);
        void UpdateFornecedor(Fornecedor fornecedor);
    }
}
