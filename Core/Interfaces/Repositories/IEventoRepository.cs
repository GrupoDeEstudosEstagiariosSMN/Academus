namespace Core.Interfaces.Repositories
{
  public interface IEventoRepository
  {
    Task<IEnumerable<Evento>> BuscarEventos();
    Task CadastrarEvento(Evento evento);
  }
}