namespace Web.Controllers
{
    [Route("usuario")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository) 
        {
            _usuarioRepository = usuarioRepository;
        }   
        
        public IActionResult Index() => View();

        [HttpGet("cadastro")]
        public IActionResult CadastrarUsuario() => View("_Cadastrar");

        [HttpPost("cadastro")]
        public async Task<IActionResult> EnviarCadastro(Usuario usuario)
        {
            await _usuarioRepository.Cadastrar(usuario);

            return RedirectToAction("Index", "Usuario");
        }

    }
}
