using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Configuration;
using Wpf_Chat.Models;
using Wpf_Chat.Services;

namespace Wpf_Chat.ViewModels
{
    public class SubViewModel : ViewModelBase, IParameterReceiver
    {
        private readonly IViewService _viewService;
        private readonly IConfiguration _configuration;
        private readonly ISignalRControl _signalRControl;
        private string _nickName = string.Empty;
        private HubConnection? _hubConnection;

        public SubData SubData { get; set; } = default!;
        //public ObservableCollection<string> Messages
        //{
        //    get { return _messages; }
        //    set { SetProperty(ref _messages, value); }
        //}
        //private ObservableCollection<string> _messages = new ObservableCollection<string> { "채팅을 시작합니다." };
        ////private ObservableCollection<string> _messages;

        public string Messages
        {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }
        private string _messages = "채팅을 시작합니다.";
        //private string _messages;


        public SubViewModel(
            IViewService viewService,
            ISignalRControl signalRControl,
            IConfiguration configuration)
        {
            _viewService = viewService;
            _signalRControl = signalRControl;
            _configuration = configuration;
            //_messages = _signalRControl.Messages;
        }


        private void SendMessage(object obj)
        {

            //await Task.Delay(10);
            //Thread.Sleep(10);

            if (_hubConnection is not null)
            {
                _hubConnection.SendAsync("SendMessage", _nickName, ((TextBox)obj).Text);
            }
        }


        public void ReceiveParameter(object parameter)
        {
            if (parameter is SubData subData)
            {
                SubData = subData;
            }
        }

        protected override void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            _nickName = SubData.NickName;
            _hubConnection = SubData.HConnection;
            StartAsync();
            //_signalRControl.Send(_nickName, "채팅방에 입장하였습니다.");
            //MessageBox.Show("SubWindow Loaded");
        }

        protected override void OnWindowClosing(object? sender, CancelEventArgs e)
        {
            //MessageBox.Show("SubWindow Closing");
        }

        public async void StartAsync()
        {
            //_hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
            //{
            //    //Messages.Add($"{user}: {message}");
            //    Messages += $"{Environment.NewLine}{user} : {message}";
            //});
            await _hubConnection.StartAsync();
        }




        public ICommand CloseCommand => new RelayCommand<object>(_ => Window?.Close());
        public ICommand SendMessageCommand => new RelayCommand<object>(SendMessage!);
    }
}
