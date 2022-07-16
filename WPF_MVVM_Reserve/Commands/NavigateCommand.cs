using System;
using WPF_MVVM_Reserve.Services;
using WPF_MVVM_Reserve.Stores;
using WPF_MVVM_Reserve.ViewModels;

namespace WPF_MVVM_Reserve.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigationService _navigationService;

        public NavigateCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
