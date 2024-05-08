namespace TestDev.Pro
{
    public class Logger
    {
        public void Log(string source, string message, string type)
        {
            try
            {
                string logFile = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName, "Logs");

                if (!Directory.Exists(logFile))
                {
                    Directory.CreateDirectory(logFile);
                }

                string report = Path.Combine(logFile, $"{source}_{DateTime.Now:ddMMyyyyThhmmss}.html");

                using (StreamWriter sw = new StreamWriter(report, true))
                {
                    string color = type.ToLower() switch
                    {
                        "warning" => "yellow",
                        "info" => "green",
                        "error" => "red",
                        "critical" => "red",
                        "debug" => "black",
                        _ => "black"
                    };

                    sw.WriteLine($"<hr/><p style='color:{color}'>[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{type}] {source}: {message}</p>");

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error while writing to log file: {ex.Message}");
            }
        }
    }
}

