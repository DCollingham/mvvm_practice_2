using Nav.Commands;
using Nav.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Nav.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        public ICommand NavigateCommand { get; }

        public SettingsViewModel(NavigationStore navigationStore)
        {
            NavigateCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
        }
    }
}

