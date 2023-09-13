using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WMVCBCCT22023.Models
{
    public enum Situacao { Livre, Ocupada, Reservada, Manutencao };

    [Table("Sala")]
    public class Sala
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Description = "id", Name = "ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo descrição não pode ser nulo")]
        [StringLength(40)]
        [Display(Description = "descrição", Name = "Descrição: ")]
        public string descricao { get; set; }

        [Required(AllowEmptyStrings = true)]
        [Display(Description = "quantidade", Name = "Quantidade: ")]
        [Range(1, 25, ErrorMessage = "Valor entre 1 ..25")]
        public int quantidade { get; set; }

        [Required(ErrorMessage = "Campo é obrigatório")]
        [Display(Description = "situação", Name = "Situação: ")]
        public Situacao situacao { get; set; }
    }
}
