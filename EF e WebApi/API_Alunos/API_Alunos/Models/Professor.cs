using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models {
    public class Professor {
        [Key]        
        public int ProfessorId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(80)]
        public string email { get; set; }

    }
}
