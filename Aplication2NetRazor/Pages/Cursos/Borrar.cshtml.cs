using Aplication2NetRazor.Modelos;
using Aplication2NetRazor.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplication2NetRazor.Pages.Cursos
{
    public class BorrarModel : PageModel
    {
        private readonly Aplicacion2DbContext _context;
        public BorrarModel(Aplicacion2DbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Curso Curso { get; set; }

        [TempData]
        public string Mensaje { get; set; }
        public async Task OnGet(int id)
        {
            Curso = await _context.Curso.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CursoBorrar = await _context.Curso.FindAsync(Curso.Id);
                if (CursoBorrar == null)
                {
                    return NotFound();
                }

                CursoBorrar.Eliminado = true;

                _context.SaveChangesAsync();
                Mensaje = "Curso borrado exitosamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage("Index");
        }

    }
}
