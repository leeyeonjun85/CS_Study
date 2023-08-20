using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Configuration;
using Wpf_Chat.Models;
using Wpf_Chat.Services;
using static System.Net.Mime.MediaTypeNames;

namespace Wpf_Chat.ViewModels
{
    public class SubViewModel : ViewModelBase, IParameterReceiver
    {
        public readonly ISignalRControl _signalRControl;
        public IConfiguration _configuration;
        private ObservableCollection<string> _messages;

        
        public SubViewModel(
            ISignalRControl signalRControl,
            IConfiguration configuration)
        {
            _signalRControl = signalRControl;
            _configuration = configuration;

            Messages = new ObservableCollection<string>() { "==== Chat ====", "채팅을 시작합니다." };



        }

        public SubData SubData { get; set; } = default!;

        public ObservableCollection<string> Messages
        {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }

        public ICommand CloseCommand => new RelayCommand<object>(_ => Window?.Close());
        public ICommand SendCommand => new RelayCommand<object>(SendMessage!);

        private void SendMessage(object obj)
        {

            //await Task.Delay(10);
            //Thread.Sleep(10);

            if (SubData.HConnection is not null)
            {
                SubData.HConnection.SendAsync("SendMessage", SubData.StringData, ((TextBox)obj).Text);
                Thread.Sleep(10);
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
            StartAsync();
            _signalRControl.Send(SubData.StringData, "채팅방에 입장하였습니다.");
            //MessageBox.Show("SubWindow Loaded");
        }

        protected override void OnWindowClosing(object? sender, CancelEventArgs e)
        {
            //MessageBox.Show("SubWindow Closing");
        }

        public async void StartAsync()
        {

            SubData.HConnection.On<string, string>("ReceiveMessage", async (user, message) =>
            {
                Messages.Add($"{user}: {message}");
            });

            await SubData.HConnection.StartAsync();
        }

    }
}
