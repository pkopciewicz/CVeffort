using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CVeffort.Models;

namespace CVeffort.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CVeffort.Models.DamagedUnits> DamagedUnits { get; set; }/*This line represents bridge between SQLdb and APP*/
    }
}
