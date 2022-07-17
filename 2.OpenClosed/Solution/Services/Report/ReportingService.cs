using OpenClosed.Solution.Models;
using OpenClosed.Solution.Services.ReportGenerator;

namespace OpenClosed.Solution.Services.Report
{
    public class ReportingService : IReportingService
    {
        private readonly IReportGenerator _reportGenerator;
        public ReportingService(IReportGenerator reportGenerator)
        {
            _reportGenerator = reportGenerator;
        }

        public void GenerateReport(DocumentModel documentModel)
        {
            _reportGenerator.CreateReport(documentModel);
        }
    }
}
