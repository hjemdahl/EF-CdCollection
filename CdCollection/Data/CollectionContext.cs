using System;
using CdCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace CdCollection.Data
{
    public class CollectionContext : DbContext
    {
        public CollectionContext(DbContextOptions<CollectionContext> options) : base(options)
        {
        }

        public DbSet<Artist> Artist { get; set; }
        public DbSet<Cd> Cd { get; set; }
    }
}