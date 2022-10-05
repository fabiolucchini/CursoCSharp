using APIFuncionario.Context;
using APIFuncionario.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace APIFuncionario.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase {
        private readonly AppDbContext _context;
        public FuncionariosController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Funcionario>> Get() {
            var funcionarios = _context.Funcionarios.ToList();
            if (funcionarios is null) {
                return NotFound();
            }
            return funcionarios;
        }

    }
}
