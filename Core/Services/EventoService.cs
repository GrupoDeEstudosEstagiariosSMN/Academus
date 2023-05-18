using Core.Interfaces.Repositories;
using Core.Interfaces.Services;

namespace Core.Services
{
    public class EventoService : IEventoService
    {
        private readonly IEventoRepository _eventoRepository;
        private readonly Notification _notification;

        public EventoService(Notification notification, IEventoRepository eventoRepository)
        {
            _notification = notification;
            _eventoRepository = eventoRepository;
        }

        public EventoService(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public async Task<string> CadastrarEventoAsync(Evento evento)
        {
            if (!evento.isValid(_notification))
                return string.Join(",", _notification.Get());

            await _eventoRepository.CadastrarEvento(evento);
            return string.Empty;
        }
    }
}