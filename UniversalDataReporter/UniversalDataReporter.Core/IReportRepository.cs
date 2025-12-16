using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalDataReporter.Core
{
    public interface IReportRepository
    {
        Task<List<ReportConfig>> GetAllReportsAsync();

        Task SaveReportAsync(ReportConfig report);

        Task DeleteReportAsync(int id);
    }
}
