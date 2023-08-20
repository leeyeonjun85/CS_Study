using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wpf_Chat.Services
{
    public interface ISignalRControl
    {
        bool isConnected { get; set; }
        bool IsConnected { get; }
        List<string> Messages { get; set; }

        Task Connect(string serverAddress);
        Task Send(string userInput, string messageInput);
    }
}