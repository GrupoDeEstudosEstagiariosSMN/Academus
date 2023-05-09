using Core.Helpers;

namespace Web.Controllers
{
  [Route("evento")]
  public class EventoController : Controller
  {
    private readonly IEventoRepository _eventoRepository;
    private readonly Notification _notification;
    public EventoController(IEventoRepository eventoRepository, Notification notification)
    {
      _eventoRepository = eventoRepository;
      _notification = notification;
    }
    public ActionResult Index() => View();
    
    [HttpPost("buscar")]
    public async Task<IActionResult> BuscarEvento(Evento evento) => View("_Buscar", await _eventoRepository.BuscarEventos(evento.Id, evento.Nome));

    [HttpGet("cadastrar")]
    public IActionResult Cadastrar() => View("_Cadastrar");

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
      var eventos = await _eventoRepository.BuscarEventos(id, null);
      var eventoSelecionado = eventos.FirstOrDefault();
      return View("_Editar", eventoSelecionado);
    }

    [HttpPost("excluir")]
    public async Task<IActionResult> Excluir(int id)
    {
      await _eventoRepository.ExcluirEvento(id);
      return RedirectToAction(nameof(Index));
    }

  }
}