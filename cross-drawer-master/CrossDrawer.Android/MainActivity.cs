﻿using System.Linq;
using Android.App;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using CrossDrawer.Core;
using MvvmCross.Droid.Support.V7.AppCompat;
using Fragment = Android.Support.V4.App.Fragment;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using CrossDrawer.Core.Databases;
using CrossDrawer.Core.Models;
using System.Collections.Generic;

namespace CrossDrawer.Android
{
	[Activity]
	public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
	{
		ActionBarDrawerToggle _drawerToggle;

		ListView _drawerListView;

		DrawerLayout _drawerLayout;

       // List<TableItem> tableItems = new List<TableItem>();

        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
            //tableItems.Add(new TableItem(){ ImageResourceId = Resource.Drawable.ic_favorite_black_24dp});
            var nameDatabase = new NameDatabase();
            for (int i = 0; i <= 200; i++)
            {
                nameDatabase.DeleteName(i);
            }

            nameDatabase.InsertName(new Name
            {
              
                Full_Name = "Alita Weekes",
                Current_Status = "Online",

                Department = "IT",
                Skill_One = "Java",
                Skill_Two = "C#",
                Skill_Three = "C",


                // Last_Name = "Bloe"
            });
            nameDatabase.InsertName(new Name
            {
                Full_Name = "Derek Burton",
                Department = "IT",
                Current_Status = "Away",
                Skill_One = "Android",
                Skill_Two = "IOS",
                Skill_Three = "Swift",
                // Last_Name = "doe"
            });
            nameDatabase.InsertName(new Name
            {
                Full_Name = "Calista Stevens",
                // Last_Name = "doe"
            });
            nameDatabase.InsertName(new Name
            {
                Full_Name = "Goffard Page",
                // Last_Name = "doe"
            });
            nameDatabase.InsertName(new Name
            {
                Full_Name = "Irene Jerome",
                // Last_Name = "doe"
            });
            nameDatabase.InsertName(new Name
            {
                Full_Name = "Janes Maynard",
                // Last_Name = "doe"
            });
            nameDatabase.InsertName(new Name
            {
                Full_Name = "Jim Marlowe",
                // Last_Name = "doe"
            });
            nameDatabase.InsertName(new Name
            {
                Full_Name = "Josh Moors",
                // Last_Name = "doe"
            });
            nameDatabase.InsertName(new Name
            {
                Full_Name = "Lyndsea Rain",
                // Last_Name = "doe"
            });
            nameDatabase.InsertName(new Name
            {
                Full_Name = "Standord Crewe",
                // Last_Name = "doe"
            });
            nameDatabase.InsertName(new Name
            {
                Full_Name = "Olaf Milton",
                // Last_Name = "doe"
            });
            nameDatabase.InsertName(new Name
            {
                Full_Name = "Oliver Johnson",
                // Last_Name = "doe"
            });
            nameDatabase.InsertName(new Name
            {
                Full_Name = "Jai Spicer"
                // Last_Name = "doe"
            });
            
           




            SetContentView(Resource.Layout.Main);

			var toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);
			SetSupportActionBar (toolbar);

			SupportActionBar.SetDisplayHomeAsUpEnabled (true);

			_drawerListView = FindViewById<ListView> (Resource.Id.drawerListView);
			_drawerListView.ItemClick += (s, e) => ShowFragmentAt (e.Position);
			_drawerListView.Adapter = new ArrayAdapter<string> (this, global::Android.Resource.Layout.SimpleListItem1, ViewModel.MenuItems.ToArray());

			_drawerLayout = FindViewById<DrawerLayout> (Resource.Id.drawerLayout);

			_drawerToggle = new ActionBarDrawerToggle (this, _drawerLayout, Resource.String.OpenDrawerString, Resource.String.CloseDrawerString);

			_drawerLayout.SetDrawerListener (_drawerToggle);

			ShowFragmentAt (0);
		}

		void ShowFragmentAt (int position)
		{
			ViewModel.NavigateTo (position);

			Title = ViewModel.MenuItems.ElementAt (position);

			_drawerLayout.CloseDrawer (_drawerListView);
		}

		protected override void OnPostCreate (Bundle savedInstanceState)
		{
			_drawerToggle.SyncState ();

			base.OnPostCreate (savedInstanceState);
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			if (_drawerToggle.OnOptionsItemSelected (item))
				return true;

			return base.OnOptionsItemSelected (item);
		}
	}
}