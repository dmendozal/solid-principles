using OpenClosed.Solution.Models;

namespace OpenClosed.Solution.Services.ReportGenerator
{
    public interface IReportGenerator
    {
        public void CreateReport(DocumentModel documentModel);
    }
}
