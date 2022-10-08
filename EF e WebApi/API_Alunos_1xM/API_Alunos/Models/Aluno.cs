using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models {
    public class Aluno {
        [Key]
        public int AlunoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        
        [StringLength(80)]
        public string email { get; set; }
        
        [StringLength(2)]
        public string AnoLetivo { get; set; }

    }
}
