using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOP.Data
{
    public class BazaZaUnosNaloga: DbContext
    {
        protected readonly IConfiguration Configuration;

        public BazaZaUnosNaloga(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("Connection"));
        }

        public DbSet<ZaposlenikBaza> ZaposlenikBaza { get; set; }
    }
}
