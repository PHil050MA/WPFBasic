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

namespace WpfDay2
{
    /// <summary>
    /// MemberPage2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MemberPage2 : Page
    {
        List<Person> member = null;
        public MemberPage2()
        {
            InitializeComponent();
            member = new List<Person>();
            member.Add(new Person() { ID = "m100", Password = "1234", Name = "Hong", Phone = "010-0000-1111", Gender = "M" });
            member.Add(new Person() { ID = "m200", Password = "4321", Name = "Kim", Phone = "010-1000-1000", Gender = "M" });
            member.Add(new Person() { ID = "m300", Password = "12341234", Name = "Song", Phone = "010-0100-1010", Gender = "F" });
            member.Add(new Person() { ID = "m400", Password = "12341111", Name = "Gil", Phone = "010-0010-0101", Gender = "M" });
            
            memberList.ItemsSource = member;
        }
    }
}
