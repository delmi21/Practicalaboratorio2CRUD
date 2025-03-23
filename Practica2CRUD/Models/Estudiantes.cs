using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica2CRUD.Models
{
    public class Estudiantes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        [StringLength(200)]
        public string Apellido { get; set; } = string.Empty;
        [Required]
        [StringLength(20)]
        public string Carnet { get; set; } = string.Empty;
        [DisplayName("Asignaturas")]
        public int IdAsignatura { get; set; } //clave Foranea
        [ForeignKey("IdAsignatura")]
        public Asignaturas? Asignatura { get; set; } //Propiedad de Navegacion
    }
}
