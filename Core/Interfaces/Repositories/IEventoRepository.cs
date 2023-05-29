namespace Core.Interfaces.Repositories
{
    public interface IEventoRepository
    {
        Task CadastrarEvento(Evento evento);

    }
}