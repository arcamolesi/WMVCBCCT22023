using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCBCCT22023.Models
{
    [Table("Salas")]
    public class Sala
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(25)]
        public string descricao { get; set; }
        
        public int quantidade { get; set; }
        
        public char status { get; set; }
        
    }
}
