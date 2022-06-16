using Bet_mvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bet_mvvm.Commands
{
    public class SetBetSizeCommand : CommandBase
    {

        private readonly MainWindowViewModel _mainWindowViewModel;
        public SetBetSizeCommand(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
        }

        public override void Execute(object? parameter)
        {
        }
    }
}
