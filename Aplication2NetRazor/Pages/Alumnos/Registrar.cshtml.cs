using Aplication2NetRazor.Datos;
using Aplication2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplication2NetRazor.Pages.Alumnos
{
    public class RegistrarModel : PageModel
    {
        private readonly Aplicacion2DbContext _context;

        public RegistrarModel(Aplicacion2DbContext context)
        {
            _context = context;   
        }

        [BindProperty]
        public Alumno Alumno { get; set; }

        public string Mensaje { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Alumno.Fecha_ing = DateTime.Now;
            Alumno.Hora_ing = DateTime.Now;

            _context.Add(Alumno);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }

        public void OnGet()
        {
        }
    }
}
