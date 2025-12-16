using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalDataReporter.Core;

namespace UniversalDataReporter.DataAccess
{
    public class ReportDbContext : DbContext
    {
        // Reports Tabelle in der Datenbank
        public DbSet<ReportConfig> Reports { get; set; }

        public ReportDbContext()
        {
            // Erstellt die Datenbank-Datei automatisch, falls sie fehlt.
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Nutzt SQLite und legt die Datei "reports.db" an
            optionsBuilder.UseSqlite("Data Source=reports.db");
        }
    }
}
