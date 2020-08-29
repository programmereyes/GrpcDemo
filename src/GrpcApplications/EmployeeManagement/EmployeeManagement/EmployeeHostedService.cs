using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Grpc.Core;

namespace EmployeeManagement
{
    public class EmployeeHostedService : IHostedService
    {
        Server server = null;
        public Task StartAsync(CancellationToken cancellationToken)
        {
            server = new Server();
            server.Ports.Add(new ServerPort("localhost", 80992, ServerCredentials.Insecure));
            server.Services.Add(EmployeeMessages.EmployeeService.BindService(new EmployeeService()));
            server.Start();
             return Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
           await server.ShutdownAsync();
        }
    }
}
