using Core.Helpers;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;

namespace Core.Services
{
    public class EventoService : IEventoService
    {
        private readonly Notification _notification;

        public EventoService(Notification notification)
        {
            _notification = notification;
        }
        private readonly IEventoRepository _eventoRepository;

        public EventoService(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public async Task CadastrarEventoAsync(Evento evento)
        {
            if (evento.ValorIngresso < 100)
                await _eventoRepository.CadastrarEvento(evento);
            // else return _notification.AddNotification("burro pra caralho");

        }
    }
}