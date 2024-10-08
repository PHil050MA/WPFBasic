using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDay2Binding
{
    internal class CountModel : INotifyPropertyChanged
    {
        private int counter;
        public int Counter { 
            get { return counter; } 
            set { counter = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged(string propertyName="")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
