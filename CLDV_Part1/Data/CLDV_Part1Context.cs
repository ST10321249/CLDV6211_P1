using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CLDV_Part1.Models;

namespace CLDV_Part1.Data
{
    public class CLDV_Part1Context : DbContext
    {
        public CLDV_Part1Context (DbContextOptions<CLDV_Part1Context> options)
            : base(options)
        {
        }

        public DbSet<CLDV_Part1.Models.Venue> Venue { get; set; } = default!;
        public DbSet<CLDV_Part1.Models.Event> Event { get; set; } = default!;
        public DbSet<CLDV_Part1.Models.Booking> Booking { get; set; } = default!;
    }
}
