using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_MPD.Data;
using Proiect_MPD.Models;

namespace Proiect_MPD.Pages.Retailers
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect_MPD.Data.Proiect_MPDContext _context;

        public DeleteModel(Proiect_MPD.Data.Proiect_MPDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Retailer Retailer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Retailer = await _context.Retailer.FirstOrDefaultAsync(m => m.ID == id);

            if (Retailer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Retailer = await _context.Retailer.FindAsync(id);

            if (Retailer != null)
            {
                _context.Retailer.Remove(Retailer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
