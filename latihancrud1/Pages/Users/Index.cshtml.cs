using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using latihancrud1.Data;
using latihancrud1.Model;

namespace latihancrud1.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly latihancrud1.Data.latihancrud1Context _context;

        public IndexModel(latihancrud1.Data.latihancrud1Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
