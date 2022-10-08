using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Collections.ObjectModel;

namespace API_Alunos.Models {
    public class ProfessorMateria {
        
        [Key, Column(Order = 1)]
        public int ProfessorId { get; set; }
        [Key, Column(Order = 2)]
        public int MateriaId { get; set; }

        public Professor? Professor { get; set; }
        public Materia? Materia { get; set; }
        

    }
}
