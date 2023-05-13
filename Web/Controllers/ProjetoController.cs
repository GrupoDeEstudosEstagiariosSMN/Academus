namespace Web.Controllers
{
    [Route("projeto")]
    public class ProjetoController : Controller
    {
        private readonly IProjetoRepository _projetoRepository;
        public ProjetoController(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        public IActionResult Index() => View();

        [HttpGet("cadastrar")]
        public IActionResult MostrarViewCadastrar() => View("_Cadastrar");

        [HttpPost("cadastrar")]
        public async Task<IActionResult> Cadastrar(Projeto projeto)
        {
            var projetinho = new Projeto{
                Titulo = projeto.Titulo,
                Descricao = projeto.Descricao,
                Autor = projeto.Autor,
                Disciplina = projeto.Disciplina,
                PrazoInicial = DateTime.Now,
                PrazoFinal = projeto.PrazoFinal.ToUniversalTime(),
                Nota = projeto.Nota
            };

            await _projetoRepository.CadastrarAsync(projetinho);
            return Ok();
        }

        [HttpGet("buscar")]
        public async Task<IActionResult> MostrarViewBuscar() => View("_Buscar", await _projetoRepository.BuscarProjetosAsync());

        [HttpGet("excluir")]
        public async Task<IActionResult> MostrarViewExcluir(int id) => View("_Excluir", await _projetoRepository.BuscarProjetoPorIdAsync(id));

        [HttpPost("excluir")]
        public async Task<IActionResult> Excluir(int id) {
            await _projetoRepository.ExcluirAsync(id);
            return Ok();
        }

        [HttpGet("editar")]
        public async Task<IActionResult> MostrarViewEditar(int id) => View("_Editar", await _projetoRepository.BuscarProjetoPorIdAsync(id));

        [HttpPost("editar")]
        public async Task<IActionResult> Editar(Projeto projeto) {
            await _projetoRepository.EditarAsync(projeto);
            return Ok();
        }
    }
}