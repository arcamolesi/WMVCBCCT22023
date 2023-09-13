using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCBCCT22023.Models
{
    enum Periodo { Diurno, Vespertino, Matutino }

    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório...")]
        [StringLength(35)]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo data é obrigatório...")]
        [DataType(DataType.Date)]
        [Display(Name = "Aniversário")]
        public DateTime aniversario { get; set; }

        [Required(ErrorMessage = "Campo e-mail é obrigatório...")]
        [DataType(DataType.EmailAddress)]
        [StringLength(40)]
        [Display(Name = "E-Mail")]
        public string email { get; set; }


        
        [Display(Name = "Curso")]
        public int cursoID { get; set; }
        [ForeignKey("cursoID")]
        public Curso curso { get; set; }

        [Display(Name = "Período")]
      //  [Range(0,3)]
        public int periodo { get; set; }

    }
}
