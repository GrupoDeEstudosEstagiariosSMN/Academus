
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
            await _cursoRepository.Cadastrar(new Curso {
                Nome = curso.Nome,
                CargaHoraria = curso.CargaHoraria,
                Professor = curso.Professor,
                Trilha = curso.Trilha
            });

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

        [HttpGet("editar")]
        public async Task<IActionResult> EditarCursoPartialView(int id)
        {
            var curso = await _cursoRepository.BuscarCursosPorIdAsync(id);
            
            var cursoEditado = new Curso {
                Id = curso.Id,
                Nome = curso.Nome,
                CargaHoraria = curso.CargaHoraria,
                Professor = curso.Professor,
                Trilha = curso.Trilha
            };

            return View("_Editar", cursoEditado);
        }

        // [HttpPost("editar")]
        // public async Task<IActionResult> EditarCurso(Curso curso)
        // {
        //     await _cursoRepository.EditarAsync(curso);
        //     return RedirectToAction("Index", "curso");
        // }


    }

}
