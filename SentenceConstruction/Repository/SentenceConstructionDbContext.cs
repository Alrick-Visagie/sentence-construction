using Microsoft.EntityFrameworkCore;
using SentenceConstruction.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentenceConstruction.Repository
{
    public class SentenceConstructionDbContext: DbContext
    {
        public SentenceConstructionDbContext(DbContextOptions options) : base(options)
        {}

        DbSet<Sentences> Sentences { get; set; }
        DbSet<Words> Words { get; set; }
    }
}
