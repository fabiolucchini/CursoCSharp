using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Estudantes_1x1.Models {
    public class Estudante {
        public Estudante() {
            Enderecos = new Collection<Endereco>();
        }
        [Key]
        public int EstudanteId { get; set; }
        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }
        
        public ICollection<Endereco>? Enderecos { get; set; }

    }
}
