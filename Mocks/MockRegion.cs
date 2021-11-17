using site.Interfaces;
using site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Mocks
{
    public class MockRegion : IRegion
    {
        public IEnumerable<Region> GetRegionId
        {
            get
            {
                return new List<Region> {
                    new Region {id = 4321 }
            };
            }
        }

    }
}

