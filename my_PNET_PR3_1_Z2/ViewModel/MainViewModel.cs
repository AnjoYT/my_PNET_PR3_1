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
using org.mariuszgromada.math.mxparser;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Documents;
using System.Data.Common;

namespace my_PNET_PR3_1_Z2.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _value;
        private string _previousValue;   
        private bool _lastIsOperator;

        public ICommand NumberCommand { get; }
        public ICommand BaseOperationCommand { get; }
        public ICommand SquareNumberCommand { get; }
        public ICommand OperationNumberCommand { get; }
        public ICommand SqRootNumberCommand { get; }
        public ICommand RoundUpNumberCommand { get; }
        public ICommand RoundDownNumberCommand { get; }
        public ICommand SumNumberCommand { get; }
        public ICommand ClrCommand { get; }
        public ICommand CommaCommand { get; }
        public ICommand ParentesisCommaCommand { get; }
        public ICommand BackCommand { get; }
        public ICommand FlipCommand { get; }
        public ICommand CECommand { get; }
        public ICommand SwitchCommand { get; }
        public MainViewModel() 
        {
            NumberCommand = new NumbersCommand(Number);
            BaseOperationCommand = new BaseOperationCommand(BaseOperation,lastIsOperator);
            SquareNumberCommand = new NumbersCommand(SquareNumber);
            SumNumberCommand = new NumbersCommand(SumNumber);
            CommaCommand = new BaseOperationCommand(BaseOperation, lastIsOperator);
            OperationNumberCommand = new BaseOperationCommand(OperationNumber, lastIsOperator);
            ClrCommand = new NumbersCommand(Clr);
            ParentesisCommaCommand = new BaseOperationCommand(Parentesis, lastIsOperator);
            RoundUpNumberCommand = new BaseOperationCommand(RoundUpNumber, lastIsOperator);
            RoundDownNumberCommand = new BaseOperationCommand(RoundDownNumber, lastIsOperator);
            SqRootNumberCommand = new BaseOperationCommand(BaseOperation, lastIsOperator);
            CECommand = new NumbersCommand(CE);
            BackCommand = new NumbersCommand(Back);
            FlipCommand = new NumbersCommand(Flip);
            SwitchCommand = new NumbersCommand(Switch);
            Value = "0";
        }

        public bool lastIsOperator(object parameter)
        {
            return !_lastIsOperator;
        }

        public void Back(object parameter)
        {
            if (Value != "") Value = Value.Remove(Value.Length - 1, 1);
            LastIsOperator = false;

        }

        public void Flip(object parameter)
        {
            SumNumber(parameter);
            Expression e = new Expression("1/"+Value);
            Value = e.calculate().ToString();

        }
        public void Switch(object parameter)
        {
            SumNumber(parameter);

            if (Value != "0" && Value != "NaN") Value = "-" + Value;

        }

        public void Number(object parameter)
        { if (Value == "0" || Value =="NaN") { Value = ""; }
            Value += parameter;
            LastIsOperator = false;
        }

        public void BaseOperation(object parameter)
        {
            if (Value == "0" && parameter?.ToString() == "√" || Value == "NaN") { Value = ""; }
            Value += parameter;
            LastIsOperator = true;

        }

        public void SquareNumber(object parameter)
        {
            SumNumber(parameter);
            Expression e = new Expression(Value + parameter);
            Value = e.calculate().ToString();

        }
        public void OperationNumber(object parameter)
        {
            SumNumber(parameter);
            Value = parameter+"(" + Value+",";
            LastIsOperator = true;
        }

        public void RoundUpNumber(object parameter)
        {
            SumNumber(parameter);
            Value = Math.Ceiling(Convert.ToDouble(Value)).ToString();
        }
        public void RoundDownNumber(object parameter)
        {
            SumNumber(parameter);
            Value = Math.Floor(Convert.ToDouble(Value)).ToString();
        }
        public void SumNumber(object parameter)
        {   
            PreviousValue = Value;
            Expression e = new Expression(Value);
            Value = e.calculate().ToString();
            LastIsOperator = false;
        }
        public void Clr(object parameter)
        {
            Value = "0";
            LastIsOperator = false;
        }
        public void CE(object parameter)
        {
            Clr(parameter);
            PreviousValue = "";
        }
        public void Parentesis(object parameter)
        {
            if (Value == "0") { Value = ""; }
            Value += parameter;
            LastIsOperator = false;
        }

        public string PreviousValue 
        {
            get { return _previousValue; }
            set 
            { 
                _previousValue = value;
                OnPropertyChanged();
            }
        }
        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged();
            }
        }
        public bool LastIsOperator
        {
            get { return _lastIsOperator; }
            set
            {
                _lastIsOperator = value;
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
