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

        [HttpGet("buscar")]
        public async Task<IActionResult> MostrarViewBuscar() => View("_Buscar", await _alunoRepository.BuscarAlunosAsync());

        [HttpGet("excluir")]
        public async Task<IActionResult> MostrarViewExcluir(int id)
        {
            if (id == default)
                return BadRequest("aluno não encontrado");
        
            return View("_Excluir", await _alunoRepository.BuscarAlunoPorIdAsync(id));
        }

        [HttpPost("excluir")]
        public async Task<IActionResult> Excluir(int id) 
        {
            await _alunoRepository.ExcluirAsync(id);
            return Ok();
        }

        [HttpGet("editar")]
        public async Task<IActionResult> MostrarViewEditar(int id) 
        {
            if (id == default)
                return BadRequest("aluno não encontrado");

            return View("_Editar", await _alunoRepository.BuscarAlunoPorIdAsync(id));
        }

        [HttpPost("editar")]
        public async Task<IActionResult> Editar(Aluno aluno) 
        {
            await _alunoRepository.EditarAlunoAsync(aluno);
            return Ok();
        }
    }
}
