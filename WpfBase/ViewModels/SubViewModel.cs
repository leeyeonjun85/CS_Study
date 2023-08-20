using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using WpfBase.Models;

namespace WpfBase.ViewModels
{
    public class SubViewModel : ViewModelBase, IParameterReceiver
    {
        public SubData SubData { get; set; } = default!;

        public void ReceiveParameter(object parameter)
        {
            if (parameter is SubData subData)
            {
                SubData = subData;
            }
        }

        protected override void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("SubWindow Loaded");
        }

        protected override void OnWindowClosing(object? sender, CancelEventArgs e)
        {
            MessageBox.Show("SubWindow Closing");
        }

        public ICommand CloseCommand => new RelayCommand<object>(_ => Window?.Close());
    }
}
