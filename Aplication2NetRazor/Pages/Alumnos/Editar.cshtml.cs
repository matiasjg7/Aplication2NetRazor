using Aplication2NetRazor.Datos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplication2NetRazor.Pages.Alumnos
{
    public class EditarModel : PageModel
    {
        private readonly Aplicacion2DbContext _context;
        public EditarModel(Aplicacion2DbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Modelos.Alumno Alumno { get; set; }

        [TempData]
        public string Mensaje { get; set; }
        public async Task Onget(int id)
        {
            Alumno = await _context.Alumno.FindAsync(id);
        }

        public async Task<IActionResult> Onpost()
        {
            if (ModelState.IsValid)
            {
                var AlumnoDesdeDB = await _context.Alumno.FindAsync(Alumno.IdAlumno);

                AlumnoDesdeDB.NombreAlumno = Alumno.NombreAlumno;
                AlumnoDesdeDB.ApellidoAlumno = Alumno.ApellidoAlumno;
                AlumnoDesdeDB.Fecha_ing = Alumno.Fecha_ing;
                AlumnoDesdeDB.Hora_ing = Alumno.Hora_ing;
                AlumnoDesdeDB.Fecha_nac = Alumno.Fecha_nac;
                AlumnoDesdeDB.Cant_cursos = Alumno.Cant_cursos;
                AlumnoDesdeDB.Fecha_eg = Alumno.Fecha_eg;

                _context.SaveChangesAsync();
                Mensaje = "Alumno actualizado exitosamente";
                return RedirectToPage("Index");
            }

            return RedirectToPage("Index");
        }

    }
}
