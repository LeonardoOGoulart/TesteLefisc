using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteLefisc.Models;

namespace TesteLefisc.Data
{
    public class TesteLefiscContext : DbContext
    {
        public TesteLefiscContext (DbContextOptions<TesteLefiscContext> options)
            : base(options)
        {
        }

        public DbSet<TesteLefisc.Models.Fornecedores> Fornecedores { get; set; }
    }
}
