namespace Core.Interfaces.Repositories
{
    public interface IFornecedorRepository
    {
        Task <IEnumerable<Fornecedor>> BuscarFornecedores();
        Task CadastrarFornecedor(Fornecedor fornecedor);
    }
}
