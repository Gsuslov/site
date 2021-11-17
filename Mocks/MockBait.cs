using site.Interfaces;
using site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Mocks
{
    public class MockBait : IBait
    {
        public IEnumerable<Bait> GetBaitId
        {
            get 
            {
                return new List<Bait>
                {
                    new Bait { id = 353 }};
                }
           
        }
    }

}

