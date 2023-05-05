namespace Core.Interfaces.Repositories
{
    public interface IEventoRepository
    {
        Task<IEnumerable<Evento>> BuscarEventos();
    }
}