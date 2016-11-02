using MvvmCross.Core.ViewModels;


using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrossDrawer.Core.Models;
using CrossDrawer.Core.Interfaces;

namespace CrossDrawer.Core
{
    public class RecentsViewModel : MvxViewModel
    {
        List<NameAutoCompleteResult> names = new List<NameAutoCompleteResult>();
        private ObservableCollection<Name> coworkerNames = new ObservableCollection<Name>();
        private readonly INameDatabase nameDatabase;
        public ObservableCollection<Name> CoWorkerNames
        {
            get { return coworkerNames; }
            set { SetProperty(ref coworkerNames, value); }
        }
        public ICommand AddNewNameCommand { get; private set; }

        public ICommand SelectProfileCommand { get; private set; }
        public RecentsViewModel(INameDatabase nameDatabase)
        {
            this.nameDatabase = nameDatabase;
            //      AddNewNameCommand = new MvxCommand(() => ShowViewModel<>)
        }

        public void OnResume()
        {
            GetCoWorkerNames();
        }
        public async void GetCoWorkerNames()
        {
            var names = await nameDatabase.GetNames();
            CoWorkerNames.Clear();
            foreach (var name in names)
            {
                CoWorkerNames.Add(name);
            }
        }

        //public ICommand SearchNav
        //   {
        //       get
        //     {
        //         return new MvxCommand(() => ShowViewModel<SearchViewModel>());
        //     }
        //  }
    }
}
