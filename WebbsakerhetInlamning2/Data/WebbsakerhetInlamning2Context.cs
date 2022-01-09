using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebbsakerhetInlamning2.Models;

namespace WebbsakerhetInlamning2.Data
{
    public class WebbsakerhetInlamning2Context : DbContext
    {
        public WebbsakerhetInlamning2Context (DbContextOptions<WebbsakerhetInlamning2Context> options)
            : base(options)
        {
        }

        public DbSet<Comment> Comment { get; set; }
        public DbSet<ApplicationFile> ApplicationFiles { get; set; }

    }
}
