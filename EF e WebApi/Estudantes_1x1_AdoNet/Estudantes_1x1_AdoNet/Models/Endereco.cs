using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Estudantes_1x1.Models {
    public class Endereco {
        
        public int EnderecoId { get; set; }                
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Cidade { get; set; }
        public int Cep { get; set; }
        public string? Estado { get; set; }
        public string? Pais { get; set; }
        public int EstudanteId { get; set; }
        [JsonIgnore]
        public Estudante? Estudante { get; set; }
    }
}
