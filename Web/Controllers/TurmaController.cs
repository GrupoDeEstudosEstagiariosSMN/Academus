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

        
    }
}