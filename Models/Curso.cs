using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCBCCT22023.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(25)]
        public string descricao { get; set; }

        public int teste { get; set; }
    }
}
