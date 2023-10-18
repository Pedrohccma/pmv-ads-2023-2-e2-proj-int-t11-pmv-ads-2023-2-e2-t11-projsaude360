using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoSaude360.Data;
using Saude360.Models;

namespace ProjetoSaude360.Pages.Cadastro
{
    public class CreateModel : PageModel
    {
        private readonly ProjetoSaude360.Data.ApplicationDbContext _context;

        public CreateModel(ProjetoSaude360.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        //[BindProperty]
        //public Cadastro Cadastros { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        //public async Task<IActionResult> OnPostAsync()
        //{
        //  if (!ModelState.IsValid || _context.Cadastros == null || Cadastros == null)
        //    {
        //        return Page();
        //    }

        //    _context.Cadastros.Add(Cadastros);
        //    await _context.SaveChangesAsync();

        //    return RedirectToPage("./Index");
        //}
    }
}
