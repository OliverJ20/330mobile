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
    public class FavoriteViewModel : MvxViewModel
    {
        public ICommand SearchNav
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<SearchViewModel>());
            }
        }
    }
}
