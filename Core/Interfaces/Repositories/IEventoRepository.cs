namespace Core.Interfaces.Repositories
{
    public interface IEventoRepository
    {
        Task<IEnumerable<Evento>> BuscarEventos(int id, string nome);
        Task CadastrarEvento(Evento evento);
        Task EditarEvento(Evento evento);
        Task ExcluirEvento(int id);
    }
}
