namespace SingleResponsibility.Solution.Services.Logger
{
    public interface ILoggerService
    {
        void Info(string message);
        void Error(string message, Exception exception);
        void Debug(string message);
    }
}