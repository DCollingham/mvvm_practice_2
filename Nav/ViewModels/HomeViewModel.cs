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
        public ICommand NavigateSettingsCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateSettingsCommand = new NavigateSettingsCommand(navigationStore);
        }
    }
}
