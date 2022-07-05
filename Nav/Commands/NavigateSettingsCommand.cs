using Nav.Stores;
using Nav.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nav.Commands
{
    public class NavigateSettingsCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new SettingsViewModel();
        }

        public NavigateSettingsCommand( NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
    }
}
