using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    [Route("turma")]
    public class TurmaController : Controller
    {
        private readonly ILogger<TurmaController> _logger;

        public TurmaController(ILogger<TurmaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();

    }
}