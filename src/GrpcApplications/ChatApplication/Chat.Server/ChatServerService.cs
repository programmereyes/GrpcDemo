using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Chat.Contract;
using Grpc.Core;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Chat.Server
{
    public class ChatServerService : IHostedService
    {
        private readonly ILogger<ChatServerService> _logger;
        private Grpc.Core.Server _server;
        private const string Host = "localhost";
        private const int Port = 8099;

        public ChatServerService(ILogger<ChatServerService> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _server = new Grpc.Core.Server();
            var serverCredential = ServerCredentials.Insecure;
            _server.Ports.Add(Host, Port, serverCredential);
            _server.Services.Add(ChatService.BindService(new Services.ChatService()));
            _server.Start();
            _logger.LogInformation("Grpc Server Started");
            return Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Grpc Server Shutdown");
            await _server.ShutdownAsync();
        }
    }
}
