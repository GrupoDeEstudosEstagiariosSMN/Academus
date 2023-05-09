namespace Web.Controllers
{
    [Route("usuario")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly Notification _notification;

        public UsuarioController(IUsuarioRepository usuarioRepository, Notification notification)
        {
            _usuarioRepository = usuarioRepository;
            _notification = notification;
        }

        public IActionResult Index() => View();

        [HttpGet("cadastrar")]
        public IActionResult CadastrarUsuario() => View("_Cadastrar");

        [HttpPost("cadastrar")]
        public async Task<IActionResult> EnviarCadastro(CadastrarUsuarioViewModel usuario)
        {
            if (await _usuarioRepository.EmailUnique(usuario.Email))
                _notification.Add("Email já cadastrado");

            if (!usuario.IsValid(_notification))
                return BadRequest(_notification.Get());

            await _usuarioRepository.CadastrarAsync(new Usuario
            {
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha
            });

            return RedirectToAction("Index", "usuario");
        }

        [HttpPost("buscar")]
        public async Task<IActionResult> BuscarUsuario(BuscarUsuarioViewModel nomeUsuario) => View("_Buscar", await _usuarioRepository.BuscarUsuariosAsync(nomeUsuario.Nome));
        

        [HttpPost("deletar")]
        public async Task<IActionResult> DeletarUsuario(int id)
        {
            await _usuarioRepository.DeletarAsync(id);
            return RedirectToAction("Index", "usuario");
        }

        [HttpPost("editar")]
        public async Task<IActionResult> EditarUsuario(int id, string nome, string email)
        {
            await _usuarioRepository.EditarAsync(id, nome, email);
            return RedirectToAction("Index", "usuario");
        }
    }
}
