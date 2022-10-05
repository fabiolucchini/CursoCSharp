using Calculos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Calculos.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class SomarController : ControllerBase {
        

        [HttpGet(Name = "SomarNumeros")]
        public Somar Get() {
            var s = new Somar();
            s.Numero1 = 5;
            s.Numero2 = 10;
            return s;
        }

        [HttpPost(Name = "SomarNumeros")]
        public Somar Post(Somar numeros) {
            
            return numeros;
        }
    }
}
