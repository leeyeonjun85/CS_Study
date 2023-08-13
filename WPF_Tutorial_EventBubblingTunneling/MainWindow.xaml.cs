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

namespace WPF_Tutorial_EventBubblingTunneling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> list = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetBubblingTextBox()
        {
            txtBubbling.Text = string.Join(" > ", list);
            ClearList();
        }

        private async void ClearList()
        {
            await Task.Delay(100);
            list.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list.Add("Button-Gray");
            SetBubblingTextBox();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("Button-Blue");
            SetBubblingTextBox();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("Button-Red");
            SetBubblingTextBox();
        }
    }
}
