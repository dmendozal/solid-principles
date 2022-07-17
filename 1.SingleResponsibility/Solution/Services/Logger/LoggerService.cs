namespace SingleResponsibility.Solution.Services.Logger
{
    public class LoggerService : ILoggerService
    {
        private const string _loggetPath = @"c:\log.txt";
        public LoggerService()
        {
            // constructor to create the log file configuration logic.
        }

        public void Debug(string message)
        {
            Console.WriteLine("Saving message on debug mode.", message);
        }

        public void Error(string message, Exception exception)
        {
            Console.WriteLine("Saving message on error mode.", message, exception);
        }

        public void Info(string message)
        {
            Console.WriteLine("Saving message on info mode.", message);
        }
    }
}
