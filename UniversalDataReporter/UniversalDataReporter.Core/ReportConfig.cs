using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalDataReporter.Core
{
    public class ReportConfig
    {
        public int Id { get; set; } // Eindeutige ID für die DB
        public string Title { get; set; } = string.Empty;// Name des Berichts
        public string Query { get; set; } = string.Empty; // Die SQL-Abfrage
        public string ExportPath { get; set; } = string.Empty; // Speicherort für den Export
        public DateTime LastRun { get; set; } // Zeitpunkt der letzten Ausführung

    }
}
