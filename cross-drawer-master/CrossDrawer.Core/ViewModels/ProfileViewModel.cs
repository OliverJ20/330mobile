using CrossDrawer.Core.Interfaces;
using CrossDrawer.Core.Models;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace CrossDrawer.Core.ViewModels
{
    public class ProfileViewModel : MvxViewModel
    {
        private NameAutoCompleteResult selectedName;
        List<NameAutoCompleteResult> names = new List<NameAutoCompleteResult>();
        private ObservableCollection<Name> coworkerNames = new ObservableCollection<Name>();
        private readonly INameDatabase nameDatabase;




    
       
        















        public ObservableCollection<Name> CoWorkerNames
        {
            get { return coworkerNames; }
            set { SetProperty(ref coworkerNames, value); }
        }

        public ICommand AddNewNameCommand { get; private set; }

        public ProfileViewModel(INameDatabase nameDatabase)
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
           var filteredNames = names.FirstOrDefault(coworkerNames => coworkerNames.Id == 35);
            CoWorkerNames.Add(filteredNames);
           // CoWorkerNames.Add(names);

           //  foreach (var name in names)
          //  {
            // coworkerNames.Where(coworkerNames => coworkerNames.Id == 1);
            //coworkerNames.FirstOrDefault();
            //     names.FirstOrDefault();
            //coworkerNames.where(name => )
           //  CoWorkerNames.Add(name);
           // }
        }
        public void Init (NameAutoCompleteResult parameters)
        {
            selectedName = parameters; 
        }


        private string profile;

        public string Profile
        {
            get { return profile; }
            set { SetProperty(ref profile, value); }
        }

        public override void Start ()
        {
            base.Start();
            Profile = selectedName.Department;
            GetCoWorkerNames();
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
