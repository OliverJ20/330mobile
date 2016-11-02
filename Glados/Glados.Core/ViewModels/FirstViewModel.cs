using MvvmCross.Core.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glados.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        public ICommand ProfileNav
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<ProfileViewModel>());
            }
        }
        public ICommand FavoritesNav
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<FavoriteViewModel>());
            }
        }
        public ICommand RecentsNav
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<RecentsViewModel>());
            }
        }
        public ICommand SettingsNav
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<SettingsViewModel>());
            }
        }
        public ICommand SearchNav
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<SearchViewModel>());
            }
        }
    }
}
