using Aplication2NetRazor.Datos;
using Aplication2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplication2NetRazor.Pages.Cursos
{
    public class EditarModel : PageModel
    {
        private readonly Aplicacion2DbContext _context;
        public EditarModel(Aplicacion2DbContext context)
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
                var CursoDesdeDB = await _context.Curso.FindAsync(Curso.Id);
                CursoDesdeDB.NombreCurso = Curso.NombreCurso;
                CursoDesdeDB.CantidadClases = Curso.CantidadClases;
                CursoDesdeDB.Precio = Curso.Precio;

                _context.SaveChangesAsync();
                Mensaje = "Curso actualizado exitosamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage("Index");
        }
    }
}
