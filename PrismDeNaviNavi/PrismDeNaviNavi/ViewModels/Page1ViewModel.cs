using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace PrismDeNaviNavi.ViewModels
{
    public class Page1ViewModel : BindableBase
    {
        private INavigationService _navigationService;

        public ICommand NextPageCommand { get; }

        public Page1ViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NextPageCommand = new DelegateCommand(NextPage);
        }

        async private void NextPage()
        {
            await _navigationService.NavigateAsync("SubPage1");
        }
    }
}
