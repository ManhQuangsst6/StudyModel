
using System.Diagnostics;

namespace StudyModel.Middleware
{
    public class FactoryMiddleware(ILogger<FactoryMiddleware>_logger) : IMiddleware
    {
        
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            _logger.LogInformation("aa1");
            await next.Invoke(context);
            _logger.LogInformation("aa2");

            sw.Stop();

            Console.WriteLine("Elapsed={0}", sw.Elapsed);
           

        }
    }
}
