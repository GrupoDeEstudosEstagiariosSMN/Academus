namespace Core.Interfaces.Repositories
{
    public interface IPalestranteRepository
    {
        //tipos de métodos:
        //somente executam(sem parametro e sem retorno)
        //só com paramentro e sem retorno
        //só com retorno e sem parametro
        //com os dois
        Task<Palestrante> BuscarPalestrante(int id);
        Task<IEnumerable<Palestrante>> BuscarPalestrantes();
    }
}
