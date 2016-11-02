using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using Newtonsoft.Json;

namespace CrossDrawer.Core.Models
{
    public class NameAutoCompleteResult
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Full_Name { get; set; }
        public string Last_Name { get; set; }

        public string Current_Status { get; set; }

        public string Department { get; set; }

        public string Skill_One { get; set; }
        public string Skill_Two { get; set; }
        public string Skill_Three { get; set; }


        //  public override string ToString()
        // {
        //     return string.Format("[Person: ID={0}, FirstName={1}, LastName={2}]", Id, FirstName, LastName);
        //}


    }
}
