using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using latihancrud1.Model;

namespace latihancrud1.Data
{
    public class latihancrud1Context : DbContext
    {
        public latihancrud1Context (DbContextOptions<latihancrud1Context> options)
            : base(options)
        {
        }

        public DbSet<latihancrud1.Model.User> User { get; set; } = default!;
    }
}
