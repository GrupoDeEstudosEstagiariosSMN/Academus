namespace Web.Controllers
{
    public class EventoController : Controller
    {

        private readonly IEventoRepository _eventoRepository;

        public EventoController(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("cadastrar")]
        public async Task<IActionResult> CadastrarEvento(Evento evento)
        {
            var response = await _eventoRepository.CadastrarEvento(evento);
            return Ok();
        }
    }
}