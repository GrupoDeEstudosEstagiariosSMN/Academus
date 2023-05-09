namespace Web.Controllers
{
    //[Route("fornecedor")]
    public class FornecedorController : Controller
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorController(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var buscarFornecedores = await _fornecedorRepository.BuscarFornecedores();
            return View(buscarFornecedores);
        }
    }
}
