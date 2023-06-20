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
        private string _value;
        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged();
            }
        }

        public ICommand NumberCommand { get; }
        public ICommand DivideNumberCommand { get; }
        public ICommand MultiplyNumberCommand { get; }
        public ICommand SquareNumberCommand { get; }
        public ICommand ModuloNumberCommand { get; }
        public ICommand FactorialNumberCommand { get; }
        public ICommand SqRootNumberCommand { get; }
        public ICommand SubtrNumberCommand { get; }
        public ICommand AddNumberCommand { get; }
        public ICommand LogNumberCommand { get; }
        public ICommand RoundUpNumberCommand { get; }
        public ICommand RoundDownNumberCommand { get; }
        public ICommand SumNumberCommand { get; }
        public ICommand ClrCommand { get; }
        public ICommand CommaCommand { get; }

        long number1;
        long number2;
        long memory;
        public MainViewModel() 
        {
            NumberCommand = new NumbersCommand(this);
            Value = "0";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Number(object parameter)
        {
            Value += parameter.ToString();
        }

        public void AddNumber(object parameter)
        {

        }

        public void DivideNumber(object parameter)
        {

        }

        public void MultiplyNumber(object parameter)
        {

        }
        public void SquareNumber(object parameter)
        {

        }
        public void ModuloNumber(object parameter)
        {

        }
        public void FactorialNumber(object parameter)
        {

        }
        public void SqRootNumber(object parameter)
        {

        }
        public void SubtrNumber(object parameter)
        {

        }
        public void LogNumber(object parameter)
        {

        }
        public void RoundUpNumber(object parameter)
        {

        }
        public void RoundDownNumber(object parameter)
        {

        }
        public void SumNumber(object parameter)
        {

        }
        public void Clr(object parameter)
        {

        }
        public void Comma(object parameter)
        {

        }
    }
}
