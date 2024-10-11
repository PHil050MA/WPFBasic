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
using ToDoListApp;

namespace ToDoListApp
{
    /// <summary>
    /// EditPopup.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EditPopup : Window
    {
        private string tempdesc;
        public EditPopup(ToDoItem item)
        {
            InitializeComponent();
            DataContext = item;
            tempdesc = item.Description;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool result = DialogResult ?? false;
            if (!result)
                (DataContext as ToDoItem).Description = tempdesc;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
