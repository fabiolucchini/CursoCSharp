using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Alunos.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ProfessoresMateriasController : ControllerBase {

        private readonly AppDbContext _context;
        public ProfessoresMateriasController(AppDbContext context) {
            _context = context;
        }        
    }
}



