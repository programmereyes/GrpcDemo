using Chat.Contract;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Chat.Contract.ChatService;
using Google.Protobuf.WellKnownTypes;
using System.Threading;

namespace Chat.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string Host = "localhost";
        private const int Port = 8099;
        private Channel _channel;
        private AsyncDuplexStreamingCall<ChatMessageRequest, ChatMessageResponse> _SendMessage;
        private void WriteLn(string text)
        {
            txtBoxMessages.Dispatcher.BeginInvoke(new Action(() =>
            {
                txtBoxMessages.Text += text + Environment.NewLine;
            }));
        }

        public MainWindow()
        {
            InitializeComponent();
            InitializeGrpc();
        }


        private void InitializeGrpc()
        {
            _channel = new Channel(Host, Port, ChannelCredentials.Insecure);
            var _client = new ChatServiceClient(_channel);
            _SendMessage = _client.SendMessage();
        }

        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            var chatMessage = new ChatMessageRequest()
            {
                From = txtBoxName.Text.Trim(),
                Message = txtBoxMessage.Text.Trim(),
                Timestamp = Timestamp.FromDateTimeOffset(DateTimeOffset.Now),
                To = "Michael"
            };
            _SendMessage.RequestStream.WriteAsync(chatMessage);
        }

        private async void ChatWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                while(await _SendMessage.ResponseStream.MoveNext(CancellationToken.None))
                {
                    var serverResponse = _SendMessage.ResponseStream.Current;
                    WriteLn(serverResponse.Message);
                }
            }
            catch (RpcException ex)
            {
                _SendMessage = null;
                _channel = null;
                throw ex;
            }
        }
    }
}
