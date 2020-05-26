using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class VisitDetailContext : DbContext
    {
        public VisitDetailContext(DbContextOptions<VisitDetailContext> options) : base(options)
        {

        }

        public DbSet<VisitDetail> VisitDetails { get; set; }
    }
}
