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
        private MainViewModel viewModel;
        public NumbersCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            viewModel.Number(parameter);
        }

    }
    internal class BaseOperationCommand : CommandBase
    {
        private MainViewModel viewModel;

        public BaseOperationCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public override bool CanExecute(object? parameter)
        {
            return !viewModel.LastIsOperator;
        }

        public override void Execute(object? parameter)
        {
            viewModel.BaseOperation(parameter);
        }
    }
}
