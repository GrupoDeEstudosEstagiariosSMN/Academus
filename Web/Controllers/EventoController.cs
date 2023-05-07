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
    public ActionResult Index() => View();

    [HttpGet("buscar")]
    public async Task<IActionResult> BuscarEvento() => View("_buscar", await _eventoRepository.BuscarEventos());

    [HttpGet("cadastrar")]
    public async Task<IActionResult> Cadastrar()
    {
      var especies = await _eventoRepository.BuscarEventos();
      return View("_cadastrar");
    }

    [HttpPost("cadastrar")]
    public async Task<IActionResult> CadastrarEvento(Evento evento)
    {
      await _eventoRepository.CadastrarEvento(evento);
      return RedirectToAction(nameof(Index));
    }

    [HttpPost("editar")]
    public async Task<IActionResult> EditarEvento(Evento evento)
    {
      await _eventoRepository.EditarEvento(evento);
      return Ok();
    }

    [HttpGet("editar")]
    public async Task<IActionResult> Editar(int id)
    {
      var eventoSelecionado = await _eventoRepository.BuscarEvento(id);
      return View("_editar", eventoSelecionado);
    }
  }
}