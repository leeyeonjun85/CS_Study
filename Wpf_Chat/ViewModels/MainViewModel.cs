using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Configuration;
using Wpf_Chat.Services;

namespace Wpf_Chat.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        private readonly IViewService _viewService;
        private readonly ISignalRControl _signalRControl;
        public IConfiguration _configuration;
        private HubConnection? hubConnection;

        public ICommand ShowSubViewCommand => new RelayCommand<object>(ShowSubView);
        public ICommand ConnectServerCommand => new RelayCommand<object>(ConnectServer);

        public string? Value1 { get; set; } = string.Empty;
        public string? Value2 { get; set; } = string.Empty;
        public string? Value3 { get; set; } = string.Empty;
        public string? Value4 { get; set; } = string.Empty;
        public string? NickName { get; set; } = string.Empty;
        public ObservableCollection<string> LogList { get; set; }

        public MainViewModel(
            ISignalRControl signalRControl,
            IViewService viewService,
            IConfiguration configuration)
        {
            _viewService = viewService;
            _configuration = configuration;
            _signalRControl = signalRControl;

            IConfigurationSection SignalRConfig = configuration.GetSection("SignalRConfig");
            IConfigurationSection MyProfile = configuration.GetSection("MyProfile");
            Value1 = SignalRConfig["Server"];
            Value2 = SignalRConfig["VPN"];
            Value3 = SignalRConfig["UserName"];
            Value4 = SignalRConfig["Password"];
            NickName = MyProfile["Name"];

            LogList = new ObservableCollection<string>() { "==== Log ====", "프로그램을 시작합니다." };
        }

        public bool IsConnected => hubConnection?.State == HubConnectionState.Connected;

        private void ShowSubView(object? obj)
        {
            try
            {
                //await _signalRControl.Send(Value3, (string)((TextBox)obj).Text);
                LogList.Add($"{NickName!} 님이 채팅방에 들어갔습니다.");
                _viewService.ShowSubView(new Models.SubData { StringData = NickName!, IntData = 123, HConnection = hubConnection });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.Source}");
                throw;
            }
        }

        public async void ConnectServer(object? obj)
        {
            try
            {
                //await _signalRControl.Connect(Value1!);
                //LogList.Add($"연결 완료 : {_signalRControl.isConnected}");


                hubConnection = new HubConnectionBuilder()
                    //.WithUrl(serverAddress)
                    .WithUrl(@"https://localhost:7076/chathub")
                    .Build();
                LogList.Add($"연결 완료 : {IsConnected}");

            }
            catch (Exception ex)
            {
                LogList.Add($"{ex.Message}{Environment.NewLine}{ex.Source}");
                throw;
            }

        }

        protected override void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("MainWindow Loaded");
        }

        protected override void OnWindowClosing(object? sender, CancelEventArgs e)
        {
            var result = MessageBox.Show("종료 하시겠습니까?", "프로그램 종료", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }

        }

    }
}
