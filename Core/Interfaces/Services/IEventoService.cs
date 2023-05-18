namespace Core.Interfaces.Services
{
    public interface IEventoService
    {
        Task<string> CadastrarEventoAsync(Evento evento);

    }
}