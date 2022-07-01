using Microsoft.EntityFrameworkCore;
using RESTapiEmploye.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RESTapiEmploye.Entities
{
    public class RepositoriesContext:DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Employe> Employe { get; set; }
        public DbSet<Employe> Employes { get; set; }
    }
}
