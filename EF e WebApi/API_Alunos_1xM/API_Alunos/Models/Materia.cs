using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models {
    public class Materia {
        [Key]
        public int MateriaId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nome { get; set; }

        [StringLength(80)]
        public string? Conteudo { get; set; }

    }
}
