using Estudantes_1x1.Context;
using Estudantes_1x1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Estudantes_1x1.Controller {
    [Route("[controller]")]
    [ApiController]
    public class EstudantesController : ControllerBase {
        private readonly AppDbContext _context;
        public EstudantesController(AppDbContext context) {
            _context = context;
        }

        [HttpGet("Enderecos")]
        public ActionResult<IEnumerable<Estudante>> GetEstudantesEnderecos() {
            try {
                return _context.Estudantes.Include(p => p.Enderecos).ToList();
            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação.");
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Estudante>> Get() {
            try {
                //return _context.Estudantes.AsNoTracking().ToList();
                return _context.Estudantes.Where(c => c.EstudanteId <= 5).ToList();

            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação.");
            }

        }

        [HttpGet("{id:int}", Name = "ObterEstudante")]
        public ActionResult<Estudante> Get(int id) {
            try {
                var Estudante = _context.Estudantes.FirstOrDefault(p => p.EstudanteId == id);

                if (Estudante == null) {
                    return NotFound($"Estudante com id= {id} não encontrada...");
                }
                return Ok(Estudante);
            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                           "Ocorreu um problema ao tratar a sua solicitação.");
            }
        }

        [HttpPost]
        public ActionResult Post(Estudante Estudante) {
            try {
                if (Estudante is null)
                    return BadRequest("Dados inválidos");

                _context.Estudantes.Add(Estudante);
                _context.SaveChanges();

                return new CreatedAtRouteResult("ObterEstudante",
                    new { id = Estudante.EstudanteId }, Estudante);

            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                          "Ocorreu um problema ao tratar a sua solicitação.");
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Estudante Estudante) {
            try {
                if (id != Estudante.EstudanteId) {
                    return BadRequest("Dados inválidos");
                }
                _context.Entry(Estudante).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok(Estudante);
            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                       "Ocorreu um problema ao tratar a sua solicitação.");
            }
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) {
            try {
                var Estudante = _context.Estudantes.FirstOrDefault(p => p.EstudanteId == id);

                if (Estudante == null) {
                    return NotFound($"Estudante com id={id} não encontrada...");
                }
                _context.Estudantes.Remove(Estudante);
                _context.SaveChanges();
                return Ok(Estudante);
            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                               "Ocorreu um problema ao tratar a sua solicitação.");
            }
        }

    }
}
