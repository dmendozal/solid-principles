namespace OpenClosed.Problem
{
    public class ReportingController
    {
        public void GenerateReport(DocumentInformation document, ReportType type)
        {
            switch (type)
            {
                case ReportType.PDF:
                    CreatePDFReport(document);
                    break;
                case ReportType.EXCEL:
                    CreateExcelReport(document);
                    break;
                case ReportType.JSON:
                    CreateJsonReport(document);
                    break;
            }
        }

        private void CreateJsonReport(DocumentInformation document)
        {
            // Create Json Report
        }

        private void CreateExcelReport(DocumentInformation document)
        {
            // Create Excel Report
        }

        private void CreatePDFReport(DocumentInformation document)
        {
            // Create Pdf Report
        }
    }
}