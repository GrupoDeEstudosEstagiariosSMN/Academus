using Core.Interfaces.Services;
using Web.ViewModels.Evento;

namespace Web.Controllers
{
    [Route("evento")]
    public class EventoController : Controller
    {
        private readonly IEventoRepository _eventoRepository;
        private readonly IEventoService _eventoService;
        private readonly IPalestranteRepository _palestranteRepository;
        private readonly Notification _notification;

        public EventoController(IEventoRepository eventoRepository, Notification notification, IPalestranteRepository palestranteRepository, IEventoService eventoService)
        {
            _eventoRepository = eventoRepository;
            _palestranteRepository = palestranteRepository;
            _notification = notification;
            _eventoService = eventoService;
        }

        public ActionResult Index() => View();

        [HttpGet("buscar")]
        public async Task<IActionResult> BuscarEvento(string nome)
        {
            var eventos = await _eventoRepository.BuscarEventos(nome);

            if (!eventos.Any())
                return BadRequest("Evento nao encontrado.");

            return View("_buscar", eventos);
        }

        [HttpGet("cadastrar")]
        public async Task<IActionResult> Cadastrar()
        {
            var palestrantes = await _palestranteRepository.BuscarPalestrantes();
            ViewBag.Palestrantes = palestrantes;
            return View("_cadastrar");
        }

        [HttpPost("cadastrar")]
        public async Task<IActionResult> CadastrarEvento(Evento evento)
        {
            //a tabela de evento espera um evento e não um viewmodel de evento
            var responseService = await _eventoService.CadastrarEventoAsync(new Evento
            {
                IdPalestrante = evento.IdPalestrante,
                Nome = evento.Nome,
                Descricao = evento.Descricao,
                Localizacao = evento.Localizacao,
                PublicoAlvo = evento.PublicoAlvo,
                ValorIngresso = evento.ValorIngresso,
                Custo = evento.Custo,
            });

            if (!string.IsNullOrEmpty(responseService))
                return BadRequest(responseService);

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