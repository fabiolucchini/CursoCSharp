using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Alunos.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase {
        private readonly AppDbContext _context;
        public MateriasController(AppDbContext context) {
            _context = context;
        }

        [HttpGet("Materias")]
        public ActionResult<IEnumerable<Materia>> GetProfessores() {
            try {
                //var data = _context.Professores.Include(p => p.Materias).ThenInclude(m => m.Professores).ToList();
                var data = _context.Materias.Include(m => m.Professores).ThenInclude(p => p.Materias).ToList();
                return data;
            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação. ");
            }
        }

        [HttpGet("{id:int}", Name = "ObterMaterias")]
        public ActionResult<Materia> Get(int id) {
            var data = _context.Materias.Include(m => m.Professores).ThenInclude(p => p.Materias).First(x => x.MateriaId == id);
            if (data is null) {
                return NotFound("Materia não encontrado...");
            }
            return data;
        }
    }
}
