using System.Threading;

namespace BlazorApp1
{
    public class BackgroundWorkerService : BackgroundService
    {
        readonly ILogger<BackgroundWorkerService> _logger;

        public BackgroundWorkerService(ILogger<BackgroundWorkerService> logger)
        {
            _logger = logger;
        }



/*        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service start");

            while(!cancellationToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at:{time}", DateTimeOffset.Now);
                await Task.Delay(100, cancellationToken); 

            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service stop");
            return Task.CompletedTask;
        }*/


        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at:{time}", DateTimeOffset.Now);
                await Task.Delay(100, stoppingToken);

            }
        }
    }
}
