using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCBCCT22023.Models
{
    enum Situacao { Livre, Ocupada, Reserva, Manutencao}

    [Table("Salas")]
    public class Sala
    {
        [Key]
        [Display(Name ="ID")]
        public int id { get; set; }

        [Required (ErrorMessage = "Campo descrição é obrigatório...")]
        [StringLength(35)]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Display(Name = "Quantidade")]
       [MinLength (0, ErrorMessage = "valor maior que zero é obrigatório")]
        public int quantidade { get; set; }

        [Display(Name = "Situação")]
        public int situacao { get; set; }

    }
}
