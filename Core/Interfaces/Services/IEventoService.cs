namespace Core.Interfaces.Services
{
    public interface IEventoService
    {
        Task CadastrarEventoAsync(Evento evento);

    }
}