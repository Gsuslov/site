using site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Interfaces
{
    interface IBait
    {
        IEnumerable<Bait> GetBaitId { get; }
    }
}
