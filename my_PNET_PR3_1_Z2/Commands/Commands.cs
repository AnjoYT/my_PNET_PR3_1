using my_PNET_PR3_1_Z2.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_PNET_PR3_1_Z2.Commands
{
    internal class NumbersCommand : CommandBase
    {
        private Action<object> _operation;

        public NumbersCommand(Action<object> operation)
        {
            _operation = operation;
        }

        public override void Execute(object? parameter)
        {
            _operation(parameter);
        }

    }

    internal class BaseOperationCommand : CommandBase
    {
        private Action<object> _operation;
        private Predicate<object> _lastIsOperator;

        public BaseOperationCommand(Action<object> operation)
        {
            _operation = operation;
        }
        public BaseOperationCommand(Action<object> operation, Predicate<object> lastIsOperator)
        {
            _operation = operation;
            _lastIsOperator = lastIsOperator;
        }
        public override bool CanExecute(object? parameter)
        {
            return _lastIsOperator == null || _lastIsOperator(parameter);
        }
        public override void Execute(object? parameter)
        {
            _operation(parameter);
        }
    }
}
/*  
   


    internal class SumNumberCommand : CommandBase
    {
        private MainViewModel viewModel;

        public SumNumberCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public override bool CanExecute(object? parameter)
        {
            return !viewModel.LastIsOperator;
        }

        public override void Execute(object? parameter)
        {
            viewModel.SumNumber(parameter);
        }
    }*/