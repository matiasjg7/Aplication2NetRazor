using Aplication2NetRazor.Datos;
using Aplication2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplication2NetRazor.Pages.Profesores
{
    public class EditarModel : PageModel
    {
        private readonly Aplicacion2DbContext _context;
        public EditarModel(Aplicacion2DbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Profesor Profesor { get; set; }

        [TempData]
        public string Mensaje { get; set; }
        public async Task OnGet(int id)
        {
            Profesor = await _context.Profesor.FindAsync(id);
        }
       
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var ProfesorDesdeDB = await _context.Profesor.FindAsync(Profesor.idProfesor);

                ProfesorDesdeDB.NombreProfesor = Profesor.NombreProfesor;
                ProfesorDesdeDB.ApellidoProfesor = Profesor.ApellidoProfesor;
                ProfesorDesdeDB.Especialidad = Profesor.Especialidad;
                ProfesorDesdeDB.Fecha_nac = Profesor.Fecha_nac;
                ProfesorDesdeDB.Fecha_ing = Profesor.Fecha_ing;

                _context.SaveChangesAsync();
                Mensaje = "Profesor actualizado exitosamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage("Index");
        }
    }
}
