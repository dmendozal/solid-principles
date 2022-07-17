using OpenClosed.Solution.Models;
using OpenClosed.Solution.Services.Report;
using OpenClosed.Solution.Services.ReportGenerator;

namespace OpenClosed.Solution
{
    public class ReportingController
    {
        private IReportingService _reportingService;

        public ReportingController(IReportingService reportingService)
        {
            _reportingService = reportingService;
        }

        public void GeneratePdf(DocumentModel documentModel)
        {
            _reportingService = new ReportingService(new ReportGeneratorPDF());
            _reportingService.GenerateReport(documentModel);
        }

        public void GenerateJson(DocumentModel documentModel)
        {
            _reportingService = new ReportingService(new ReportGeneratorJson());
            _reportingService.GenerateReport(documentModel);
        }

        public void GenerateExcel(DocumentModel documentModel)
        {
            _reportingService = new ReportingService(new ReportGeneratorExcel());
            _reportingService.GenerateReport(documentModel);
        }
    }
}
