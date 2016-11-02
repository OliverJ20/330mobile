using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SQLite.Net.Attributes;
namespace CrossDrawer.Core.Models
{
    public class Name
    {
        private NameAutoCompleteResult name;

        public Name() { }

        public Name(NameAutoCompleteResult name)
        {
            this.name = name;
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Full_Name { get; set; }
        public string Last_Name { get; set; }

        public string Current_Status { get; set; }

        public string Department { get; set; }

        public string Skill_One { get; set; }
        public string Skill_Two { get; set; }
        public string Skill_Three { get; set; }


    }
}
