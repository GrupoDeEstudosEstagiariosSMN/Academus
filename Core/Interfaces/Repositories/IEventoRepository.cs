namespace Core.Interfaces.Repositories
{
    public interface IEventoRepository
    {
        Task<IEnumerable<Evento>> BuscarEventos(string nome);
        Task<Evento> BuscarEvento(int id);
        Task CadastrarEvento(Evento evento);
        Task EditarEvento(Evento evento);
        Task ExcluirEvento(int id);
        // Task<IEnumerable<Evento>> BuscarEventosAsyncNovo();
    }
}
