using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Alunos.Models {
    public class Professor {
        public Professor() {
            Formacao = new Collection<Formacao>();
        }

        [Key]        
        public int ProfessorId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nome { get; set; }

        [StringLength(80)]
        public string? email { get; set; }

        public ICollection<Formacao>? Formacao { get; set; }

    }
}
