using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface IFornecedorRepository
    {
        Task <IEnumerable<Fornecedor>> BuscarFornecedores();
    }
}
