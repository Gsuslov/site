using site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Interfaces
{
    interface IRegion
    {
        IEnumerable<Region> GetRegionId { get; }
    }
}
