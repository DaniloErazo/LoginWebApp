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
    public class IndexModel : PageModel
    {
        private readonly LoginWebApp.Data.LoginWebAppContext _context;

        public IndexModel(LoginWebApp.Data.LoginWebAppContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
