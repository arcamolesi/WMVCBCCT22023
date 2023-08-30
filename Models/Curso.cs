using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCBCCT22023.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo descrião é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

    }
}
