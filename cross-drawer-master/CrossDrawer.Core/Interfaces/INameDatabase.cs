using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossDrawer.Core.Models;

namespace CrossDrawer.Core.Interfaces
{
    public interface INameDatabase
    {
        Task<IEnumerable<Name>> GetNames();
        Task<int> InsertName(Name name);

    }
}
