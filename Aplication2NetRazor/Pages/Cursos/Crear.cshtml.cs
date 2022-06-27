using Aplication2NetRazor.Datos;
using Aplication2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplication2NetRazor.Pages.Cursos
{
    public class CrearModel : PageModel
    {
        private readonly Aplicacion2DbContext _contexto;

        public CrearModel(Aplicacion2DbContext contexto)
        {
            _contexto = contexto;   
        }

        [BindProperty]
        public Curso Curso { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Curso.FechaCreacion = DateTime.Now;

            _contexto.Add(Curso);
            await _contexto.SaveChangesAsync();
            return RedirectToPage("Index");
        }

        public void OnGet()
        {
        }
    }
}
