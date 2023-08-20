using Microsoft.AspNetCore.SignalR.Client;

namespace Wpf_Chat.Models
{
  public class SubData
  {
    public string StringData { get; set; } = string.Empty;
    public int IntData { get; set; }
    public HubConnection HConnection { get; set; }
    }
}
