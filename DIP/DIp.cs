using System;

// Dependency Inversion Principle
public interface ILogger
{
    void LogMessage(string message);
}

public class FileLogger : ILogger
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Logging to file: {message}");
    }
}

public class DatabaseLogger : ILogger
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Logging to database: {message}");
    }
}

public class UserManager
{
    private readonly ILogger _logger;

    public UserManager(ILogger logger)
    {
        _logger = logger;
    }

    public void CreateUser(string username, string password)
    {
        // user yaradilir
        _logger.LogMessage($"User '{username}' created.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // loglarimiz yaranir 
        ILogger fileLogger = new FileLogger();
        ILogger databaseLogger = new DatabaseLogger();

        // Dip komeyi ile Usermanager yaradiriq 
        UserManager userManagerWithFileLogger = new UserManager(fileLogger);
        UserManager userManagerWithDatabaseLogger = new UserManager(databaseLogger);

        // User yaradiriq 
        userManagerWithFileLogger.CreateUser("Turqay", "123");
        userManagerWithDatabaseLogger.CreateUser("Tuncay", "321");

    }
}
