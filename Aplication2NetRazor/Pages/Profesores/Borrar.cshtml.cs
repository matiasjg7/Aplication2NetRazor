using Aplication2NetRazor.Modelos;
using Aplication2NetRazor.Datos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Aplication2NetRazor.Pages.Profesores
{
    public class BorrarModel : PageModel
    {
        private readonly Aplicacion2DbContext _context;
        public BorrarModel (Aplicacion2DbContext context)
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
                var ProfesorBorrar = await _context.Profesor.FindAsync(Profesor.idProfesor);

                if (ProfesorBorrar == null)
                {
                    return NotFound();
                }

                ProfesorBorrar.Eliminado = true;

                _context.SaveChangesAsync();
                Mensaje = "Profesor eliminado exitosamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage("");
        }

    }
}
