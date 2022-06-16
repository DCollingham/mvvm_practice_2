using Bet_mvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bet_mvvm.Commands
{
    public class AddFundsCommand : CommandBase
    {
        private readonly MainWindowViewModel _mainWindowViewModel;
        public AddFundsCommand(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
        }

        public override void Execute(object? parameter)
        {
            Debug.WriteLine(parameter);
            _mainWindowViewModel.AddFunds(_mainWindowViewModel.AddFundAmount);
        }
    }
}
