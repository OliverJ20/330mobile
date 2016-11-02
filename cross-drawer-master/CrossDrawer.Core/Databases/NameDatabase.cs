using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite.Net;
using CrossDrawer.Core.Interfaces;
using MvvmCross.Platform;
using CrossDrawer.Core.Models;
using CrossDrawer.Core.ViewModels;


namespace CrossDrawer.Core.Databases
{
    public class NameDatabase : INameDatabase

    {
        private SQLiteConnection database;

        public NameDatabase()
        {
            var sqlite = Mvx.Resolve<ISqlite>();
            database = sqlite.GetConnection();
            database.CreateTable<Name>();
        }
        public async Task<IEnumerable<Name>> GetNames()
        {
            return database.Table<Name>().ToList();
        }
        public async Task<int> DeleteName(object id)
        {
            return database.Delete<Name>(Convert.ToInt16(id));
        }

        public async Task<int> InsertName(Name name)
        {
            var num = database.Insert(name);
            database.Commit();
            return num;
        }
       // public async Task<int> InsertDepartment(Name department)
        //{
         //   var num = database.Insert(department);
          //  database.Commit();
           // return num;
       // }








    }
}
