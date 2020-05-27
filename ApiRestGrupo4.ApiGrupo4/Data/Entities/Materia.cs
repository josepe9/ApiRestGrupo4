using System.ComponentModel.DataAnnotations;

namespace ApiRestGrupo4.ApiGrupo4.Data.Entities
{
    public class Materia
    {
        public int MateriaId { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }
    }
}
