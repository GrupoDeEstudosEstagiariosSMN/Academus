namespace Web.Controllers
{
    [Route("aluno")]
    public class AlunoController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public IActionResult Index() => View();
        
        [HttpGet("cadastrar")]
        public IActionResult MostrarViewCadastrar() => View("_Cadastrar");

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Aluno aluno) {

            await _alunoRepository.CadastrarAsync(aluno);

            return Ok();
        }
    }
}