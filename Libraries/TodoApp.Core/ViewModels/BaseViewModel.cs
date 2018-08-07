using System;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using TodoApp.Services.Todo;

namespace TodoApp.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        protected readonly IMvxNavigationService _navigationService;

        public BaseViewModel(IMvxNavigationService navigationService)
        {
            this._navigationService = navigationService;
        }

        private bool mIsBusy = false;
        public bool IsBusy
        {
            get
            {
                return mIsBusy;
            }
            set
            {
                mIsBusy = value;

            }
        }

        public System.Windows.Input.ICommand BackCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    _navigationService.Close(this);
                });
            }
        }
    }
}
