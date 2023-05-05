namespace Web.Controllers
{
    public class EventoController
    {
        private readonly IEventoRepository _eventoRepository;
        public EventoController(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

       



    }
}