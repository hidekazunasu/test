using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace test
{
    public class sample
    {
        [FunctionName("sample")]
        public void Run([TimerTrigger("0 */1 * * * *", RunOnStartup = false)]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            Console.WriteLine("Hello World");
        }
    }
}
