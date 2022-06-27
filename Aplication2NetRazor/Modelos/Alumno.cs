using System;
using System.ComponentModel.DataAnnotations;


namespace Aplication2NetRazor.Modelos
{
    public class Alumno
    {
        [Key]
        [Display(Name = "Clave")]
        public int IdAlumno { get; set; }

        [Required]
        [StringLength(100)] 
        [Display(Name = "Nombre")]
        public string NombreAlumno { get; set; }

        [Required]
        [StringLength (50)]
        [Display (Name = "Apellido")]
        public string ApellidoAlumno { get; set; }  
        
        [Required] 
        [Display(Name = "Fecha de ingreso")]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}")]
        public DateTime Fecha_ing { get; set; }

        [Required]
        [Display(Name ="Hora de ingreso")]
        [DisplayFormat(DataFormatString = "{0: hh:mm:ss}")]
        public DateTime Hora_ing { get; set; }  

        [Display(Name ="Fecha de Egreso")]
        [DisplayFormat (DataFormatString = "{0: yyyy/MM/dd}")]
        public DateTime Fecha_eg { get; set; }

        [Required]
        [Display(Name ="Fecha de nacimiento")]
        [DisplayFormat (DataFormatString ="{0: dd/MM/yyyy}")]
        public DateTime Fecha_nac { get; set; }

        [Required]
        [Display(Name = "Cantidad de cursos")]
        public int Cant_cursos { get; set; }

        [Required]
        public bool Eliminado { get; internal set; }
    }
}
