using Microsoft.EntityFrameworkCore;
using Nav.EntityContext;
using Nav.Stores;
using Nav.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Nav
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string ConnectionString = "Data Source=person.db";

        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(ConnectionString).Options;
            PersonDbContext dbContext = new PersonDbContext(options);
            dbContext.Database.Migrate();

            NavigationStore navigationStore = new();
            navigationStore.CurrentViewModel = new HomeViewModel(navigationStore) ;

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

    }
}
