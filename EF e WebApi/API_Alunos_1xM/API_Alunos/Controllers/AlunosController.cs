using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Alunos.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase {

        private readonly AppDbContext _context;
        public AlunosController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Aluno>> Get() {
            var alunos = _context.Alunos.ToList();
            if (alunos is null) {
                return NotFound();
            }
            return alunos;
        }

        [HttpGet("{id:int}", Name = "ObterAluno")]
        public ActionResult<Aluno> Get(int id) {
            var aluno = _context.Alunos.FirstOrDefault(p => p.AlunoId == id);
            if (aluno is null) {
                return NotFound("Aluno não encontrado...");
            }
            return aluno;
        }

        [HttpPost]
        public ActionResult Post(Aluno aluno) {
            if (aluno is null)
                return BadRequest();

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterAluno",
                new { id = aluno.AlunoId }, aluno);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Aluno aluno) {
            if (id != aluno.AlunoId) {
                return BadRequest();
            }

            _context.Entry(aluno).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(aluno);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) {
            var aluno = _context.Alunos.FirstOrDefault(p => p.AlunoId == id);
            //var aluno = _context.Alunos.Find(id);            

            if (aluno is null) {
                return NotFound("Aluno não localizado...");
            }
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();

            return Ok(aluno);
        }
    }
}
