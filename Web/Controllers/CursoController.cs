namespace Web.Controllers
{
    [Route("curso")]
    public class CursoController : Controller
    {
        private readonly ICursoRepository _cursoRepository;

        public CursoController(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public IActionResult Index() => View();

        [HttpGet("cadastrar")]
        public IActionResult CadastrarCurso() => View("_Cadastrar");

        [HttpPost("cadastrar")]
        public async Task<IActionResult> EnviarCadastro(Curso curso)
        {
            await _cursoRepository.Cadastrar(new Curso
            {
                Nome = curso.Nome,
                CargaHoraria = curso.CargaHoraria,
                Professor = curso.Professor,
                Trilha = curso.Trilha
            });

            return RedirectToAction("Index", "curso");
        }

        [HttpGet("buscar")]
        // eu prefiriria utilizar apenas string como tipo do parametro pra fazer um objeto mais simples
        public async Task<IActionResult> BuscarCurso(BuscarCursoViewModel nomeCurso)
        {
            // validação para notfound caso queria demonstrar melhor que n encontrou registros
            return View("_Buscar", await _cursoRepository.BuscarCursosAsync(nomeCurso.BuscaNome));
        }

        [HttpPost("deletar")]
        public async Task<IActionResult> DeletarCurso(int id)
        {
            await _cursoRepository.DeletarAsync(id);
            return RedirectToAction("Index", "curso");
        }

        [HttpGet("editar")]
        public IActionResult EditarCurso(Curso curso) => View("_Editar", curso);

        [HttpPost("salvar")]
        public async Task<IActionResult> SalvarCurso(Curso curso)
        {
            await _cursoRepository.EditarAsync(curso);
            return RedirectToAction("Index", "curso");
        }
    }
}
