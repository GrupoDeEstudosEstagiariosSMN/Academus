namespace Web.Controllers
{
    [Route("turma")]
    public class TurmaController : Controller
    {

        private readonly ITurmaRepository _turmaRepository;

        public TurmaController(ITurmaRepository turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }


        public IActionResult Index() => View();

        [HttpGet("cadastrar")]
        public IActionResult CadastrarTurma() => View("_Cadastrar");

        [HttpPost("cadastrar")]
        public async Task<IActionResult> Cadastrar(Turma turma)
        {
            await _turmaRepository.Cadastrar(turma);
            return RedirectToAction("Index", "turma");
        }

        [HttpPost("buscar")]
        public async Task<IActionResult> BuscarTurma(BuscarTurmaViewModel nomeTurma) => View("_Buscar", await _turmaRepository.BuscarTurmasAsync(nomeTurma.Nome));
        
        
    }
}
