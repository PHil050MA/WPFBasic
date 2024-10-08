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
using static System.Net.Mime.MediaTypeNames;

namespace WpfDay2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            DataInputWindow inputWindow = new DataInputWindow();
            inputWindow.Top = this.Top + 10;
            inputWindow.Left = this.Left + 10;

            //inputWindow.Show();
            if (inputWindow.ShowDialog() == true)
            {
                myTextName.Text = inputWindow.myTextName.Text;
                myTextPhone.Text = inputWindow.myTextPhone.Text;
                myAge.Text = inputWindow.myAge.Text;


            }

        }
    }
}
