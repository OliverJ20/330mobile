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
using CrossDrawer.Core.ViewModels;

namespace CrossDrawer.Core
{
    public class FavoriteViewModel : MvxViewModel
    {
    
           public ICommand SelectProfileCommand { get; private set; }
        


        

        List<NameAutoCompleteResult> names = new List<NameAutoCompleteResult>();
        private ObservableCollection<Name> coworkerNames = new ObservableCollection<Name>();
  
        private readonly INameDatabase nameDatabase;
        public ObservableCollection<Name> CoWorkerNames
        {
            get { return coworkerNames; }
            set { SetProperty(ref coworkerNames, value); }
        }
          public ICommand AddNewNameCommand { get; private set; }

             public FavoriteViewModel(INameDatabase nameDatabase)
            {
               this.nameDatabase = nameDatabase;
                SelectProfileCommand = new MvxCommand<Name>(selectedName => ShowViewModel<ProfileViewModel>(selectedName));
        
        //      AddNewNameCommand = new MvxCommand(() => ShowViewModel<>)

    }
       // ProfileSwitch = new MvxCommand<CoWorkerNames>(ProfileView => ShowViewModel<ProfileViewModel>(ProfileView));
        
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
           //     ProfileSwitch = new MvxCommand<CoWorkerNames>(ProfileView => ShowViewModel<ProfileViewModel>(ProfileView));
            }
          
        }
        private MvxCommand _ProfileClickedCommand;
        public IMvxCommand ProfileClickedCommand
        {
            get
            {
                _ProfileClickedCommand = _ProfileClickedCommand ?? new MvxCommand(() => ShowViewModel<MainViewModel>());
                return _ProfileClickedCommand;
                //return ProfileClickedCommand = new MvxCommand<Name>(profileClickedCommand => ShowViewModel<ProfileViewModel>(profileClickedCommand));
               // return new MvxCommand(() => ShowViewModel<ProfileViewModel>());
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
