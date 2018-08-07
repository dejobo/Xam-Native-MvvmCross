using System;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace TodoApp.Core.ViewModels.ItemViewModels
{
    public class ItemBaseViewModel<T> : MvxViewModel
    {
        private T mModel;
        public T Model
        {
            get
            {
                return mModel;
            }
            set
            {
                mModel = value;
                this.RaisePropertyChanged(() => Model);
                OnEditModel();
            }
        }
        
        public ItemBaseViewModel(T _Model)
        {
            Model = _Model;
        }

        public Action<T> MoreAction { get; set; } = null;

        public ICommand MoreCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    if (MoreAction != null)
                    {
                        MoreAction(this.Model);
                    }
                });
            }
        }

        public virtual void OnEditModel()
        {
            
        }
    }
}
