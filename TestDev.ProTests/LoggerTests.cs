using Microsoft.VisualStudio.TestPlatform.Utilities;
using TestDev.Pro;
using Xunit.Abstractions;

namespace TestDev.ProTests
{
    public  class LoggerTests
    {
        private readonly ITestOutputHelper output;

        public LoggerTests(ITestOutputHelper output)
        {
            this.output = output;
        }
        [Fact]
        public void LoggerInfoTest()
        {
            var source = "Test";
            var logger = new Logger();
            var expectedLogFile = $"{source}_{DateTime.Now:ddMMyyyyThhmmss}.html";

            logger.Log($"{source}", "Validating log type Info color green", "Info");

            var logFilePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName, "Logs", expectedLogFile);
            Assert.True(File.Exists(logFilePath));

            output.WriteLine($"This is the path:{logFilePath}");

        }

        [Fact]
        public void LoggerWarningTest()
        {
            var source = "Test";
            var logger = new Logger();
            var expectedLogFile = $"{source}_{DateTime.Now:ddMMyyyyThhmmss}.html";

            logger.Log($"{source}", "Validating log type Warning color yellow", "WARNING");

            var logFilePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName, "Logs", expectedLogFile);
            Assert.True(File.Exists(logFilePath));


            output.WriteLine($"This is the path:{logFilePath}");

        }

        [Fact]
        public void LoggerDebugTest()
        {
            var source = "Test";
            var logger = new Logger();
            var expectedLogFile = $"{source}_{DateTime.Now:ddMMyyyyThhmmss}.html";

            logger.Log($"{source}", "Validating log type debug color black", "DEBUG");

            var logFilePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName, "Logs", expectedLogFile); 
            Assert.True(File.Exists(logFilePath));


            output.WriteLine($"This is the path:{logFilePath}");

        }
    }
}
