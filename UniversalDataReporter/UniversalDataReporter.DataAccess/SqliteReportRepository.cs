using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using UniversalDataReporter.Core;

namespace UniversalDataReporter.DataAccess
{
    public class SqliteReportRepository : IReportRepository
    {
        private readonly ReportDbContext _context;

        public SqliteReportRepository()
        {
            _context = new ReportDbContext();
        }

        // Lade alle Berichte
        public async Task<List<ReportConfig>> GetAllReportsAsync()
        {
            return await _context.Reports.ToListAsync();
        }

        // Speichere Bericht
        public async Task SaveReportAsync(ReportConfig report)
        {
            if (report.Id == 0)
            {
                await _context.Reports.AddAsync(report);
            }
            else
            {
                _context.Reports.Update(report);
            }
            await _context.SaveChangesAsync();
        }

        // Lösche Bericht (Hier lag vermutlich der Fehler)
        public async Task DeleteReportAsync(int id)
        {
            var report = await _context.Reports.FindAsync(id);
            if (report != null)
            {
                _context.Reports.Remove(report);
                await _context.SaveChangesAsync();
            }
        }
    }
}