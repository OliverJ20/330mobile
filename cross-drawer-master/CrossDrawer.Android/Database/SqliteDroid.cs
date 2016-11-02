using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


using SQLite.Net;
using System.IO;
using SQLite.Net.Platform.XamarinAndroid;
using CrossDrawer.Core.Interfaces;
using System.Xml;

namespace CrossDrawer.Android.Database

{
    public class SqliteDroid : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "NameSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
       
            var conn = new SQLiteConnection(new
               SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(), path);
          

            return conn;
        }
    }
}