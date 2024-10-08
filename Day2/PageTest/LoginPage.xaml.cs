using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace WpfDay2
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page1 : Page
    {
        
        public Page1()
        {
            InitializeComponent();
        }

        private void Login_Check(object sender, RoutedEventArgs e)
        {
            string name = this.name.Text;
            string pw = this.pw.Text;

            if (name.Equals("Hong") && pw.Equals("1234")){
                Uri uri = new Uri("/MemberPage2.xaml", UriKind.Relative);
                NavigationService.Navigate(uri);
            }
            else
            {
                Uri uri = new Uri("/JoinPage.xaml", UriKind.Relative);
                NavigationService.Navigate(uri);
            }

           
        }
    }
}
