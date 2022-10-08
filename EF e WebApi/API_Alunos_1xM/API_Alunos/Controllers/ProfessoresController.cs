using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Professores.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase {

        private readonly AppDbContext _context;
        public ProfessoresController(AppDbContext context) {
            _context = context;
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<Professor>> Get() {
        //    var professores = _context.Professores.ToList();
        //    if (professores is null) {
        //        return NotFound();
        //    }
        //    return Ok(professores);
        //}
        [HttpGet("ProfessoresFormacoes")]
        public ActionResult<IEnumerable<Professor>> GetProfessores() {
            try {
                return _context.Professores.Include(p => p.Formacao).ToList();
            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ocorreu um problema ao tratar a sua solicitação.");
            }
        }

        [HttpGet("{id:int}", Name = "ObterProfessor")]
        public ActionResult<Professor> Get(int id) {
            var professor = _context.Professores.Include(p => p.Formacao).FirstOrDefault(p => p.ProfessorId == id);
            if (professor is null) {
                return NotFound("Professor não encontrado...");
            }
            //var professor = _context.Professores.FromSqlRaw("Select * from Professores where ProfessorId={id}").FirstOrDefault();
            return professor;
        }

        [HttpPost]
        public ActionResult Post(Professor professor) {
            if (professor is null)
                return BadRequest();

            _context.Professores.Add(professor);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterProfessor",
                new { id = professor.ProfessorId }, professor);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Professor professor) {
            if (id != professor.ProfessorId) {
                return BadRequest();
            }

            _context.Entry(professor).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(professor);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) {
            var professor = _context.Professores.FirstOrDefault(p => p.ProfessorId == id);
            //var professor = _context.Professores.Find(id);            

            if (professor is null) {
                return NotFound("Professor não localizado...");
            }
            _context.Professores.Remove(professor);
            _context.SaveChanges();

            return Ok(professor);
        }
    }
}
