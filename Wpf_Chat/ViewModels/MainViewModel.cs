using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Configuration;
using Wpf_Chat.Models;
using Wpf_Chat.Services;

namespace Wpf_Chat.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        #region Private Field
        private readonly IViewService _viewService;
        private readonly ISignalRControl _signalRControl;
        private readonly IConfiguration _configuration;
        private HubConnection? _hubConnection;
        #endregion


        #region Bingding Members
        public string SignalRHost
        {
            get { return _signalRHost; }
            set { SetProperty(ref _signalRHost, value); }
        }
        private string _signalRHost = string.Empty;
        public string SignalRVPN
        {
            get { return _signalRVPN; }
            set { SetProperty(ref _signalRVPN, value); }
        }
        private string _signalRVPN = string.Empty;
        public string SignalRUser
        {
            get { return _signalRUser; }
            set { SetProperty(ref _signalRUser, value); }
        }
        private string _signalRUser = string.Empty;
        public string SignalRPassword
        {
            get { return _signalRPassword; }
            set { SetProperty(ref _signalRPassword, value); }
        }
        private string _signalRPassword = string.Empty;
        public string NickName
        {
            get { return _nickName; }
            set { SetProperty(ref _nickName, value); }
        }
        private string _nickName = string.Empty;
        public string StatusBar1
        {
            get { return _statusBar1; }
            set { SetProperty(ref _statusBar1, value); }
        }
        private string _statusBar1 = "Status: Ready";
        public string StatusBar2
        {
            get { return _statusBar2; }
            set { SetProperty(ref _statusBar2, value); }
        }
        private string _statusBar2 = "Please Connect Server first!";
        #endregion

        #region Constructor
        public MainViewModel(
            ISignalRControl signalRControl,
            IViewService viewService,
            IConfiguration configuration)
        {
            // 서비스 준비
            _viewService = viewService;
            _signalRControl = signalRControl;

            // appsettings.josn
            _configuration = configuration;
            IConfigurationSection SignalRConfig = configuration.GetSection("SignalRConfig");
            IConfigurationSection MyProfile = configuration.GetSection("MyProfile");
            SignalRHost = SignalRConfig["Server"];
            SignalRVPN = SignalRConfig["VPN"];
            SignalRUser = SignalRConfig["UserName"];
            SignalRPassword = SignalRConfig["Password"];
            NickName = MyProfile["Name"];
        }
        #endregion

        //public bool IsConnected => _hubConnection?.State == HubConnectionState.Connected;

        public void ConnectServer(object? obj)
        {
            _hubConnection = _signalRControl.Connect();
        }

        private void ShowSubView(object? obj)
        {
            try
            {
                var subData = new SubData()
                {
                    NickName = NickName,
                    HConnection = _hubConnection,
                };
                _viewService.ShowSubView(subData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.Source}");
                throw;
            }
        }


        public async ValueTask DisposeAsync()
        {
            if (_hubConnection is not null)
            {
                await _hubConnection.DisposeAsync();
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

        public ICommand ShowSubViewCommand => new RelayCommand<object>(ShowSubView);
        public ICommand ConnectServerCommand => new RelayCommand<object>(ConnectServer);
    }
}
