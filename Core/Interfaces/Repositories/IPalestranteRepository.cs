namespace Core.Interfaces.Repositories
{
    public interface IPalestranteRepository
    {
        Task<IEnumerable<Palestrante>> BuscarPalestrantes();
    }
}