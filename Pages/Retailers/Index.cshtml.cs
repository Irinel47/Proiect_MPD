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
    public class IndexModel : PageModel
    {
        private readonly Proiect_MPD.Data.Proiect_MPDContext _context;

        public IndexModel(Proiect_MPD.Data.Proiect_MPDContext context)
        {
            _context = context;
        }

        public IList<Retailer> Retailer { get;set; }

        public async Task OnGetAsync()
        {
            Retailer = await _context.Retailer.ToListAsync();
        }
    }
}
