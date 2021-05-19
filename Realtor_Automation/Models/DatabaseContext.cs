using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Ev>  TBLEv { get; set; }
        public DbSet<Musteri> TBLMusteri { get; set; }
        public DbSet<Admin> TBLAdmin { get; set; }
        public DbSet<EvTur> TBLEvTur { get; set; }
        public DbSet<MusteriTur> TBLMusteriTur { get; set; }
        public DbSet<Kiralanan> TBLKiralanan { get; set; }
        public DbSet<Satilan> TBLSatilan { get; set; }

    }
}
