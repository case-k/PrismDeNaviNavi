using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace PrismDeNaviNavi.ViewModels
{
    public class Page2ViewModel : BindableBase
    {
        private INavigationService _navigationService;

        public ICommand NextPageCommand { get; }

        public Page2ViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NextPageCommand = new DelegateCommand(NextPage);
        }

        async private void NextPage()
        {
            await _navigationService.NavigateAsync("SubPage2");
        }
    }
}
