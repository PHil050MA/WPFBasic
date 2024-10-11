using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace WpfTabControl.TodoList
{
    /// <summary>
    /// TodoList.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TodoList : Page
    {
        ToDoList tdl = new ToDoList();
        public TodoList()
        {
            InitializeComponent();
            DataContext = tdl;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!txtItemDesc.Text.Trim().Equals(string.Empty))
            {
                tdl.Additem(txtItemDesc.Text.Trim());
            }
            txtItemDesc.Text = "";
            lvToDo.Items.Refresh();
        }
        

        private void MarkAsDone(object sender, RoutedEventArgs e)
        {
            if (lvToDo.SelectedItem != null)
            {
                MessageBoxResult done = MessageBox.Show("Mark this as done?", "Done?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
                if (done == MessageBoxResult.Yes)
                {
                    (lvToDo.SelectedItem as ToDoItem).DoneDateTime = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss.ms");
                }
                lvToDo.Items.Refresh();
            }
        }

        private void lvToDo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MarkAsDone(sender, e);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lvToDo.SelectedItem != null)
            {
                MessageBoxResult del = MessageBox.Show("Delete this item?", "Delete?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
                if (del == MessageBoxResult.Yes)
                {
                    tdl.DeleteItem(lvToDo.SelectedItem as ToDoItem);
                }
                lvToDo.Items.Refresh();
            }
        }
    }
}