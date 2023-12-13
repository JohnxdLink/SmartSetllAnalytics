using SmartSetll_Analytics_V2.classes;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Web;

public static class ExceptionLogger
{
    public static void LogCustomException(SqlException sqlEx, string customMessage)
    {
        // Specify the correct relative path from the application root
        string baseErrorLogPath = HttpContext.Current.Server.MapPath("~/resources/errorlogs/SmartSell_ErrorLog");
        string errorLogExtension = ".txt";
        string errorLogPath = GetUniqueErrorLogPath(baseErrorLogPath, errorLogExtension);

        using (StreamWriter writer = new StreamWriter(errorLogPath, true))
        {
            writer.WriteLine($"Timestamp: {DateTime.Now}");
            writer.WriteLine($"Custom Message: {customMessage}");
            writer.WriteLine($"Error Message:\n{sqlEx.Message}\n");
            writer.WriteLine($"StackTrace:\n{sqlEx.StackTrace}");
            writer.WriteLine(new string('-', 50));
        }
    }

    // Method to get a unique error log path
    private static string GetUniqueErrorLogPath(string baseErrorLogPath, string errorLogExtension)
    {
        string errorLogPath = $"{baseErrorLogPath}_{DateTime.Now:yyyyMMddHHmmssfff}{errorLogExtension}";
        int attempt = 1;

        // Ensure the file path is unique
        while (File.Exists(errorLogPath))
        {
            errorLogPath = $"{baseErrorLogPath}_{DateTime.Now:yyyyMMddHHmmssfff}_{attempt}{errorLogExtension}";
            attempt++;
        }

        return errorLogPath;
    }
}
