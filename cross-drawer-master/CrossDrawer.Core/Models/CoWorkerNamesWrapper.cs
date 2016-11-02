using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossDrawer.Core.Models
{
    public class CoWorkerNamesWrapper : CoWorkerNames
    {
        public CoWorkerNamesWrapper(CoWorkerNames coWorkerNames, string localizedName)
        {
            WorkerNames = coWorkerNames.WorkerNames;
            LocalizedName = localizedName;

        }
        public string LocalizedName { get; set; }
    }
}
