using System.Windows;
using WPF_MVVM_Reserve.Models;
using WPF_MVVM_Reserve.ViewModels;

namespace WPF_MVVM_Reserve
{
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        public App()
        {
            _hotel = new Hotel("SingletonSean Suites");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_hotel)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
