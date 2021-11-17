using site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Interfaces
{
    interface IFish
    {
        IEnumerable<Fish> GetFishId { get; }
    }
}
