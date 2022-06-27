using System.ComponentModel.DataAnnotations;

namespace Aplication2NetRazor.Modelos
{
    public class Profesor
    {
        [Key]
        [Display(Name = "Clave")]
        public int idProfesor { get; set; }

        [Required]
        [Display(Name ="Nombre")]
        [StringLength(100)]
        public string NombreProfesor { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        [StringLength(50)]
        public string ApellidoProfesor { get; set; }

        [Required] 
        [Display(Name ="Fecha de nacimiento")]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public DateTime Fecha_nac { get; set; }

        [Required]
        [Display(Name ="Fecha de ingreso")]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public DateTime Fecha_ing { get; set; }

        [Required]
        [Display(Name ="Especializacion")]
        public string Especialidad { get; set; }

        [Required]
        public bool Eliminado { get; internal set; }

    }
}
