using Web.ViewModels.Evento;

namespace Web.Controllers
{
    [Route("evento")]
    public class EventoController : Controller
    {
        private readonly IEventoRepository _eventoRepository;
        private readonly IPalestranteRepository _palestranteRepository;
        private readonly Notification _notification;

        public EventoController(IEventoRepository eventoRepository, Notification notification, IPalestranteRepository palestranteRepository)
        {
            _eventoRepository = eventoRepository;
            _palestranteRepository = palestranteRepository;
            _notification = notification;
        }

        public ActionResult Index() => View();

        [HttpGet("buscar")]
        public async Task<IActionResult> BuscarEvento(string nome)
        {
            // var eventos = await _eventoRepository.BuscarEventos(nome);
            var eventos = await _eventoRepository.BuscarEventosAsyncNovo();

            // if (!eventos.Any())
            //     return BadRequest("Evento nao encontrado.");

            return View("_buscar", eventos);
        }

        [HttpGet("cadastrar")]
        public async Task<IActionResult> Cadastrar()
        {
            var palestrantes = await _palestranteRepository.BuscarPalestrantes();
            var cadastrarEventoViewModel = new CadastrarEventoViewModel
            {
                Palestrantes = palestrantes
            };
            return View("_cadastrar", cadastrarEventoViewModel);
        }

        [HttpPost("cadastrar")]
        public async Task<IActionResult> CadastrarEvento(CadastrarEventoViewModel cadastrarEventoViewModel)
        {
            //a tabela de evento espera um evento e não um viewmodel de evento

            await _eventoRepository.CadastrarEvento(new Evento
            {
                IdPalestrante = cadastrarEventoViewModel.IdPalestrante,
                Nome = cadastrarEventoViewModel.Nome,
                Descricao = cadastrarEventoViewModel.Descricao,
                Localizacao = cadastrarEventoViewModel.Localizacao,
                PublicoAlvo = cadastrarEventoViewModel.PublicoAlvo,
                ValorIngresso = cadastrarEventoViewModel.ValorIngresso,
                Custo = cadastrarEventoViewModel.Custo,
            });
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
