using System;
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
        }



        public string MyMessage
        {
            get { return (string)GetValue(MyMessageProperty); }
            set { SetValue(MyMessageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyMessage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyMessageProperty =
            DependencyProperty.Register("MyMessage", typeof(string), typeof(SubView), new PropertyMetadata("테스트", MessageChanged));

        private static void MessageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
