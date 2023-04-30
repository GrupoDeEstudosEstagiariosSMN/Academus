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

        [HttpGet("cadastrar")]
        public IActionResult CadastrarUsuario() => View("_Cadastrar");

        [HttpPost("cadastrar")]
        public async Task<IActionResult> EnviarCadastro(CadastrarUsuarioViewModel usuario)
        {
            if (usuario.Senha == usuario.RepetirSenha)
            {
                await _usuarioRepository.Cadastrar(new Usuario
                {
                    Nome = usuario.Nome,
                    Email = usuario.Email,
                    Senha = usuario.Senha
                });
            }

            return RedirectToAction("Index", "usuario");
        }

        [HttpPost("buscar")]
        public async Task<IActionResult> BuscarUsuario(BuscarUsuarioViewModel nomeUsuario)
        {
            return View("_Buscar", await _usuarioRepository.BuscarUsuariosAsync(nomeUsuario.Nome));
        }
    }
}
