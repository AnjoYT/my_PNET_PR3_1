using my_PNET_PR3_1_Z2.ViewModel;
using System;
using System.Collections.Generic;
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
}
