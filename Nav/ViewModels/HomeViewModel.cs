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
    public class HomeViewModel : ViewModelBase
    {

        public ICommand NavigateCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateCommand = new NavigateCommand<SettingsViewModel>(navigationStore, () => new SettingsViewModel(navigationStore));
        }

    }
}
