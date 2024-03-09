using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOP.Modeli
{
    public class ContextDB:DbContext
    {
        public DbSet<Useri_i_paswordi> Zaposlenici { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            =>options.UseSqlite(@"Data Source=C:\Users\Lenovo.DESKTOP-7HJOOS6\Documents\BazaPodataka\Zaposlenici.db");
    }
}
