using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class MemberPageINotify : Page
    {
        //List<Person> member = null;

        ObservableCollection<Person> member = null;
        public MemberPageINotify()
        {
            InitializeComponent();

            //member = new List<Person>();

            member = new ObservableCollection<Person>();

            member.Add(new Person() { ID = "m100", Password = "1234", Name = "Hong", Phone = "010-0000-1111", Gender = "M" });
            member.Add(new Person() { ID = "m200", Password = "4321", Name = "Kim", Phone = "010-1000-1000", Gender = "M" });
            member.Add(new Person() { ID = "m300", Password = "12341234", Name = "Song", Phone = "010-0100-1010", Gender = "F" });
            member.Add(new Person() { ID = "m400", Password = "12341111", Name = "Gil", Phone = "010-0010-0101", Gender = "M" });

            memberList.ItemsSource = member;
            //MessageBox.Show(member.Count.ToString());
        }

        private void Add_member(object sender, RoutedEventArgs e)
        {
            member.Add(new Person() { ID = "m700", Password = "756771234", Name = "Hong1", Phone = "010-0000-1151", Gender = "M" });
           // MessageBox.Show(member.Count.ToString());

        }


        private void Add_member1(object sender, RoutedEventArgs e)
        {             
            member.Add(new Person() {  ID = id.Text, 
                                        Password = pw.Text, 
                                        Name = name.Text, 
                                        Phone = phone.Text, 
                                        Gender = "M" });
            //MessageBox.Show(member.Count.ToString());
        }
    }
}
