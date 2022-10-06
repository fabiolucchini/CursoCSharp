using Estudantes_1x1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Estudantes_1x1_AdoNet.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class EstudantesController : ControllerBase {

        //[HttpGet]
        [HttpGet("{id:int}", Name = "ObterProduto")]
        public ActionResult<Estudante> Estudantes(int id) {
            var estudante = new Estudante();
            var endereco = new Endereco();
            endereco.EnderecoId = 0;
            string connectionstring =
    @"Server=W10PROX64EN60GB\SQLEXPRESS;Database=Escola01;User Id=fabio;Password=123456;Encrypt=False; TrustServerCertificate=False;";

            using (SqlConnection conn = new SqlConnection(connectionstring)) {
                conn.Open();
                string commandtext = "select e.*,en.* from Estudantes e inner join Enderecos en on e.EstudanteId=en.EstudanteId where e.EstudanteId = " + id.ToString() ;
                SqlCommand cmd = new SqlCommand(commandtext, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    estudante.Nome = reader["Nome"].ToString();
                    estudante.EstudanteId = int.Parse(reader["EstudanteId"].ToString());
                    endereco.EnderecoId = int.Parse(reader["EnderecoId"].ToString());
                    endereco.Logradouro = reader["Logradouro"].ToString();
                    endereco.Complemento = reader["Complemento"].ToString();
                    endereco.Cidade = reader["Cidade"].ToString();
                    endereco.Cep = int.Parse(reader["Cep"].ToString());
                    endereco.Estado = reader["Estado"].ToString();
                    endereco.Pais = reader["Pais"].ToString();
                    estudante.Enderecos.Add(endereco);
                }
            }
            if (endereco.EnderecoId == 0)
                return NotFound();
            return Ok(estudante);
        }
    }
}
