using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossDrawer.Core.Models
{
    public class CoWorkerNames
    {
        public List<WorkerName> WorkerNames { get; set; }

        public string Names
        {
            get
            {
                return string.Format("HELLO {0}{1}"
                    , WorkerNames.FirstOrDefault().FirstName.ToString()
                    , WorkerNames.FirstOrDefault().LastName.ToString());
            }

        }

        public class WorkerName
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }





    }
}
