using CrossDrawer.Core;
using CrossDrawer.Core.Interfaces;
using MvvmCross.Core.ViewModels;

using System.ComponentModel;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrossDrawer.Core.Databases;
using CrossDrawer.Core.ViewModels;

namespace CrossDrawer.Core
{
	public class HomeViewModel : MvxViewModel
	{
        public ICommand FavoritesNav
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<FavoriteViewModel>(), () => true);
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


        public ICommand ProfileNav
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<ProfileViewModel>());
            }
        }
        public HomeViewModel()
        {
       
        }
    }
}