using Aplication2NetRazor.Datos;
using Aplication2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplication2NetRazor.Pages.Profesores
{
    public class RegistrarModel : PageModel
    {

        private readonly Aplicacion2DbContext _context;

        public RegistrarModel(Aplicacion2DbContext contexto)
        {
            _context = contexto;    
        }

        [BindProperty]
        public Profesor Profesor { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            Profesor.Fecha_ing = DateTime.Now;

            _context.Add(Profesor);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }

        public void OnGet()
        {
        }
    }
}
