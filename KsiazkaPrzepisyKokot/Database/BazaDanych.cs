using KsiazkaPrzepisyKokot.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace KsiazkaPrzepisyKokot.Database
{
    public class BazaDanych:DbContext
    {
        
        public DbSet<Ciasta> Ciasta { get; set; }
        public DbSet<Drinki> Drinki { get; set; }
        public DbSet<Fit> Fit { get; set; }
        public DbSet<Kolacje> Kolacje { get; set; }  
        public DbSet<Obiady> Obiady { get; set; }      
        public DbSet<Salatki> Salatki { get; set; }  
        public DbSet<Slone_przekaski> Slone_przekaski { get; set; }
        public DbSet<Sniadania> Sniadania { get; set; }
        public DbSet<Sosy> Sosy { get; set; }
        

        public DbSet<SkladnikiPrzepisu> SkladnikiPrzepisu { get; set; }

        public DbSet<WszystkieSkladniki> WszystkieSkladniki { get; set; }

        public DbSet<Przepisy> Przepisy { get; set; }

        public DbSet<Ulubione> Ulubione { get; set; }
        public DbSet<Log> Log { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
            SqliteConnection _connection = new SqliteConnection("Filename=:memory:");
            _connection.Open();
            optionsBuilder.UseSqlite(_connection);
            */
            optionsBuilder.UseSqlite("Data Source=Database\\database.db");
        }
    }
}
