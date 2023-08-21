using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using Wpf_Chat.Views;

namespace Wpf_Chat.Services
{
    public class SignalRControl : ISignalRControl
    {
        private HubConnection? _hubConnection;

        public SignalRControl()
        {
            var aaa = new SubView();
            var bbb = aaa.MyMessage;

        }

        public string Messages { get; set; } = "채팅을 시작합니다.";
        //public ObservableCollection<string> Messages { get; set; } = new ObservableCollection<string>();
        //public bool isConnected { get; set; } = false;




        //public bool IsConnected => hubConnection?.State == HubConnectionState.Connected;

        public HubConnection Connect(string serverAddress = @"https://localhost:7076/chathub")
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(serverAddress)
                .Build();

            _hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                //Messages.Add($"{user}: {message}");
                Messages += $"{Environment.NewLine}{user} : {message}";
            });

            return _hubConnection;

            //await hubConnection.StartAsync();

            //isConnected = IsConnected;
        }

        public async Task Send(string userInput, string messageInput)
        {
            if (_hubConnection is not null)
            {
                await _hubConnection.SendAsync("SendMessage", userInput, messageInput);
            }
        }
    }
}
