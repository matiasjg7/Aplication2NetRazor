using Aplication2NetRazor.Datos;
using Aplication2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Aplication2NetRazor.Pages.Alumnos
{
    public class BorrarModel : PageModel
    {
        private readonly Aplicacion2DbContext _context;
        public BorrarModel(Aplicacion2DbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Alumno Alumno { get; set; }

        [TempData]
        public string Mensaje { get; set; }
        public async Task OnGet(int id)
        {
            Alumno = await _context.Alumno.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var AlumnoBorrar = await _context.Alumno.FindAsync(Alumno.IdAlumno);
                
                if (AlumnoBorrar == null)
                {
                    return NotFound();
                }

                AlumnoBorrar.Eliminado = true;

                _context.SaveChangesAsync();
                Mensaje = "Alumno eliminado correctamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage("Index");
        }
    }
}
