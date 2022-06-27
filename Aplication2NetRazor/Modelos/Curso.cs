using System;
using System.ComponentModel.DataAnnotations;

namespace Aplication2NetRazor.Modelos
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Nombre de curso")]
        public string NombreCurso { get; set; }
        [Display(Name ="Cantidad de Clases")]
        public int CantidadClases { get; set; }
        [Display(Name = "Precio")]
        public float Precio { get; set; }
        [Display(Name ="Fecha de creacion")]
        public DateTime FechaCreacion { get; set; }
        [Required]
        public bool Eliminado { get; internal set; }
    }
}
