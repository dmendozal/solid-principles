using OpenClosed.Solution.Models;

namespace OpenClosed.Solution.Services.Report
{
    public interface IReportingService
    {
        public void GenerateReport(DocumentModel documentModel);
    }
}
