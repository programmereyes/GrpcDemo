using Chat.Contract;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Chat.Contract.ChatService;

namespace Chat.Server.Services
{
    public class ChatService : ChatServiceBase
    {
        private static readonly Dictionary<Guid, IServerStreamWriter<ChatMessageResponse>> connectionCollection =
            new Dictionary<Guid, IServerStreamWriter<ChatMessageResponse>>();
        public override async Task SendMessage(IAsyncStreamReader<ChatMessageRequest>
            requestStream, IServerStreamWriter<ChatMessageResponse> responseStream, ServerCallContext context)
        {
            connectionCollection.Add(Guid.NewGuid(), responseStream);
            while (await requestStream.MoveNext())
            {
                var request = requestStream.Current;
                foreach (var keyValuePair in connectionCollection)
                {
                    var response = keyValuePair.Value;
                    await response.WriteAsync(new ChatMessageResponse()
                    {
                        Message = request.Message,
                        Timestamp = request.Timestamp
                    });
                }
            }
        }
    }
}
