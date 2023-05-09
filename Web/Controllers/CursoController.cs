
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

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("cadastrar")]
        public IActionResult CadastrarCurso()
        {
            return View("_Cadastrar");
        }

        [HttpPost("cadastrar")]
        public async Task<IActionResult> EnviarCadastro(Curso curso)
        {
            //if (!curso.Nome == _dbcontext.curso.Nome)

            await _cursoRepository.Cadastrar(curso);
            // {
            //     Nome = curso.Nome,
            //     CargaHoraria = curso.CargaHoraria,
            //     Professor = curso.Professor,
            //     Trilha = curso.Trilha

            // });
            return RedirectToAction("Index", "curso");
        }

        [HttpGet("buscar")]
        public async Task<IActionResult> BuscarCurso()
        {
            return View("_Buscar", await _cursoRepository.BuscarCursosAsync());
        }

        [HttpPost("deletar")]
        public async Task<IActionResult> DeletarCurso(int id)
        {
            await _cursoRepository.DeletarAsync(id);
            return RedirectToAction("Index", "curso");
        }


    }

}
