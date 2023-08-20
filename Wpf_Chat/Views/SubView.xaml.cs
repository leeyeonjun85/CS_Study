using System.Collections.Generic;
using System.Windows;

namespace Wpf_Chat.Views
{
    /// <summary>
    /// SubView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SubView : Window
    {
        public SubView()
        {
            InitializeComponent();
            lstbxChat.Items.Clear();
        }





        //public List<string> Messages
        //{
        //    get { return (List<string>)GetValue(MessagesProperty); }
        //    set { SetValue(MessagesProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for Messages.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty MessagesProperty =
        //    DependencyProperty.Register("Messages", typeof(List<string>), typeof(SubView), new PropertyMetadata(null));




    }
}
