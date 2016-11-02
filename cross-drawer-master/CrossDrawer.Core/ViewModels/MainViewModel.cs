using CrossDrawer.Core;
using CrossDrawer.Core.Databases;
using CrossDrawer.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;

namespace CrossDrawer.Core
{
	public class MainViewModel : MvxViewModel
	{
		readonly Type[] _menuItemTypes = {
			typeof(HomeViewModel),
			typeof(FavoriteViewModel),
            typeof(RecentsViewModel),
            typeof(ProfileViewModel),
            typeof(SettingsViewModel)
		};

        public IEnumerable<string> MenuItems { get; private set; } = new [] { "Home", "Favorites", "Recents", "Profile", "Settings" };

		public void ShowDefaultMenuItem()
		{
			NavigateTo (0);
		}

		public void NavigateTo (int position)
		{
			ShowViewModel (_menuItemTypes [position]);
		}
	}

	public class MenuItem : Tuple<string, Type>
	{
		public MenuItem (string displayName, Type viewModelType)
			: base (displayName, viewModelType)
		{}

		public string DisplayName
		{
			get { return Item1; }
		}

		public Type ViewModelType
		{
			get { return Item2; }
		}
	}
}