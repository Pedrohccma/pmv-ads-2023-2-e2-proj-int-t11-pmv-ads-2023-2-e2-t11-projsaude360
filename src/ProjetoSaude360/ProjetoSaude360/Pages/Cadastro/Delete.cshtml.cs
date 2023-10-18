using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetoSaude360.Data;
using Saude360.Models;

namespace ProjetoSaude360.Pages.Cadastro
{
    public class DeleteModel : PageModel
    {
      //  private readonly ProjetoSaude360.Data.ApplicationDbContext _context;

      //  public DeleteModel(ProjetoSaude360.Data.ApplicationDbContext context)
      //  {
      //      _context = context;
      //  }

      //  [BindProperty]
      //public Cadastro Cadastro { get; set; } = default!;

      //  public async Task<IActionResult> OnGetAsync(int? id)
      //  {
      //      if (id == null || _context.Cadastros == null)
      //      {
      //          return NotFound();
      //      }

      //      var cadastro = await _context.Cadastros.FirstOrDefaultAsync(m => m.Id == id);

      //      if (cadastro == null)
      //      {
      //          return NotFound();
      //      }
      //      else 
      //      {
      //          Cadastro = cadastro;
      //      }
      //      return Page();
      //  }

      //  public async Task<IActionResult> OnPostAsync(int? id)
      //  {
      //      if (id == null || _context.Cadastros == null)
      //      {
      //          return NotFound();
      //      }
      //      var cadastro = await _context.Cadastros.FindAsync(id);

      //      if (cadastro != null)
      //      {
      //          Cadastro = cadastro;
      //          _context.Cadastros.Remove(Cadastro);
      //          await _context.SaveChangesAsync();
      //      }

      //      return RedirectToPage("./Index");
      //  }
    }
}
