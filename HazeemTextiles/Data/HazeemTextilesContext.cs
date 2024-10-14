using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HazeemTextiles.Model;

namespace HazeemTextiles.Data
{
    public class HazeemTextilesContext : DbContext
    {
        public HazeemTextilesContext (DbContextOptions<HazeemTextilesContext> options)
            : base(options)
        {
        }

        public DbSet<HazeemTextiles.Model.Customer> Customer { get; set; } = default!;
    }
}
