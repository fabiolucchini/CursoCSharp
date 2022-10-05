using Estudantes_1x1.Context;
using Estudantes_1x1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Estudantes_1x1.Controller {
    [Route("[controller]")]
    [ApiController]
    public class EnderecosController : ControllerBase {
        private readonly AppDbContext _context;
        public EnderecosController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Endereco>> Get() {
            var Enderecos = _context.Enderecos.ToList();
            if (Enderecos is null) {
                return NotFound();
            }
            return Enderecos;
        }

        [HttpGet("{id:int}", Name = "ObterEndereco")]
        public ActionResult<Endereco> Get(int id) {
            var Endereco = _context.Enderecos.FirstOrDefault(p => p.EnderecoId == id);
            if (Endereco is null) {
                return NotFound("Endereco não encontrado...");
            }
            return Endereco;
        }

        [HttpPost]
        public ActionResult Post(Endereco Endereco) {
            if (Endereco is null)
                return BadRequest();

            _context.Enderecos.Add(Endereco);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterEndereco",
                new { id = Endereco.EnderecoId }, Endereco);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Endereco Endereco) {
            if (id != Endereco.EnderecoId) {
                return BadRequest();
            }

            _context.Entry(Endereco).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(Endereco);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) {
            var Endereco = _context.Enderecos.FirstOrDefault(p => p.EnderecoId == id);
            //var Endereco = _context.Enderecos.Find(id);

            if (Endereco is null) {
                return NotFound("Endereco não localizado...");
            }
            _context.Enderecos.Remove(Endereco);
            _context.SaveChanges();

            return Ok(Endereco);
        }

    }
}
