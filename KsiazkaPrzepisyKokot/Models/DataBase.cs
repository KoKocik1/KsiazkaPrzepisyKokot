using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiazkaPrzepisyKokot.Models
{   
    public class DataBase : DbContext
    {
        public DbSet<CiastaDto> ciasta { get; set; }
        public DbSet<Drinki> drinki { get; set; }
        public DbSet<Fit> fit { get; set; }
        public DbSet<Kolacje> kolacje { get; set; }
        public DbSet<Log> log { get; set; }
        public DbSet<Obiady> obiady { get; set; }
        public DbSet<Przepisy> przepisy { get; set; }
        public DbSet<Salatki> salatki { get; set; }
        public DbSet<Skladnik> skladniki { get; set; }
        public DbSet<Slone_przekaski> slone_przekaski { get; set; }
        public DbSet<Sniadania> sniadania { get; set; }
        public DbSet<Sosy> sosy { get; set; }
        public DbSet<Ulubione> ulubione { get; set; }
        public DbSet<WszystkieSkladniki> BasketItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=C:\\Users\\Student\\source\\repos\\KokotLab3Taib\\Models\\database.db");
            //optionsBuilder.UseSqlite("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
