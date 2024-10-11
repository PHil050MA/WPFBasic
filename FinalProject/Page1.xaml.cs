using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WpfTabControl.ViewModel;
using WpfTabControl.Model;

namespace WpfTabControl.View
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page1 : Page
    {        
        public ObservableCollection<Person> People { get; set; }

        public Page1()
        {
            InitializeComponent();

            PersonService personService = new PersonService();
            People = personService.selectMember();
           
            memberList.ItemsSource = People;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {  
           

            var button = sender as Button;
            var personToDelete = button.CommandParameter as Person;

            //if (personToDelete != null)
            //{
            //    People.Remove(personToDelete);
            //}

            var result = MessageBox.Show($"{personToDelete.Name}님 탈퇴를 진행하시겠습니까?",
                                          "Confirm Delete",
                                          MessageBoxButton.YesNo,
                                          MessageBoxImage.Warning);
            
            if (result == MessageBoxResult.Yes && personToDelete != null)
            {
                People.Remove(personToDelete);
            }
        }

    }
}
