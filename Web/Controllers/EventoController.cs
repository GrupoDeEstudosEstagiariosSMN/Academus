namespace Web.Controllers
{
    [Route("evento")]
    public class EventoController : Controller
    {
        private readonly IEventoRepository _eventoRepository;
        public EventoController(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        [HttpGet("buscar")]
        public async Task<IActionResult> Buscar() => View("_buscar", await _eventoRepository.BuscarEventos());



    }
}