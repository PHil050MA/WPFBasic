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

namespace WpfTemplateExam
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ButtonTemplate2 : Window
    {
        int fontsize = 10;
        public ButtonTemplate2()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("버튼 클릭");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            this.Resources["ButtonBackgroundBrush"] = new SolidColorBrush(Colors.Orange);
            
        }
    }
}
