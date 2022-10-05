using System.ComponentModel.DataAnnotations;

namespace APIFuncionario.Models {
    public class Funcionario {
        [Key]
        public int FuncionarioId { get; set; }
        [Required]
        [StringLength(80)]

        public string? Nome { get; set; }
    }
}
