using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CarGlass.Models
{
    public class Context : DbContext
    {
        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Empresa> Empresas { get; set; }
    }
}