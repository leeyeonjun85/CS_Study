using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace Wpf_Chat.Services
{
    public interface ISignalRControl
    {
        string Messages { get; set; }

        HubConnection Connect(string serverAddress = "https://localhost:7076/chathub");
        Task Send(string userInput, string messageInput);
    }
}