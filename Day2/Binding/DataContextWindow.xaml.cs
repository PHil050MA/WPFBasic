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

namespace WpfDay2Binding
{
    /// <summary>
    /// DataContextWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public class Member
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }



    /// <summary>
    /// DataContextWindow1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DataContextWindow : Window
    {
        private Member member;
        public DataContextWindow()
        {
            InitializeComponent();

            member = new Member()
            {
                Name = "Hong Gil Dong",
                Phone = "010-1111-0000",
                Age = 30,
            };

            this.DataContext = member;
        }
    }
}
