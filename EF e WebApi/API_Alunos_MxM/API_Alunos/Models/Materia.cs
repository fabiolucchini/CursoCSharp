using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Alunos.Models {
    public class Materia {
        public Materia() {
            Professores = new Collection<Professor>();
        }
        [Key]
        public int MateriaId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nome { get; set; }

        [StringLength(80)]
        public string? Conteudo { get; set; }        
        public ICollection<Professor> Professores { get; set; }

    }
}
