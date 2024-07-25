namespace PhoneBookWithFile.Services
{
    internal interface ILoggingService
    {
        void LoggingInformation(string message);
        void LogingError(string message);
    }
}