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

        public IActionResult Index()
        {
            var buscarFornecedores = _fornecedorRepository.BuscarFornecedores();
            // var fornecedor = new FornecedorViewModel {
            //     Fornecedores = BuscarFornecedores
            // };
            return View(buscarFornecedores);
        }
    }
}
