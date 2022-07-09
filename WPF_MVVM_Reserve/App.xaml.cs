using System.Windows;
using WPF_MVVM_Reserve.ViewModels;

namespace WPF_MVVM_Reserve
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
