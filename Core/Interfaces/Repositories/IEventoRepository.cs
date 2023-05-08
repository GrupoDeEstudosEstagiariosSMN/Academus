namespace Core.Interfaces.Repositories
{
  public interface IEventoRepository
  {
    Task<IEnumerable<Evento>> BuscarEventos();
    Task<Evento> BuscarEvento(int id);
    Task CadastrarEvento(Evento evento);
    Task EditarEvento(Evento evento);
    Task ExcluirEvento(int id);
  }
}