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
using System.Windows.Shapes;

namespace WpfDay2
{
    /// <summary>
    /// PageTestWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PageTestWindow : Window
    {
        public PageTestWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            frame_content.Source = new Uri("LoginPage.xaml", UriKind.Relative);
        }

        private void btnlist_Click(object sender, RoutedEventArgs e)
        {
            frame_content.Source = new Uri("MemberPage2.xaml", UriKind.Relative);
        }

        private void btnJoin_Click(object sender, RoutedEventArgs e)
        {
            frame_content.Source = new Uri("JoinPage.xaml", UriKind.Relative);
        }
    }
}
