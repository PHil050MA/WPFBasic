using System.Collections.ObjectModel;
using System.Windows;


namespace WpfUserControlExam
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ListBoxPersonControl1 : Window
    {
        public ObservableCollection<Person> People { get; set; }

        public ListBoxPersonControl1()
        {
            InitializeComponent();

            // 샘플 데이터 생성
            People = new ObservableCollection<Person>
            {
                new Person() { ID = "m100", Password = "1234", Name = "Hong", Phone = "010-0000-1111", Gender = "M" },
                new Person() { ID = "m200", Password = "4321", Name = "Kim", Phone = "010-1000-1000", Gender = "M" },
                new Person() { ID = "m300", Password = "12341234", Name = "Song", Phone = "010-0100-1010", Gender = "F" },
                new Person() { ID = "m400", Password = "12341111", Name = "Gil", Phone = "010-0010-0101", Gender = "M" },

            };

            // DataContext 설정
            this.DataContext = this;
        }
    }
}