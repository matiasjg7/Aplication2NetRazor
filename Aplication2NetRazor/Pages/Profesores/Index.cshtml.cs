using Aplication2NetRazor.Datos;
using Aplication2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Aplication2NetRazor.Pages.Profesores
{
    public class IndexModel : PageModel
    {
        private readonly Aplicacion2DbContext _context;

        public IndexModel(Aplicacion2DbContext context)
        {
            _context = context;
        }

        public IEnumerable<Profesor> Profesores { get; set; }

        [TempData]
        public string Mensaje { get; set; }
        public async Task OnGet()
        {
            Profesores = await _context.Profesor.ToListAsync();
        }
    }
}
