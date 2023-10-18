﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoSaude360.Data;
using Saude360.Models;

namespace ProjetoSaude360.Pages.Cadastro
{
    public class EditModel : PageModel
    {
        private readonly ProjetoSaude360.Data.ApplicationDbContext _context;

        public EditModel(ProjetoSaude360.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cadastro Cadastro { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cadastros == null)
            {
                return NotFound();
            }

            var cadastro =  await _context.Cadastros.FirstOrDefaultAsync(m => m.Id == id);
            if (cadastro == null)
            {
                return NotFound();
            }
            Cadastro = cadastro;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cadastro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CadastroExists(Cadastro.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CadastroExists(int id)
        {
          return (_context.Cadastros?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
