using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace Wpf_Chat.Services
{
    public class SignalRControl : ISignalRControl
    {
        private HubConnection? hubConnection;


        public List<string> Messages { get; set; } = new List<string>();
        //public ObservableCollection<string> Messages { get; set; } = new ObservableCollection<string>();
        public bool isConnected { get; set; } = false;




        public bool IsConnected => hubConnection?.State == HubConnectionState.Connected;

        public async Task Connect(string serverAddress)
        {
            hubConnection = new HubConnectionBuilder()
            //.WithUrl(serverAddress)
            .WithUrl(@"https://localhost:7076/chathub")
            .Build();

            hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                var encodedMsg = $"{user}: {message}";
                Messages.Add(encodedMsg);
            });

            await hubConnection.StartAsync();

            isConnected = IsConnected;
        }

        public async Task Send(string userInput, string messageInput)
        {
            if (hubConnection is not null)
            {
                await hubConnection.SendAsync("SendMessage", userInput, messageInput);
            }
        }
    }
}
