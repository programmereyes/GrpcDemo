using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EmployeeMessages;
using Grpc.Core;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using static EmployeeMessages.EmployeeService;

namespace EmployeeManagementClient
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private Channel _channel;
        private EmployeeServiceClient _client;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _channel = new Channel("localhost", 80992, ChannelCredentials.Insecure);
            _client = new EmployeeServiceClient(_channel);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
               var response=await _client.GetEmployeeAsync(new GetEmployeeRequest() { EmployeeId = 1234 });
               _logger.LogInformation(response.Employee.FirstOrDefault().Firstname + " " + response.Employee.FirstOrDefault().Lastname);
            }
        }
    }
}
