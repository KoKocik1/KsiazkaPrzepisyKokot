﻿using KsiazkaPrzepisyKokot.Models;
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
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\SRRobotics\\source\\repos\\KsiazkaPrzepisyKokot\\KsiazkaPrzepisyKokot\\Database\\database.db");
        }
    }
}
