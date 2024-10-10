using System.Windows;
using System.Windows.Controls;

namespace WpfUserControlExam
{
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();
        }

        public Person Person
        {
            get { return (Person)GetValue(PersonProperty); }
            set
            {
                SetValue(PersonProperty, value);
                DataContext = value;  // DataContext를 Person으로 설정
            }
        }

        public static readonly DependencyProperty PersonProperty =
            DependencyProperty.Register("Person", typeof(Person), typeof(PersonControl), new PropertyMetadata(null));
    }
}