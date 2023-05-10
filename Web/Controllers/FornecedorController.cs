namespace Web.Controllers
{
    [Route("fornecedor")]
    public class FornecedorController : Controller
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorController(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public IActionResult Index() => View();

        [HttpGet("buscar")]
        public async Task<IActionResult> BuscarAsync() => View("_Buscar", await _fornecedorRepository.BuscarFornecedores());        

        [HttpGet("cadastrar")]
        public IActionResult ViewCadastrarFornecedor() => View("_Create");

        [HttpPost("cadastrar")]
        public async Task<IActionResult> CadastrarFornecedor(Fornecedor fornecedor) {
            await _fornecedorRepository.CadastrarFornecedor(fornecedor);
            return RedirectToAction(nameof(Index));
        }


    }
}
