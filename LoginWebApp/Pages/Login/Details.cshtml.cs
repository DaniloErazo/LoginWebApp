#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LoginWebApp.Data;
using LoginWebApp.Models;

namespace LoginWebApp.Pages.Login
{
    public class DetailsModel : PageModel
    {
        private readonly LoginWebApp.Data.LoginWebAppContext _context;

        public DetailsModel(LoginWebApp.Data.LoginWebAppContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.ID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
