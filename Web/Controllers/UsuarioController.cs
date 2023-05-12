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
                await _usuarioRepository.CadastrarAsync(new Usuario
                {
                    Nome = usuario.Nome,
                    Email = usuario.Email,
                    Senha = usuario.Senha
                });
            }

            return RedirectToAction("Index", "usuario");
        }

        [HttpPost("buscar")]
        public async Task<IActionResult> BuscarUsuario(Usuario usuario) => View("_Buscar", await _usuarioRepository.BuscarUsuariosAsync(usuario.Nome));
        

        [HttpPost("deletar")]
        public async Task<IActionResult> DeletarUsuario(int id)
        {
            await _usuarioRepository.DeletarAsync(id);
            return RedirectToAction("Index", "usuario");
        }

        [HttpPost("editar")]
        public async Task<IActionResult> EditarUsuario(Usuario usuario)
        {
            await _usuarioRepository.EditarAsync(usuario.Id, usuario.Nome, usuario.Email);
            return RedirectToAction("Index", "usuario");
        }
    }
}
