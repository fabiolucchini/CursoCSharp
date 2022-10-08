using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Alunos.Models {
    public class Formacao {

        [Key]
        public int FormacaoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(80)]
        public DateTime Conclusao { get; set; }
        
        public int ProfessorId { get; set; }

        [JsonIgnore]
        public Professor? Professor { get; set; }

    }
}
