using System.ComponentModel.DataAnnotations;

namespace templateAPI_core_7.Models
{
    public class Salas
    {
        [Key]
        public int? salaID { get; set; }
        public string? nome { get; set; }
        public int? andar { get; set;}
        public string? departamento { get; set; }
        public string? lado { get; set; }
        public string? observacoes { get; set; }
    }
}
