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
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components;

namespace Wpf_Chat
{
    

    public partial class MainWindow : Window
    {
        private HubConnection? hubConnection;
        private List<string> messages = new List<string>();

        //public List<string> messages { get; set; }

        private string? userInput;
        private string? messageInput;
        NavigationManager Navigation;

        public MainWindow()
        {
            InitializeComponent();

            hubConnection = new HubConnectionBuilder()
            .WithUrl(@"https://localhost:7076/chathub")
            .Build();

            startConnection();
        }

        async void startConnection()
        {
            hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                var encodedMsg = $"{user}: {message}";
                messages.Add(encodedMsg);
                lstbx1.Items.Add(encodedMsg);
                lstbx1.Items.Refresh();
                //InvokeAsync(StateHasChanged);
            });

            await hubConnection.StartAsync();
        }


        private async void btnSend_Click(object sender, RoutedEventArgs e)
        {
            if (hubConnection is not null)
            {
                await hubConnection.SendAsync("SendMessage", "이연준", txtbx1.Text);
            }
        }
    }
}
