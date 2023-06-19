using my_PNET_PR3_1_Z2.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace my_PNET_PR3_1_Z2.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string value;
        
        public MainViewModel() 
        {
            Value = "0";
        }
        public string Value
        {
            get { return value; }
            set
            {
                this.value = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
